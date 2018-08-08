using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtKitsu : MonoBehaviour {

    public int damageToGive;

    private void Start()
    {
        
    }
    // Use this for initialization
     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Kitsu")
        {
            var player = GetComponent<MovePlayer>();

            other.gameObject.GetComponent<kitsuHealth>().HurtPlayer(damageToGive);
        
            player.knockbackCount = player.knockbackLength;

            if (other.transform.position.x < transform.position.x)
            {
                player.knockFromRight = true;
            }

            else

                player.knockFromRight = false;
        }
      }


}

