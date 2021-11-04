using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSO : MonoBehaviour
{
  public int maxHealth = 100;
  public int currentHealth;

  public HealthBarSO healthBar;
  
  
  private void Start()
  {
    currentHealth = maxHealth;
    healthBar.SetMaxHealth(maxHealth);
  }


  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.E))
    {
      TakeDamage(20);
    }
    
    if (Input.GetKeyDown(KeyCode.T))
    {
      Healing(20);
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

 public void Healing(int healAmount)
  {
    currentHealth += healAmount;
    healthBar.SetHealth(currentHealth);

  }
  
}
