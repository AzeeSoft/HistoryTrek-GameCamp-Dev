using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public static spawn CurrentSpawnZone;

	public GameObject SP;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
	
	
		if (other.CompareTag ("player")) {
		
			CurrentSpawnZone = this;
				
		}

	}

	static void Respawn(){



	}
}
