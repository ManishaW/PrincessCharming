using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicSettings : MonoBehaviour {

	float vol=0.2f;
	private static musicSettings instance = null;

	public static musicSettings Instance(){
		return instance;
	}

	void Awake(){
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}


	public void SetMusicVolume(float value){
		vol = value;
	}

	public float  GetMusicVolume(){
		return vol;
	}
}
