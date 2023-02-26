using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    private string hack;

    private float dirX = 0f;
    private bool isGrounded = false;
    private bool isOnWall = false;
    private bool jumpPressed = false;

    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private float climbPower;

    public Transform groundCheckCollider;
    public Transform wallCheckCollider;
    public LayerMask groundLayer;
    const float groundCheckRadius = 0.1f;
    const float wallCheckRadius = 0.2f;
    
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        hack = PlayerData.hackType;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerData.hackType == "TimeFreeze")
        {
            PlayerData.isFreeze = !PlayerData.isFreeze;
        }
    }

    
    // Update is called once per frame
    private void FixedUpdate()
    {
        dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * dirX, rb.velocity.y);

        //checks if there is ground within a radius of the groundCheckCollider
        isGrounded = Physics2D.OverlapCircle(groundCheckCollider.position, groundCheckRadius, groundLayer);
        isOnWall = Physics2D.OverlapCircle(wallCheckCollider.position, wallCheckRadius, groundLayer);

        
        
        if (Input.GetButton("Jump"))
        {
            jumpPressed = true;
            if (isGrounded || (hack == "Flying"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            }
            if (isOnWall)
            {
                rb.velocity = new Vector2(rb.velocity.x, climbPower);
            }
        }
        else
        {
            jumpPressed = false;
        }

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (dirX > 0f)
        {
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            sprite.flipX = true;
        }

        if (!isGrounded && !isOnWall)
        {
            anim.SetBool("isJumping", true);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
        if (!isGrounded && isOnWall && jumpPressed)
        {
            anim.SetBool("isClimbing", true);
        }
        else
        {
            anim.SetBool("isClimbing", false);
        }

        if (dirX != 0f && isGrounded)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
