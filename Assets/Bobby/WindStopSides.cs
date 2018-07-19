using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindStopSides : MonoBehaviour {

	public bool one;
	public bool two;
	bool over1;
	bool over2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.tag == "WindPipe") {

			if (one == true) {
				GetComponentInParent<WindStop> ().over1 = true;
				GetComponentInParent<WindStop> ().DetectedWindPipe1 = col.gameObject;
				over1 = true;

		
			}

			if (two == true) {
				GetComponentInParent<WindStop> ().over2 = true;
				GetComponentInParent<WindStop> ().DetectedWindPipe2 = col.gameObject;
				over2 = true;

			}
		}
	}

    void OnTriggerExit2D(Collider2D col){
		if (col.tag == "WindPipe") {
			if (one == true) {
				GetComponentInParent<WindStop> ().over1 = false;

				over1 = false;

			}

			if (two == true) {
				GetComponentInParent<WindStop> ().over2 = false;
				over2 = false;

			}
		}

	
	
	}
}
