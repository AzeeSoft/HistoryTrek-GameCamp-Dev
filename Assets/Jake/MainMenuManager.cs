using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public GameObject CreditsImage;
	public Image Credits;
	public GameObject BackImage;

	// Use this for initialization
	void Start () {
		CreditsImage.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame() {
		
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
