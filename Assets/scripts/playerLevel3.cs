using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLevel3 : MonoBehaviour {

	//variables
	private float maxSpeed = 5;
	private float speed = 5;

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
			transform.localScale = new Vector3(0.25f,0.25f,1);

		}

		//moving right
		if (Input.GetAxis("Horizontal") > 0.1f)
		{
			facingRight = true;
			transform.localScale = new Vector3(-0.25f,0.25f,1);
		}

		//jumping
		if(Input.GetButtonDown("Jump"))  {
			//if the player is on the ground
			if (grounded) {
				rb2d.AddForce (Vector2.up * 150f);
			}
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name.Contains("gem")) {
			Destroy (col.gameObject);


		}
	}

	void FixedUpdate(){

		//ector3 isVelocity = rb2d.velocity;
		//isVelocity.y = rb2d.velocity.y;
		//isVelocity.x = isVelocity.x * 0.75f;
		//isVelocity.z = 0.0f;

		//make friction on ground using xspeed of player
		//if (grounded){

		//	rb2d.velocity = isVelocity;
		//}

		//moving player horizontally
		float hor = Input.GetAxis("Horizontal");
		rb2d.AddForce((Vector2.right * speed) * hor);

//		//limiting speed of player
//		if (rb2d.velocity.x > maxSpeed) {
//			rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
//		}
//
//		if(rb2d.velocity.x < -maxSpeed) {
//			rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
//		}
	}


}
