using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicSettings : MonoBehaviour {

	float vol=0.2f;

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}


	public void SetMusicVolume(float value){
		vol = value;
	}

	public float  GetMusicVolume(){
		return vol;
	}
}
