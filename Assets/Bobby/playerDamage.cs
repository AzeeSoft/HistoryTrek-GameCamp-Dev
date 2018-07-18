using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour {

	 playerManager Manager;

	// Use this for initialization
	void Start () {

		Manager = GetComponent<playerManager>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp (KeyCode.F)) {
		
			Manager.Lives -= 1;
			Debug.Log (Manager.Lives);
		
		}


	}
	
}
