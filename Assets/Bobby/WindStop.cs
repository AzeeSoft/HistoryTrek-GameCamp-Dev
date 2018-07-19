using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindStop : MonoBehaviour {

	public bool over1;
    public bool over2;
	
	//WindStopSides stop;

	public GameObject WindPipe;

	// Use this for initialization
	void Start () {
		//stop = GetComponent<WindStopSides> ();
	}
	
	// Update is called once per frame
	void Update () {

		//Give WindTrigger a Variable to remember if its off or not

		if (over1 == true && over2 == true) {


//			Debug.Log ("OFF");
		} 

		if (over1 == false || over2 == false) {
			
//			Debug.Log ("ON");

		}
	}
}
