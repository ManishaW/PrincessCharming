using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyStop : MonoBehaviour {

	public GameObject keyPanel;

	// Use this for initialization
	void Start () {
	}



	void OnTriggerEnter2D(Collider2D coll){

		keyPanel.SetActive(true);
		Destroy (keyPanel, 1.2f);
	}
}
