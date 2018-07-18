using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindPush : MonoBehaviour {

	public Rigidbody2D rb;
	public float WindSpeed;
	public float DecreaseSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "WindPipe") {
			rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y + WindSpeed);
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "WindPipe") {
			rb.velocity = new Vector2 (rb.velocity.x, rb.velocity.y - DecreaseSpeed);
		}
	}
}
