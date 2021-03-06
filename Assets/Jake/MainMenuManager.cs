﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public GameObject CreditsImage;
	public Image Credits;
	public GameObject BackImage;

    public string SceneToStart;

	// Use this for initialization
	void Start ()
	{
	    Time.timeScale = 1;
		CreditsImage.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame()
	{
	    SceneManager.LoadScene(SceneToStart);
    }

	public void QuitGame() {
		Application.Quit ();
	}

	public void ShowCredits() {
		CreditsImage.SetActive (true);
		BackImage.SetActive (true);

	}
	public void GoBack()
	{
		if (CreditsImage) {
			CreditsImage.SetActive (false);
		}

	}

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
