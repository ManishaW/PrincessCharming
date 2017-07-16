using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStop : MonoBehaviour {

	public GameObject movePanel;

	// Use this for initialization
	void Start () {
	}



	void OnTriggerEnter2D(Collider2D coll){

		movePanel.SetActive(true);
		Destroy (movePanel, 1.3f);
	}
}
