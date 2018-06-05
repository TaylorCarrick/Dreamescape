using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed = 10;            
    private bool facingRight = false;
    public float playerJumpPower = 1250;
    private float moveX;
    public bool grounded;
    public bool candoublejump;
    private Rigidbody2D myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Store the current horizontal input in the float moveHorizontal.
        moveX = Input.GetAxis("Horizontal");

        //jump
        if (Input.GetButtonDown ("Jump") && (grounded))
        {
            myRigidBody.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerSpeed);
            grounded = false;
            candoublejump = true;
            
        }

        //doublejump if able
        else if (Input.GetButtonDown("Jump") && candoublejump && !grounded)
        {
            myRigidBody.velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, playerSpeed);
            candoublejump = false;
        }

        //flip player depending on which side it is going
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }

        //move sideways
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        grounded = true;
        Debug.Log("Player has collided with " + col.collider.name);
    }
}