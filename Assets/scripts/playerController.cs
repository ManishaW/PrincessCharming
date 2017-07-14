using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	//variables
	private float maxSpeed = 50f;
	private float speed = 50f;

	public bool grounded;
	private bool facingRight;
	private bool hasKey;

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
			transform.localScale = new Vector3(-0.24f, 0.24f, 1);
		}

		//moving right
		if (Input.GetAxis("Horizontal") > 0.1f)
		{
			facingRight = true;
			transform.localScale = new Vector3(0.24f, 0.24f, 1);
		}

		//jumping
		if(Input.GetButtonDown("Vertical"))  {
			//if the player is on the ground
			if (grounded) {
				rb2d.AddForce(Vector2.up * 170f );
			}
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name.Contains ("gem")) {
			Destroy (col.gameObject);
		}
	}

	void FixedUpdate(){

		//moving player horizontally
		float hor = Input.GetAxis("Horizontal");
		rb2d.velocity = new Vector2 (hor * speed * Time.deltaTime, rb2d.velocity.y);
	
		//limiting speed of player
		if (rb2d.velocity.x > maxSpeed) {
			rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
		}

		if(rb2d.velocity.x < -maxSpeed) {
			rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
		}
	}

	public void setKey(bool obtained){
		hasKey = obtained;
	}

	public bool getKey(){
		return hasKey;
	}
}
