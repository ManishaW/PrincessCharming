using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemStop : MonoBehaviour {

	public GameObject gemPanel;

	// Use this for initialization
	void Start () {
	}



	void OnTriggerEnter2D(Collider2D coll){

		gemPanel.SetActive(true);
		Destroy (gemPanel, 2);
	}
}
