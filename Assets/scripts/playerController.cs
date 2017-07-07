using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float speed = 1; // speed in meters per second

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		Vector3 moveDirection = Vector3.zero;
		moveDirection.x = Input.GetAxis ("Horizontal"); 
		moveDirection.z = Input.GetAxis ("Vertical"); 
		// move this object at frame rate independent speed:
		transform.position += moveDirection * speed * Time.deltaTime;
	}
}
