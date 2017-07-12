using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	//variables
	private float maxSpeed = 6f;
	private float speed = 6f;

	public bool grounded;
	private bool facingRight;


	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		facingRight = true;
	}

	// Update is called once per frame
	void Update () {

		//flip sprite
		//moving left
		if(Input.GetAxis("Horizontal") < -0.1f) {
			facingRight = false;
			transform.localScale = new Vector3(-1, 1, 1);
		}

		//moving right
		if (Input.GetAxis("Horizontal") > 0.1f)
		{
			facingRight = true;
			transform.localScale = new Vector3(1, 1, 1);
		}

		//jumping
		if(Input.GetButtonDown("Vertical"))  {
			//if the player is on the ground
			if (grounded) {
				rb2d.AddForce (Vector2.up * 200f);
			}
		}
	}

	void FixedUpdate(){

		//moving player horizontally
		float hor = Input.GetAxis("Horizontal");
		rb2d.AddForce((Vector2.right * speed) * hor);

		//limiting speed of player
		if (rb2d.velocity.x > maxSpeed) {
			rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
		}

		if(rb2d.velocity.x < -maxSpeed) {
			rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
		}
	}

}
