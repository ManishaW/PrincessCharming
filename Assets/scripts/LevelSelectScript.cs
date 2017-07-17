using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour {
	public static bool level2Complete;
	public static bool level3Complete;
	public static bool level4Complete;
	private GameObject lock2;
	public Button level2;
	private GameObject lock3;
	public Button level3;
	private GameObject lock4;
	public Button level4;

	// Use this for initialization
	void Start () {
		lock2 = GameObject.Find ("lock2");
		level2 = GameObject.Find ("level2_btn").GetComponent<Button>();
		lock3 = GameObject.Find ("lock3");
		level3 = GameObject.Find ("level3_btn").GetComponent<Button>();
		lock4 = GameObject.Find ("lock4");
		level4 = GameObject.Find ("level4_btn").GetComponent<Button>();
	}

	// Update is called once per frame
	void Update () {
		if (level2Complete){
			Destroy(lock2);
			level2.interactable = true;
		}
		if (level3Complete){
			Destroy(lock3);
			level3.interactable = true;
		}
		if (level4Complete){
			Destroy(lock3);
			level4.interactable = true;
		}
	}
	public void level1OnClick(){
		Application.LoadLevel ("Level1");
	}
	public void tutorial(){
		Application.LoadLevel ("Tutorial");
	}
	public void level2OnClick(){
		Application.LoadLevel ("Game");
	}
	public void level3OnClick(){
		Application.LoadLevel ("Level3");
	}
	public void backToMainMenuOnClick(){
		SceneManager.LoadScene("MainMenu");


}

}
