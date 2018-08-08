using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kitsuHealth : MonoBehaviour {


    public int playerMaxHealth;
    public int playerCurrentHealth;
    public GameObject Heart1, Heart2, Heart3, Heart4, Heart5;

    public GameObject PlayerDeathEffect;

    public GameObject losePanel;
    public bool lose = false;


   

    private void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        Heart4.gameObject.SetActive(true);
        Heart5.gameObject.SetActive(true);

    }

  
    private void Update()
    {

        if(playerCurrentHealth <= 0)
        {
            
            gameObject.SetActive(false);

            losePanel.SetActive(true);
            lose = true;
        }
       


        switch (playerCurrentHealth)
        {
            case 5:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                Heart4.gameObject.SetActive(true);
                Heart5.gameObject.SetActive(true);
                break;

            case 4:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                Heart4.gameObject.SetActive(true);
                Heart5.gameObject.SetActive(false);
                break;

            case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                Heart4.gameObject.SetActive(false);
                Heart5.gameObject.SetActive(false);
                break;

            case 2:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(false);
                Heart4.gameObject.SetActive(false);
                Heart5.gameObject.SetActive(false);
                break;

            case 1:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                Heart4.gameObject.SetActive(false);
                Heart5.gameObject.SetActive(false);
                break;

            case 0:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                Heart4.gameObject.SetActive(false);
                Heart5.gameObject.SetActive(false);
                Instantiate(PlayerDeathEffect, transform.position, transform.rotation);
                break;

        }
    }
    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void HealPlayer(int healing)
    {
        playerCurrentHealth += healing;   }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }

}
    
