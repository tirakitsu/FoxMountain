using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oniHealth : MonoBehaviour {

    public int bossMaxHealth;
    public int bossCurrentHealth;
    
    public GameObject BossDeathEffect;

    public GameObject winnerPanel;
    public bool win = false;

    private void Start()
    {
        bossCurrentHealth = bossMaxHealth;

    }
    private void Awake()
    {
        winnerPanel.SetActive(false);
    }
    private void Update()
    {
        if (bossCurrentHealth <= 0)
        {

            Destroy(gameObject);
            Instantiate(BossDeathEffect, transform.position, transform.rotation);
            winnerPanel.SetActive(true);
            win = true;
        }

    }
    public void HurtBoss(int damageToGive)
    {
        bossCurrentHealth -= damageToGive;
    }


    public void SetMaxHealth()
    {
        bossCurrentHealth = bossMaxHealth;
    }

}

