using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxFireController : MonoBehaviour {

    public float speed;

    public MovePlayer player;
    private Animator anim;

    public GameObject EnemyDeathEffect;

    public int damageToGive;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();

        player = FindObjectOfType<MovePlayer>();

        if (player.transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-.1653508f, 0.1584613f, 0.1837232f);
            speed = -speed;
        }

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(EnemyDeathEffect, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Boss")
        {
            var player = GetComponent<oniHealth>();

            other.gameObject.GetComponent<oniHealth>().HurtBoss(damageToGive);

        }
        Destroy (gameObject);
    }
}
