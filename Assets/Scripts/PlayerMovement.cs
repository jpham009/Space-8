using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

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
    private bool doubleJumped;      //tells if player has doublejumped or not 

    
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //get reference to 	Rigidbody2D component
        anim = GetComponent<Animator>();
        doubleJumped = false;
    }

    // Updates once per frame
    private void Update()
    {


        anim.SetInteger("condition", 0);
        //the moveInput will be 1 when we press right key and -1 for left key
        moveInput = CrossPlatformInputManager.GetAxis("Horizontal");
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

        //Keeps Spaceman from falling infinitely
        //Viewport coordinates start at (0,0) in the lower left of the screen and go to (1,1) in the upper right.
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        //pos.y = Mathf.Clamp(pos.y,0.2f,1); I commentted this out because the character needs to fall below camera view. 
        transform.position = Camera.main.ViewportToWorldPoint(pos);


        //here we set our player x velocity and y will not ne 
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //here we set the isGrounded
        isGrounded = Physics2D.OverlapCircle(feetPos.position, circleRadius, whatIsGround);

        if (isGrounded == false)
        {
            anim.SetInteger("condition", 2);
        }
        if (isGrounded == true)
        {
            doubleJumped = false;
        }

        
        // User input for Jump and Double Jump 
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            if (isGrounded == true)
            {
                isJumping = true;                       //we set isJumping to true
                jumpTimeCounter = jumpTime;                 //set jumpTimeCounter
                rb.velocity = Vector2.up * jumpForce;       //add velocity to player
            }
            else if (isGrounded == false && doubleJumped == false)
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;                 
                rb.velocity = Vector2.up * jumpForce;       
                doubleJumped = true;                   // double jump 
            }
        }

        //if Space key is pressed and isJumping is true
        if (CrossPlatformInputManager.GetButton("Jump")) // || CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            if (isJumping == false)
            {
                rb.drag = 8;  // Gravity jump (drag when falling) 
            }
            
            if (isJumping == true)
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
        }

        if (CrossPlatformInputManager.GetButtonUp("Jump")) //|| CrossPlatformInputManager.GetButtonDown("Jump"))              //if we unpress the Space key
        {
            rb.drag = 0;                                // back to normal gravity
            isJumping = false;                          //set isJumping to false
        }



        //down key for crouch
        //if (Input.GetKeyDown(KeyCode.DownArrow) && isGrounded == true)
        //{
        //    anim.SetInteger("condition", 3); 
        //}
        //if (Input.GetKeyUp(KeyCode.DownArrow))
        //{
        //    anim.SetInteger("condition", 0);
        //}

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        Destroy(rb);
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.CompareTag("Bound") == true)
        //{
        Debug.Log("exit");
        Destroy(rb);
        //}
    }

    // used for sticking player to moving platform
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }

    // unsticking player from platform after jumping off
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }
}
