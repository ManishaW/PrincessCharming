using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectScript : MonoBehaviour {
	public static bool level1Complete;
	public static bool level2Complete;
	public static bool level3Complete;
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
		if (level1Complete){
			Destroy(lock2);
			level2.interactable = true;
		}
		if (level2Complete){
			Destroy(lock3);
			level3.interactable = true;
		}
		if (level3Complete){
			Destroy(lock3);
			level4.interactable = true;
		}
	}
	public void level1OnClick(){
		SceneManager.LoadScene (2);
	}
	public void tutorial(){
		SceneManager.LoadScene (5);
	}
	public void level2OnClick(){
		SceneManager.LoadScene (3);
	}
	public void level3OnClick(){
		SceneManager.LoadScene (4);
	}
	public void backToMainMenuOnClick(){
		SceneManager.LoadScene(0);


}

}
