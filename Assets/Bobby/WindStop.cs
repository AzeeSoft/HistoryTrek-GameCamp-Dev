using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindStop : MonoBehaviour {

	public bool over1;
    public bool over2;
	
	//WindStopSides stop;

	public GameObject DetectedWindPipe1;
	public GameObject DetectedWindPipe2;


	// Use this for initialization
	void Start () {
		//stop = GetComponent<WindStopSides> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Give WindTrigger a Variable to remember if its off or not

		if (over1 == true && over2 == true && DetectedWindPipe1 == DetectedWindPipe2 && DetectedWindPipe1 != null) {
			DetectedWindPipe1.GetComponent<BoxCollider2D> ().enabled = false;
		} 
		else {
		    if (DetectedWindPipe1 != null)
		    {
		        DetectedWindPipe1.GetComponent<BoxCollider2D>().enabled = true;
		    }

		    if (DetectedWindPipe2 != null)
		    {
		        DetectedWindPipe2.GetComponent<BoxCollider2D>().enabled = true;
		    }

		}
	}
}
