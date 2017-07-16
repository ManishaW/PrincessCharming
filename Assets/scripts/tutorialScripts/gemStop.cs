using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemStop : MonoBehaviour {

	public GameObject gemPanel;

	// Use this for initialization
	void Start () {
	}

	public void onClose() {

		gemPanel.SetActive (false);
		Destroy (this.gameObject);
		Time.timeScale = 1;
	}

	void OnTriggerEnter2D(Collider2D coll){

		gemPanel.SetActive(true);
		Time.timeScale = 0.0f;
	}
}
