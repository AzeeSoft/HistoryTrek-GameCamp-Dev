using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public GameObject[] LivesImages;
	public GameObject[] CollectiblesImages;
	public GameObject CollectibleHeld;
	public string[] CollectibleID;
	public bool[] CollectibleStatus;

	public playerManager PM;

	public Sprite[] enabledCollectibleSprite;
	public Sprite[] disabledCollectibleSprite;


	public Sprite enabledHealthSprite;
	public Sprite disabledHealthSprite;

	public GameObject DeathScreen;
	public GameObject WinScreen;


	// Use this for initialization
	void Start () 
	{
		Instance = this;

		DeathScreen.SetActive (false);
		WinScreen.SetActive (false);
		PM.Lives = 3;


		UpdateCollectiblesImages ();

		//Just for testing
		//=============================
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Just for testing
		UpdateLifeImages ();
		UpdateCollectiblesImages ();

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			ItemDropped ();
		}
		//=============================


		CheckLife ();
		CheckCollectibles ();

		if (Input.GetKeyDown("escape"))
		{
			QuitGame();
		}
				
	}

	void CheckLife ()
	{
		
		if (PM.Lives == 0) 
		{
			DeathScreen.SetActive (true);
		}

		if (PM.Lives != 0) 
		{
			DeathScreen.SetActive (false);
		}
			
	}

	void CheckCollectibles()
	{
		for (int i = 0; i < CollectiblesImages.Length; i++) {
			if (CollectibleStatus [i]) {
				WinScreen.SetActive (true);
			}

			if (!CollectibleStatus [i]) {
				WinScreen.SetActive (false);
			}

		}
	}

	public void UpdateLifeImages()
	{
		for (int i = 0; i < LivesImages.Length; i++) {
			LivesImages [i].GetComponent<Image> ().sprite = disabledHealthSprite;

		}
		for (int j = 0; j < PM.Lives; j++) {
			LivesImages [j].GetComponent<Image> ().sprite = enabledHealthSprite;
		}
	}

	public void UpdateCollectiblesImages()
	{
		for (int i = 0; i < CollectiblesImages.Length; i++) {
			

			if (CollectibleStatus [i]) {
				CollectiblesImages [i].GetComponent<Image> ().sprite = enabledCollectibleSprite[i];
			} else {
				CollectiblesImages [i].GetComponent<Image> ().sprite = disabledCollectibleSprite[i];
			}
		}

	}

	public void ItemCollected(string ItemName)
	{
		for (int i = 0; i<CollectiblesImages.Length; i++){
			if (CollectibleID [i].Equals (ItemName)) {
				CollectibleStatus [i] = true;
			}
		}
		UpdateCollectiblesImages ();
	}

	public void ItemHeld(string ItemName)
	{
		CollectibleHeld.SetActive (true);

		for (int i = 0; i<CollectiblesImages.Length; i++){
			if (CollectibleID[i].Equals(ItemName)) {
				CollectibleHeld.GetComponent<Image> ().sprite = enabledCollectibleSprite [i];
			}
		}
	}
	public void ItemDropped()
	{
		CollectibleHeld.SetActive (false);
	}

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
	

}