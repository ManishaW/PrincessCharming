using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour {

	public GameObject settingsPanel;
	public GameObject helpPanel;
	public float currVol;
	public Slider volSlider;

	public void onPlay(){
		SceneManager.LoadScene (1);
	}

	public void onSettings() {
		settingsPanel.SetActive (true);
	}

	public void onCloseSettings() {
		settingsPanel.SetActive (false);
	}

	public void onHelp() {
		helpPanel.SetActive (true);
	}

	public void onCloseHelp() {
		helpPanel.SetActive (false);
	}

	public void updated(){
		GameObject music = GameObject.FindGameObjectWithTag("gameMusic"); 
		bgmVolume bVol = (bgmVolume)music.GetComponent (typeof(bgmVolume));
		currVol = volSlider.value;
		bVol.SetVolume (currVol);
	}

}
