using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour {

	public int randomNum;
	public bool Strike;
	public GameObject lightning;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Strike = true) {
			LightningOn ();
		}
	}

	IEnumerator LightningStrike(){
		yield return new WaitForSeconds (5);
		Strike = true;
	}

	void LightningOn(){
		lightning.SetActive (true);
		StartCoroutine (LightningStrike ());
		Strike = false;
	}
}
