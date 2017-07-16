using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	Rigidbody2D myBody;
	Transform myTrans;
	float myWidth;
	public float speed;
	public LayerMask enemyMask; 
	public float speed2 = 0.5f;
	public bool enemyTypeAboveGround;
	public Vector3 pos1;
	public Vector3 pos2;

	// Use this for initialization
	void Start () {
		myTrans = this.transform;
		myBody = this.GetComponent<Rigidbody2D>();
		myWidth = this.GetComponent<SpriteRenderer> ().bounds.extents.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (enemyTypeAboveGround) {
			Vector2 linecastPos = myTrans.position - myTrans.right * (myWidth / 2);
			Debug.DrawLine (linecastPos, linecastPos + Vector2.down);
			Debug.DrawLine (linecastPos, linecastPos + Vector2.right * (myWidth / 3));
			Debug.DrawLine (linecastPos, linecastPos + Vector2.left * (myWidth / 3));


			bool isGrounded = Physics2D.Linecast (linecastPos, linecastPos + Vector2.down, enemyMask);
			//Debug.Log (Physics2D.Linecast (linecastPos, linecastPos + Vector2.right, enemyMask));

			if (!isGrounded) {
				Vector3 currRot = myTrans.eulerAngles;
				currRot.y += 180;
				myTrans.eulerAngles = currRot;
			}

			//Always move forward
			Vector2 myVel = myBody.velocity;
			myVel.x = -myTrans.right.x * speed;
			myBody.velocity = myVel;
		} else {
			Debug.Log (pos1 + " " + pos2);

			transform.position = Vector3.Lerp (myTrans.position+pos1, myTrans.position+pos2, Mathf.PingPong(Time.time*speed2, 1.0f));
			Debug.Log (transform.position.x);
			if (transform.position.x < 1.24) {
				transform.localScale = new Vector3 (0.1274577f, 0.1274577f, 0.1274577f);
			} else if (transform.position.x > 2.4) {
				transform.localScale = new Vector3 (-0.1274577f, 0.1274577f, 0.1274577f);

			
			
		}
	}
}
}
