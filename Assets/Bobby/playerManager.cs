using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour {

	public int Lives = 3;
	public float speed;
	public GameObject CP;
	static string CpZone;
	public List<GameObject> Checkpoints = new List<GameObject> ();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Lives <= 0) {
		

			Lives = 3;
		
		}
		
	}

	void OnTriggerStay2D(Collider2D other)
	{



	}

	void Respawn(Vector2 NewSpawnPosition){
	
		transform.position = NewSpawnPosition;
	
	}
}
