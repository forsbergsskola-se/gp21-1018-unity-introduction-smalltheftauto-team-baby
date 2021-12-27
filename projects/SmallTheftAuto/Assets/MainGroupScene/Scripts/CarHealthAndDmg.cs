using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealthAndDmg : MonoBehaviour
{
    private int maxHealth = 100;
    public int currentHealth;

   // public HealthBarSO healthBar;
    

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
    //    healthBar.SetMaxHealth(maxHealth);
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // TODO: This helped me test the game, but should be removed
            TakeDamage(20);
            
        } 
        if (currentHealth <= 20)
        {
           
            if (currentHealth <= 0)
            {
                CarDeath();
            }
            
            Debug.Log("There is Fire");
        }

    } 
    
    private void CarDeath() { //Please make this run when car dies
        // TODO: This throws a lot of exceptions
        Quester quester = FindObjectsOfType<Quester>()[0];
        if (!(quester.quest == null)){
           quester.quest.carDead = true;
        }
    }

  
}
