using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;
    Animator anim;
    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700;
    public Transform firePoint;
    public GameObject FoxFire;

    public GameObject Swish;
    public Transform swishPoint;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

    private bool attacking;
    public float attackTime;
    private float attackTimeCounter;
    public float destroyTimer;

    void Start () {
        anim = GetComponent<Animator>();
        

	}
	


	// Update is called once per frame
	void FixedUpdate () {


        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        anim.SetBool("Ground", grounded);

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);


            float move = Input.GetAxis("Horizontal");
       
        anim.SetFloat("Speed", Mathf.Abs(move));

        if (!attacking)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (move < 0 && !facingRight)
            Flip();
        else if (move > 0 && facingRight)
            Flip();

        }

    void Update()
    {

        

      if(grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
      if(Input.GetMouseButtonDown(1))
        {
            attackTimeCounter = attackTime;
            attacking = true;
            Instantiate(FoxFire,firePoint.position,firePoint.rotation);
            anim.SetBool("shoot", true);
        }

      if(Input.GetMouseButtonDown(0))
        {
            attackTimeCounter = attackTime;
            destroyTimer = attackTimeCounter;
            attacking = true;
            Instantiate(Swish, swishPoint.position, swishPoint.rotation);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            anim.SetBool("Attack",true);
        }
      if(attackTimeCounter > 0)
        {
            attackTimeCounter -= Time.deltaTime;
        }
        if (attackTimeCounter < 0)
        {
            attacking = false;
            anim.SetBool("Attack", false);
            anim.SetBool("shoot", false);
        }
        
    }
    void Flip()
    {
        if (knockbackCount <= 0)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        else
        {
            if (knockFromRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);

            if (!knockFromRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);

            knockbackCount -= Time.deltaTime;
        }
    }
}