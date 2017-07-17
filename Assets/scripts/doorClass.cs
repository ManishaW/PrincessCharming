using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorClass : MonoBehaviour {

	private playerController player;
	public GameObject levelPassedCanvas;

	void Start() {
		GameObject playerObj = GameObject.FindGameObjectWithTag("Player"); 
		player = (playerController)playerObj.GetComponent (typeof(playerController));
	}

	void OnTriggerEnter2D(Collider2D coll){
		//Debug.Log (Application.loadedLevelName);
		if (player.getKey ()) {
			//Door animation?
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			levelPassedCanvas.SetActive (true);
			Time.timeScale = 0.0f;

			if (SceneManager.GetActiveScene ().buildIndex == 4) {
				LevelSelectScript.level4Complete = true;

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
	}