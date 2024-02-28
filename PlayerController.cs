using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal;
    public float speed = 5f;
    public float jumpingPower = 5f;
    public Rigidbody2D rb;
    public bool isFacingRight;

    public bool isGrounded;
    public LayerMask groundMask;

    public Animator playerAnimator; //

    

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>(); // 
    }

    public void Update()
    {
        if(GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            CharacterMovement();
            Flip();

        }


    }

    private void CharacterMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
       
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && rb.velocity.x != 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.8f);
        }


        //
        if (horizontal > 0f)
        {
            playerAnimator.SetBool("isIdle", false);
            playerAnimator.SetBool("isRunning", true);

            if (isGrounded == false && horizontal > 0f)
            {
                playerAnimator.SetBool("isIdle", false);
                playerAnimator.SetBool("isRunning", false);
                playerAnimator.SetBool("isJumping", true);
            }

            else
            {
                playerAnimator.SetBool("isJumping", false);
                playerAnimator.SetBool("isRunning", true);
            }
        }
        if (horizontal == 0f && isGrounded == true)
        {
            playerAnimator.SetBool("isIdle", true);
            playerAnimator.SetBool("isRunning", false);
            playerAnimator.SetBool("isJumping", false);

        }
        else if (horizontal == 0f && isGrounded == false)
        {
            playerAnimator.SetBool("isIdle", false);
            playerAnimator.SetBool("isRunning", false);
            playerAnimator.SetBool("isJumping", true);

        }
        if (horizontal < 0f)
        {
            playerAnimator.SetBool("isIdle", false);
            playerAnimator.SetBool("isRunning", true);

            if (isGrounded == false && horizontal < 0f)
            {
                playerAnimator.SetBool("isIdle", false);
                playerAnimator.SetBool("isRunning", false);
                playerAnimator.SetBool("isJumping", true);
            }
            else
            {
                playerAnimator.SetBool("isJumping", false);
                playerAnimator.SetBool("isRunning", true);
            }
        }
        //
        



    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }


}
