using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {

	public GameObject failedCanvas;

	// Use this for initialization
	void Start () {
	}
	
	void OnTriggerEnter2D(Collider2D coll){

			failedCanvas.SetActive(true);
			Time.timeScale = 0.0f;
	}
}
