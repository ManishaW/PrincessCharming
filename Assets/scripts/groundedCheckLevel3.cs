using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class groundedCheckLevel3 : MonoBehaviour {

	private playerLevel3 player;

	void Start() {
		player = gameObject.GetComponentInParent<playerLevel3>();
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
