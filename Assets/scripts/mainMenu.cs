using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour {

	public GameObject settingsPanel;
	public GameObject helpPanel;

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
	

}
