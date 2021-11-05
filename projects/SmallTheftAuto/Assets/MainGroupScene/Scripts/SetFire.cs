using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFire : MonoBehaviour
{ 
    
    
    
    private int maxHealth = 100;
    public int currentHealth;
    
    public ParticleSystem setFire; 
    private void Start()
    {
        currentHealth = maxHealth;
       
    }
    
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
    
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        
    }
    
    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
            
        } 
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
