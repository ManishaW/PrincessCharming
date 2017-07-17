using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class doorClass : MonoBehaviour {

	private playerController player;
	public GameObject levelPassedCanvas;

	void Start() {
		GameObject playerObj = GameObject.FindGameObjectWithTag("Player"); 
		player = (playerController)playerObj.GetComponent (typeof(playerController));
	}

	void OnTriggerEnter2D(Collider2D coll){
		//Debug.Log (Application.loadedLevelName);
		if (player.getKey()) {
			//Door animation?
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			levelPassedCanvas.SetActive(true);

			//show scores
			Text gems = GameObject.FindWithTag("gemScore").GetComponent<Text>();
			string gemCounting = GameObject.FindWithTag("gemCount").GetComponent<Text>().text;
			gems.text = gemCounting;
			Text eggs = GameObject.FindWithTag("eggScore").GetComponent<Text>();
			string eggCounting = GameObject.FindWithTag("eggCount").GetComponent<Text>().text;
			eggs.text = eggCounting;
			Text timer = GameObject.FindWithTag("timeScore").GetComponent<Text>();
			string timeCounting = GameObject.FindWithTag("timer").GetComponent<Text>().text;
			timer.text = timeCounting;

			//calculate score
			Text finalScore = GameObject.FindWithTag("totalScore").GetComponent<Text>();
			finalScore.text = (Int32.Parse (gems.text) + Int32.Parse (eggs.text) + Int32.Parse (timer.text)).ToString();

			Time.timeScale = 0.0f;


			if (Application.loadedLevelName == "Level1") {
				LevelSelectScript.level1Complete = true;
			}
			if (Application.loadedLevelName == "Level3") {
				LevelSelectScript.level3Complete = true;
			}
			if (Application.loadedLevelName == "Game") {
				LevelSelectScript.level2Complete = true;


			}
		}
	}
}
