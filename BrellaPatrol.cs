using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrellaPatrol : MonoBehaviour {

    Animator anim;
    public float moveSpeed;
    public bool moveRight;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    private bool hittingWall;
    public Transform wallCheck;
    public float wallRadius;
    public LayerMask whatIsWall;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallRadius, whatIsWall);
        
            anim.SetFloat("Patrol", moveSpeed);
      
        if (hittingWall)
            moveRight = !moveRight;

        if (moveRight)
        {
            transform.localScale = new Vector3(-0.2387356f, 0.2387356f, 0.2387356f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(0.2387356f, 0.2387356f, 0.2387356f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }


    }


}