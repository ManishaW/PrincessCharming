using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemy : MonoBehaviour {
	public static bool hatched;
	public float speed;
	public float distance;
	private float xStartPosition;
	bool flip;

	void Start () {
		xStartPosition = transform.position.x;
		flip = true;
		
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag.Contains("Player")){
			this.GetComponent<BoxCollider2D> ().enabled = false;
			hatched = true;
		}
	}

	void Update () {
		
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
