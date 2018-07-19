using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour {

	public int randomNum;
	public bool Strike;
	public ParticleSystem lightning;

	// Use this for initialization
	void Start () {
		StartCoroutine (LightningStrike ());
	}
	
	// Update is called once per frame
	void Update () {
		if (Strike == true) {
			LightningOn ();
		} else {
			StartCoroutine (LightningStrike ());
		}
	}

	IEnumerator LightningStrike(){
		yield return new WaitForSeconds (5);
		lightning.Play ();
		yield return new WaitForSeconds (1);
		Strike = true;
	}

	void LightningOn(){
		lightning.Stop ();
		Strike = false;
	}
}
