using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpStop : MonoBehaviour {

	public GameObject jumpPanel;

	// Use this for initialization
	void Start () {
	}

	public void onClose() {

		jumpPanel.SetActive (false);
		Destroy (this.gameObject);
		Time.timeScale = 1;
	}

	void OnTriggerEnter2D(Collider2D coll){

		jumpPanel.SetActive(true);
		Time.timeScale = 0.0f;
	}
}
