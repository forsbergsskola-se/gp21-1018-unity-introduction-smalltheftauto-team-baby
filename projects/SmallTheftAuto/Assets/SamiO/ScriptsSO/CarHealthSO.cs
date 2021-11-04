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
        }
        
        Debug.Log("hit works");
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
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
            
        } 
        if (currentHealth <= 20)
        {
            //Instantiate(setFire, transform.position, quaternion.identity);
            CreatFire();
        }

    }

    void CreatFire()
    {
        setFire.Play();
        
    }
    
}
