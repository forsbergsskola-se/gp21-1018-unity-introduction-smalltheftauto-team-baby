using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarHealthAndDmg : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Animator animator;

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

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    private void CarDeath() { //Please make this run when car dies
        Quester quester = gameObject.FindObjectsOfType<Quester>()[0];
        if (!(quester.quest == null)){
            quester.quest.carDead = true;
        }
        animator.SetBool("Explode", true);        
    }

    void CreatFire()
    {
        setFire.Play(); 
        
        
    }
}