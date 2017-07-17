using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	//variables
	private float maxSpeed = 50f;
	private float speed = 50f;
	public GameObject failedCanvas;
	public GameObject pauseCanvas;
	public bool grounded;
	private bool facingRight;
	public float timeLeft=60f;
	private bool hasKey;
	private Text counter;
	private Text timer;
	public static bool gamePaused= false;
	public Sprite run;
	public Sprite idle;
//	public Sprite attack;
	private SpriteRenderer spriteRenderer; 
	private Animator myAnimation;

		

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D>();
		facingRight = true;
		counter = GameObject.FindWithTag("gemCount").GetComponent<Text>();
		timer = GameObject.FindWithTag("timer").GetComponent<Text>();
		timer.text = timeLeft.ToString("f0");
		myAnimation = GetComponent<Animator> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {

		myAnimation.SetFloat ("speed", Mathf.Abs (rb2d.velocity.x));
		//flip sprite
		//moving left
		if (Input.GetAxis ("Horizontal") < -0.1f) {
			facingRight = false;
			spriteRenderer.sprite = run;
			transform.localScale = new Vector3 (-0.22f, 0.22f, 1);
		}

		//moving right
		else if (Input.GetAxis ("Horizontal") > 0.1f) {
			facingRight = true;
			spriteRenderer.sprite = run;
			transform.localScale = new Vector3 (0.22f, 0.22f, 1);
		}

		//jumping

		else {
			if (facingRight) {
				transform.localScale = new Vector3 (0.24f, 0.24f, 1);
				spriteRenderer.sprite = idle;

			} else {
				transform.localScale = new Vector3 (-0.24f, 0.24f, 1);
				spriteRenderer.sprite = idle;
			}

		}
		if (Input.GetButtonDown ("Vertical")) {
			//if the player is on the ground
			if (grounded) {
				rb2d.AddForce (Vector2.up * 170f);
				//spriteRenderer.sprite = run;
			}
		}

		//pause
		if(Input.GetButtonDown("Pause"))  {
			gamePaused = true;
			Time.timeScale = 0;
			pauseCanvas.SetActive (true);
		}

		if (!gamePaused) {
			timeLeft -= Time.deltaTime;
			timer.text = timeLeft.ToString ("f0");
			if (timeLeft <= 0) {
				GameOver ();
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name.Contains ("gem")) {
			Destroy (col.gameObject);
			int count = Int32.Parse(counter.text);
			count++;
			counter.text = count.ToString();

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

	void GameOver(){
		failedCanvas.SetActive(true);
		GameObject.FindWithTag ("ouch").GetComponent<Text> ().text = "Time's Up!";
		GameObject.FindWithTag ("egg").SetActive (false);
		Time.timeScale = 0.0f;
	}
}
