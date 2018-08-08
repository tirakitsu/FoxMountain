using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainHeath : MonoBehaviour {
    public int healing;

    private void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Kitsu")
        {
            other.gameObject.GetComponent<kitsuHealth>().HealPlayer(healing);

            Destroy(gameObject);
        }
    }

}
