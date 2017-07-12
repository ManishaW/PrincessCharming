using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void level1OnClick(){
		Application.LoadLevel ("Level3");
	}
	public void backToMainMenuOnClick(){
		SceneManager.LoadScene("MainMenu");
	}

}
