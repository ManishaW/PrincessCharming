using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newEnemy : MonoBehaviour {
	private bool hatched;
	public float speed;
	public float distance;
	private float xStartPosition;
	private bool rightflip;
	private Animator myAnimator;
	private GameObject myParent;

	void Start () {
		rightflip = true;
		//transform.localScale = new Vector3 (0.05f, 0.05f, 1);
		myAnimator = GetComponent<Animator> ();
		this.hatched = false;
		if (transform.parent.gameObject.name.Contains("flipDragon")){
			myParent = transform.parent.gameObject;
			
		}

	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag.Contains("Player")){
			this.GetComponent<BoxCollider2D> ().enabled = false;
			//play animation of poof
			Invoke("waitHatch",1.5f);
			myAnimator.SetBool ("hatch", true);
			xStartPosition = myParent.transform.position.x;

		}
	}

	void waitHatch(){
		this.hatched = true;
		myAnimator.SetBool ("moveDragon", true);
	}


	void Update () {
		//to add: everyso often breathe fire
		if (this.hatched && myParent!=null) {
			Destroy (GetComponent<PolygonCollider2D> ());
			this.gameObject.AddComponent<PolygonCollider2D>();
			if ((speed < 0 && myParent.transform.position.x < xStartPosition) || (speed > 0 && myParent.transform.position.x > xStartPosition + distance)) {
				
				speed *= -1;
				Vector2 theScale = myParent.transform.localScale;
				//Debug.Log (transform.localScale);
				
				theScale.x *= -1;
				myParent.transform.localScale = theScale;

			}

			myParent.transform.position = new Vector2 (myParent.transform.position.x + speed * Time.deltaTime, myParent.transform.position.y);
		}
	}



}
