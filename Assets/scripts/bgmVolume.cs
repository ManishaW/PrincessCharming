using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmVolume : MonoBehaviour {

	AudioSource audio;
	private static bgmVolume instance = null;

	public static bgmVolume Instance(){
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
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		DontDestroyOnLoad (gameObject);
	}
	
	public void SetVolume(float value){
		audio.volume = value;
	}
		
}
