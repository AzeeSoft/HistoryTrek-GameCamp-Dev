using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject[] LivesImages;
	public GameObject[] CollectiblesImages;
	public GameObject CollectibleHeld;
	public string[] CollectibleID;
	public bool[] CollectibleStatus;

	public int lives;

	public Sprite[] enabledCollectibleSprite;
	public Sprite[] disabledCollectibleSprite;


	public Sprite enabledHealthSprite;
	public Sprite disabledHealthSprite;

	public GameObject DeathScreen;
	public GameObject WinScreen;


	// Use this for initialization
	void Start () 
	{
		DeathScreen.SetActive (false);
		WinScreen.SetActive (false);
		lives = 3;


		UpdateCollectiblesImages ();

		//Just for testingk
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
				
	}

	void CheckLife ()
	{
		
		if (lives == 0) 
		{
			DeathScreen.SetActive (true);
		}

		if (lives != 0) 
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
		for (int j = 0; j < lives; j++) {
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
		
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

}
