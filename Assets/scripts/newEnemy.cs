using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemy : MonoBehaviour {
	public static bool hatched;
	public float speed;
	public float distance;
	private float xStartPosition;
	bool flip;
	public Sprite dragon; 
	public Sprite dragonFire;
	private SpriteRenderer spriteRenderer; 

	void Start () {
		xStartPosition = transform.position.x;
		flip = true;
		spriteRenderer = GetComponent<SpriteRenderer>(); 
		transform.localScale = new Vector3 (0.1f, 0.1f, 1);

	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag.Contains("Player")){
			this.GetComponent<BoxCollider2D> ().enabled = false;
			//play animation of poof
			//hatched = true;
			Invoke ("hatchTheEgg", 5);
		}
	}
	void hatchTheEgg(){
		Debug.Log ("hatch the egg method");
		hatched = true;
		spriteRenderer.sprite = dragon;
		Destroy (GetComponent<PolygonCollider2D> ());
		this.gameObject.AddComponent<PolygonCollider2D>();
	}

	void Update () {
		//to add: everyso often breathe fire
		if (hatched) {
			if ((speed < 0 && transform.position.x < xStartPosition) || (speed > 0 && transform.position.x > xStartPosition + distance)) {
				speed *= -1;
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;

			}
			transform.position = new Vector2 (transform.position.x + speed * Time.deltaTime, transform.position.y);
		} else {
			//animate wobbly egg????
		}
	}



}
