using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inGameMenus : MonoBehaviour {

	public GameObject helpPanel;
	public GameObject failPanel;
	public GameObject passPanel;
	public GameObject pausePanel;

	public void onHelp() {
		Debug.Log ("onHelp!");
		helpPanel.SetActive (true);
	}
	
	public void onCloseHelp() {
			
		Debug.Log ("onCloseHelp!");

		helpPanel.SetActive (false);
	}
	public void onPause() {
		Debug.Log ("onPause!");
		playerController.gamePaused = true;
		pausePanel.SetActive (true);
		Text gems = GameObject.FindWithTag("gemScore").GetComponent<Text>();
		string gemCounting = GameObject.FindWithTag("gemCount").GetComponent<Text>().text;
		gems.text = gemCounting;
		Text eggs = GameObject.FindWithTag("eggScore").GetComponent<Text>();
		string eggCounting = GameObject.FindWithTag("eggCount").GetComponent<Text>().text;
		eggs.text = eggCounting;
		Text timer = GameObject.FindWithTag("timeScore").GetComponent<Text>();
		string timeCounting = GameObject.FindWithTag("timer").GetComponent<Text>().text;
		timer.text = timeCounting;
	}

	public void onRestartPause(){
		Debug.Log ("onRestartPause!");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
		pausePanel.SetActive (false);
		playerController.gamePaused = false;
	}
	public void onContinuePause(){
		Debug.Log ("onContinuePause!");
		pausePanel.SetActive (false);
		playerController.gamePaused = false;
	}
	public void onLevelSelectPause(){
		Debug.Log ("onLevelSelectPause!");
		SceneManager.LoadScene (1);
		pausePanel.SetActive (false);
		Time.timeScale = 1;
	}

	public void onRetryFail(){
		Debug.Log ("onRetryFailed!");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
		failPanel.SetActive (false);
	}
	public void onLevelSelectFail(){
		Debug.Log ("onLevelSelectFailed!");
		SceneManager.LoadScene (1);
		failPanel.SetActive (false);
		Time.timeScale = 1;
	}

	public void onRetryPassed(){
		Debug.Log ("onRetryPassed");
		SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);
		Time.timeScale = 1;
		passPanel.SetActive (false);
	}
	public void onContinuePassed(){
		Debug.Log ("onContinuePassed");
		int nextLevel = SceneManager.GetActiveScene ().buildIndex + 1;

		if (nextLevel <= 4) {
			SceneManager.LoadScene (nextLevel);
			Time.timeScale = 1;
		} else {
			SceneManager.LoadScene (1);
		}
		passPanel.SetActive (false);
	}
	public void onLevelSelectPass(){
		Debug.Log ("onLevelSelectPass!");
		//SceneManager.LoadScene (1);
		Application.LoadLevel("Level Select Menu");
		passPanel.SetActive (false);
		Time.timeScale = 1;
	}


		
}
