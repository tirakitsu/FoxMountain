using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OniAttack : MonoBehaviour {

    Animator anim;
    public int damageToGive;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            anim.SetBool("attack",true);
            other.gameObject.GetComponent<kitsuHealth>().HurtPlayer(damageToGive);
        }

    }


}

