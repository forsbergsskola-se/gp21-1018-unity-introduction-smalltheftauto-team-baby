using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CarHealthSO : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarSO healthBar;
    public ParticleSystem setFire;

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.gameObject.CompareTag("House"))
        {
            TakeDamage(20);
            Debug.Log("house hit works");
        }
        
        if (other.collider.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(20);
            Debug.Log("gun dmg works");
        }

    }
 

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void Update()
    {
       
        if (currentHealth <= 20)
        {
            if (!setFire.isPlaying)
            {
                setFire.Play();
            }
            {
                
            }
            
            Debug.Log("There is Fire");
        }

    }

    void CreatFire()
    {
        setFire.Play();
        
    }
    
}
