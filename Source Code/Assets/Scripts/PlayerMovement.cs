using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator animator;

    [Header("移动参数")]
    public float speed = 8f;

    float xVelocity;

    [Header("跳跃参数")]
    public float jumpForce = 20f;

    [Header("状态")]
    public bool isOnGround;
    public bool isJump;
    public bool isheadblock;

    [Header("环境监测")]
    public float feetOffset = 0.45f;
    public float headClearance = 0.2f;
    public float groundDistance = 0.2f;

    public LayerMask groundLayer;

    //按键设置
    bool jumpPressed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }
 
    // Update is called once per frame
    void Update()
    {
        jumpPressed = Input.GetButtonDown("Jump");
    }

    private void FixedUpdate()
    {
        PhysicsCheck();
        GroundMovement();
        FilpDirection();
        MidAirMovement();
    }
    
    void PhysicsCheck()
    {
        RaycastHit2D leftCheck = Raycast(new Vector2(-feetOffset+0.1f,-0.5f),Vector2.down,groundDistance,groundLayer);
        RaycastHit2D rightCheck = Raycast(new Vector2(feetOffset,-0.5f),Vector2.down,groundDistance,groundLayer);
        if(leftCheck || rightCheck)
        {
            isOnGround = true;
        }
        else
        {
            isOnGround = false;
        }
        RaycastHit2D headCheck = Raycast(new Vector2(0f,coll.size.y-0.5f), Vector2.up, headClearance, groundLayer);
        if (headCheck)
        {
            isheadblock = true;
        }
        else
        {
            isheadblock = false;
        }
    }

    void GroundMovement()
    {
        xVelocity = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);
    }

    void FilpDirection()
    {
        if(xVelocity < 0)
        {   
            transform.localScale = new Vector2(-1,1);
            animator.SetTrigger("Walk");
        }
        if (xVelocity > 0)
        {
            transform.localScale = new Vector2(1,1);
            animator.SetTrigger("Walk");
        }

    }

    void MidAirMovement()
    {
        if(jumpPressed && isOnGround && !isJump)
        {
            isOnGround = false;
            isJump = true;
            rb.AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
        }
        else if(isOnGround)
        {
            isJump = false;
        }
    }
    
    RaycastHit2D Raycast(Vector2 offset, Vector2 rayDirection, float length, LayerMask layer)
    {
        Vector2 pos = transform.position;

        RaycastHit2D hit = Physics2D.Raycast(pos + offset, rayDirection, length, layer);
        
        Color color = hit? Color.red : Color.green;
        
        Debug.DrawRay(pos + offset, rayDirection *length, color);
        return hit;
    }
    
}
