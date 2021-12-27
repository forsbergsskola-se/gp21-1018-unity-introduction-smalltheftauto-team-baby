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
    // TODO: You seem to have a lot of duplicate code between `CarHealthAndDmg` and `SetFire` this should be doable with only one class for the damage handling and one for just the burning.
    private void OnCollisionEnter2D(Collision2D other)
    {
        // TODO: Make sure that all your houses have this Tag.
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

        //Pick one Take Damage methode picus you have to Takedamage methodes in sepretscript.
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
