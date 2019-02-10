using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;             //this is the speed our player will move
    private Rigidbody2D rb;         //variable to store Rigidbody2D component
    private float moveInput;        //this store the input value

    public float jumpForce;         //force with which player jump
    private bool isGrounded;        //this variable will tell if our player is grounded or not
    public Transform feetPos;       //this variable will store reference to transform from where we will create a circle
    public float circleRadius;      //radius of circle
    public LayerMask whatIsGround;  //layer our ground will have.

    public float jumpTime;          //time till which we will apply jump force
    private float jumpTimeCounter;  //time to count how long player has pressed jump key
    private bool isJumping;         //bool to tell if player is jumping or not
    Animator anim;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //get reference to 	Rigidbody2D component
        anim = GetComponent<Animator>();
    }

    //private void FixedUpdate()
    //{

    //}


    private void Update()
    {


        anim.SetInteger("condition", 0);
        //the moveInput will be 1 when we press right key and -1 for left key
        moveInput = Input.GetAxis("Horizontal");
        if (moveInput > 0)//moving towards right side
        {
            anim.SetInteger("condition", 1);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveInput < 0)//moving towards left side
        {
            anim.SetInteger("condition", 1);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        
            
        

        //here we set our player x velocity and y will not ne 
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //here we set the isGrounded
        isGrounded = Physics2D.OverlapCircle(feetPos.position, circleRadius, whatIsGround);
        //we check if isGrounded is true and we pressed Space button
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;                       //we set isJumping to true
            jumpTimeCounter = jumpTime;                 //set jumpTimeCounter
            rb.velocity = Vector2.up * jumpForce;       //add velocity to player
        }

        if (isGrounded == false)
        {
            anim.SetInteger("condition", 2);
        }
       
 

        //if Space key is pressed and isJumping is true
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            
            if (jumpTimeCounter > 0)                    //we check if jumpTimeCounter is more than 0
            {
                rb.velocity = Vector2.up * jumpForce;   //add velocity
                jumpTimeCounter -= Time.deltaTime;      //reduce jumpTimeCounter by Time.deltaTime
            }
            else                                        //if jumpTimeCounter is less than 0
            {
                isJumping = false;                      //set isJumping to false
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))              //if we unpress the Space key
        {
            isJumping = false;                          //set isJumping to false
        }



        //down key for crouch
        if (Input.GetKeyDown(KeyCode.DownArrow) && isGrounded == true)
        {
            anim.SetInteger("condition", 3); 
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetInteger("condition", 0);
        }


    }


}
