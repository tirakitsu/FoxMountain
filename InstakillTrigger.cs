using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstakillTrigger : MonoBehaviour
{
    public int damageToGive;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<kitsuHealth>().HurtPlayer(damageToGive);
        }
    }
}
