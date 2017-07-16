using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyStop : MonoBehaviour {

	public GameObject keyPanel;

	// Use this for initialization
	void Start () {
	}

	public void onClose() {

		keyPanel.SetActive (false);
		Destroy (this.gameObject);
		Time.timeScale = 1;
	}

	void OnTriggerEnter2D(Collider2D coll){

		keyPanel.SetActive(true);
		Time.timeScale = 0.0f;
	}
}
