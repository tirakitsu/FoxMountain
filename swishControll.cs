using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swishControll : MonoBehaviour {
    public float speed;

    public MovePlayer player;
    private Animator anim;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();

        player = FindObjectOfType<MovePlayer>();

        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
        }
    }
    
}
