using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public PlayerHealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Health"))
        {
            Healing(20);
        } 
        Destroy(other.gameObject);
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
