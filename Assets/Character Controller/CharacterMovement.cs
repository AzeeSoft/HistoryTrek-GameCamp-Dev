using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TouchScript;
using TouchScript.Pointers;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharacterMovement : MonoBehaviour
{
    class PlayerInput
    {
        public float horizontal;
        public bool jump;
    }

    Rigidbody2D rb2d;
    public float speed;
    public float Jump;
    public GameObject groundcheckleft;
    public GameObject groundcheckright;
    private SpriteRenderer spriteRenderer;
    public Animator animator;
    public float groundCheckTolerance;

    public playerManager PM;

    private PlayerInput playerInput = new PlayerInput();
    bool iswalking = false;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerInput();
        Move();
    }

    void UpdatePlayerInput()
    {
        playerInput.horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        playerInput.jump = CrossPlatformInputManager.GetButtonDown("Jump");
    }

    void Move()
    {
        iswalking = Math.Abs(playerInput.horizontal) > 0.01;
        animator.SetBool("idle", !iswalking);
        animator.SetBool("walk", iswalking);

        rb2d.velocity = new Vector2(playerInput.horizontal * speed, rb2d.velocity.y);


        RaycastHit2D hitInfo1 = Physics2D.Raycast(groundcheckleft.transform.position, Vector2.down,
            groundCheckTolerance, LayerMask.GetMask("Ground"));
        RaycastHit2D hitInfo2 = Physics2D.Raycast(groundcheckright.transform.position, Vector2.down,
            groundCheckTolerance, LayerMask.GetMask("Ground"));
        if (hitInfo1.collider != null || hitInfo2.collider != null)
        {
            animator.SetBool("grounded", true);

            if (playerInput.jump)
            {
                rb2d.AddForce(Vector2.up * Jump);
            }
        }
        else
        {
            animator.SetBool("grounded", false);
        }


        bool flipSprite = (spriteRenderer.flipX ? (playerInput.horizontal > 0f) : (playerInput.horizontal < 0f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        //animator.SetBool ("Ground", Ground)
    }
}