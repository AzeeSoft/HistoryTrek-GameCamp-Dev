using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject[] LivesImages;
	public GameObject[] CollectiblesImages;
	public string[] CollectibleID;
	public bool[] CollectibleStatus;

	public int lives;
	public int collectiblesCollected;
	public bool Is_A_collected;
	public bool Is_B_collected;
	public bool Is_C_collected;

	// Use this for initialization
	void Start () 
	{
		lives = 3;
		collectiblesCollected = 0;
		Is_A_collected = false;
		Is_B_collected = false;
		Is_C_collected = false;

		UpdateCollectiblesImages ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		//Just for testing
		UpdateLifeImages ();
		UpdateCollectiblesImages ();
		//=============================


		CheckLife ();
		CheckCollectibles ();
				
	}

	void CheckLife ()
	{
		if (lives == 0) 
		{
			// Show Death Screen
		}
			
	}

	void CheckCollectibles()
	{
		
		if (collectiblesCollected == 3) 
		{
			
		}
	}

	public void UpdateLifeImages()
	{
		for (int i = 0; i < LivesImages.Length; i++) {
			LivesImages [i].SetActive (false);

		}
		for (int j = 0; j < lives; j++) {
			LivesImages [j].SetActive (true);
		}
	}

	public void UpdateCollectiblesImages()
	{
		for (int i = 0; i < CollectiblesImages.Length; i++) {
			CollectiblesImages [i].SetActive (CollectibleStatus[i]);
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
}
