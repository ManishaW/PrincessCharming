using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	Rigidbody2D myBody;
	Transform myTrans;
	float myWidth;
	public float speed;
	public LayerMask enemyMask; 

	// Use this for initialization
	void Start () {
		myTrans = this.transform;
		myBody = this.GetComponent<Rigidbody2D>();
		myWidth = this.GetComponent<SpriteRenderer> ().bounds.extents.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 linecastPos = myTrans.position - myTrans.right * (myWidth/2);
		Debug.DrawLine(linecastPos, linecastPos + Vector2.down);
		Debug.DrawLine(linecastPos, linecastPos + Vector2.right);
		Debug.DrawLine(linecastPos, linecastPos + Vector2.left);


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

	}
}
