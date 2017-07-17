using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class death : MonoBehaviour {

	public GameObject failedCanvas;


	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D(Collider2D coll){

			failedCanvas.SetActive(true);
			GameObject.FindWithTag("ouch").GetComponent<Text>().text="Ouch that hurt!";
		GameObject.FindWithTag ("time").GetComponent <Image> ().enabled = false;
			Time.timeScale = 0.0f;
	}



}
