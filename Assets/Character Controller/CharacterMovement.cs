using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	Rigidbody2D rb2d;
	public float speed;
	public float Jump;
	public GameObject groundcheck;

	public float groundCheckTolerance;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {


		float Horizontal = Input.GetAxis ("Horizontal");

		rb2d.velocity = new Vector2(Horizontal * speed, rb2d.velocity.y);


		RaycastHit2D hitInfo = Physics2D.Raycast (groundcheck.transform.position, Vector2.down, groundCheckTolerance, LayerMask.GetMask("Ground"));

		if (hitInfo.collider != null) {
			if (Input.GetButtonDown ("Jump"))
			{
				rb2d.AddForce (Vector2.up * Jump); 

			}
		}

		//transform.localScale.x = speed;
	}
}
