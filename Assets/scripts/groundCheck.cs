using UnityEngine;
using System.Collections;

public class groundCheck : MonoBehaviour {

	private playerController player;

	void Start() {
		player = gameObject.GetComponentInParent<playerController>();
	}

	void OnTriggerEnter2D(Collider2D coll){

		player.grounded = true;
	}

	void OnTriggerExit2D(Collider2D coll){

		player.grounded = false;
	}

	void OnTriggerStay2D(Collider2D coll)
	{

		player.grounded = true;
	}

}
