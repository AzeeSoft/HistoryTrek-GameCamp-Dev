using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindRay : MonoBehaviour {
	public float floatHeight;
//	public float 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D hit = Physics2D.Raycast (transform.position, -Vector2.up);
	    if (hit.collider != null)
	    {
	        float distance = Mathf.Abs(hit.point.y - transform.position.y);
//	        float heightError = floatHeigt - distance; 
	    }
	}
}
