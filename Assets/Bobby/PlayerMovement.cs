using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	playerManager Manager;
	Rigidbody2D rb2d;
	public bool canJump = true;

	// Use this for initialization
	void Start () {
		Manager = GetComponent<playerManager> ();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		float xVel = 0;
			
		if (Input.GetKey (KeyCode.D)) {
		
			xVel = Manager.speed;
		
		}
		if (Input.GetKey (KeyCode.A)) {

			xVel = -Manager.speed;

		}

		if (canJump == true) {

			if (Input.GetKeyDown (KeyCode.Space)) {
				
				rb2d.velocity = new Vector2 (rb2d.velocity.x, 5);
		
			}
		}

		rb2d.velocity = new Vector2 (xVel, rb2d.velocity.y);
	}

	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Ground") {
			canJump = true;
		}
	
	}

	void OnCollisionExit2D(Collision2D col){
		if (col.gameObject.tag == "Ground") {
			canJump = false;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "KillZone") {
			Manager.Lives -= 1;
			spawn.Respawn ();
		}

	}


}
