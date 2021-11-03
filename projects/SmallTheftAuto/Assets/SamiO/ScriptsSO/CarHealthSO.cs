using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealthSO : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    public HealthBarSO healthBar;
  
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }


    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
      
        }
    
    }
}
