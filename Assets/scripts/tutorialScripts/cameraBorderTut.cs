using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBorderTut : MonoBehaviour {

	//far left
	private float minPos = -2f; 
	//far right
	private float maxPos = 4.075f;
	AudioSource audio;
	musicSettings musicSett;
	private Vector2 velocity;
	public float smoothTimeX;
	public float smoothTimeY;

	public GameObject player;

	public bool bounds= true;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		GameObject settings = GameObject.FindGameObjectWithTag("musicVol"); 
		musicSett = (musicSettings)settings.GetComponent (typeof(musicSettings));

		audio.volume = musicSett.GetMusicVolume ();

		player = GameObject.FindGameObjectWithTag("Player");
	}

	void FixedUpdate () {

		//move from A to B smooth
		float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

		transform.position = new Vector3(posX, posY, transform.position.z);

		//camera boundaries
		if (bounds) {
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPos, maxPos),
				transform.position.y, transform.position.z);
		}
	}
}
