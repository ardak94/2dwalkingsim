using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public TextMeshProUGUI healthText;
    public float healthAmount = 100f;
    public float maxHealth = 100f;


    private void Start()
    {
        healthText.text = $"{healthAmount} / {maxHealth}";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Heal(5);
        }
        
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / maxHealth;
        healthText.text = $"{healthAmount} / {maxHealth}";
    }

    public void Heal(float healingamount)
    {
        healthAmount += healingamount;
        healthAmount = Mathf.Clamp(healthAmount, 0, maxHealth);
        healthBar.fillAmount = healthAmount / maxHealth;
        healthText.text = $"{healthAmount} / {maxHealth}";
    }

    public void IncMaxHealth(float buffamount)
    {
        maxHealth += buffamount;
        healthAmount += buffamount;
        healthBar.fillAmount = healthAmount / maxHealth;
        healthText.text = $"{healthAmount} / {maxHealth}";
    }





    
    
}