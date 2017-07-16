using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpStop : MonoBehaviour {

	public GameObject jumpPanel;

	// Use this for initialization
	void Start () {
	}



	void OnTriggerEnter2D(Collider2D coll){

		jumpPanel.SetActive(true);
		Destroy (jumpPanel, 2);
	}
}
