using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			rb.velocity = new Vector2 (-speed, rb.velocity.y);
		} else if (Input.GetKey (KeyCode.D)) {
			rb.velocity = new Vector2 (speed, rb.velocity.y);
		} else {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			rb.velocity = new Vector2 (rb.velocity.x, 5);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Lightning") {
			Debug.Log ("Lost A Life");
		}
	}
}
