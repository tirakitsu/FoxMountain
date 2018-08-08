using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    public int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<MovePlayer>() == null)
            return;
        ScoreManager.AddPoints(pointsToAdd);

        Destroy (gameObject);

    }

}
