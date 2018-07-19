using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	Rigidbody2D rb2d;
	public float speed;
	public float Jump;
	public GameObject groundcheckleft;
	public GameObject groundcheckright;
	private SpriteRenderer spriteRenderer;
	public Animator animator;
	public float groundCheckTolerance;



	bool iswalking = false;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


		float Horizontal = Input.GetAxis ("Horizontal");

		iswalking = Horizontal != 0;
		animator.SetBool ("idle", !iswalking);
		animator.SetBool ("walk", iswalking);

		rb2d.velocity = new Vector2(Horizontal * speed, rb2d.velocity.y);


		RaycastHit2D hitInfo1 = Physics2D.Raycast (groundcheckleft.transform.position, Vector2.down, groundCheckTolerance, LayerMask.GetMask("Ground"));
		RaycastHit2D hitInfo2 = Physics2D.Raycast (groundcheckright.transform.position, Vector2.down, groundCheckTolerance, LayerMask.GetMask("Ground"));
		if (hitInfo1.collider != null || hitInfo2.collider != null) {
			animator.SetBool ("grounded", true);

			if (Input.GetButtonDown ("Jump")) {
				rb2d.AddForce (Vector2.up * Jump); 
			}
		
		} else {
			animator.SetBool ("grounded", false);
		}



		bool flipSprite = (spriteRenderer.flipX ? (Horizontal > 0f) : (Horizontal < 0f));
		if (flipSprite) 
		{
			spriteRenderer.flipX = !spriteRenderer.flipX;

		}

		//animator.SetBool ("Ground", Ground)

	}
}
