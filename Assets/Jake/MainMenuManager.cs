using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {

	public GameObject CreditsImage;
	public Image Credits;

	// Use this for initialization
	void Start () {
		CreditsImage.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame() {
		
	}

	public void QuitGame() {
	
	}

	public void ShowCredits() {
		CreditsImage.SetActive (true); 
	}

}
