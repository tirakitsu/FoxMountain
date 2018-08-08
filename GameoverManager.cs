using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverManager : MonoBehaviour {

    public kitsuHealth playerHealth;       // Reference to the player's health.
          

                     
                     

    public GameObject losePanel;
    public bool lose = false;


   
    private void Awake()
    {
        losePanel.SetActive(false);
    }

    void Update()
    {
       
        // If the player has run out of health...
        if (playerHealth.playerCurrentHealth <= 0)
        {

            losePanel.SetActive(true);
            lose = true;

        }
    }
}

