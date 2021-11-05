using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<string> inventory;
    public GameObject floatingTextPrefab;
    public int maxHealth = 100;
    public int currentHealth;
    public int money = 0;
    public int score = 0 ;

    public GameObject savePoint;
    public PlayerHealthBar healthBar;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Health"))
        {
            Healing(20);
        } 
        Destroy(collision.gameObject); 
       
        if (collision.CompareTag("Collectable"))
        {
            string itemType = collision.gameObject.GetComponent<CollectItem>().itemType;
            print("You picked up a:" + itemType);
            
            inventory.Add(itemType);
            Destroy(collision.gameObject);
            
            
        }
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
            PlayerDeath();
        }
        
        
    }
    
    

    public void Healing(int healAmount)
    {
        currentHealth += healAmount;
        healthBar.SetHealth(currentHealth);

    }

    private void PlayerDeath(){
        //WASTED UI

        if (floatingTextPrefab != null)
        {
            ShowFloatingText();
        }
        
        money = money / 2;
    }

    void ShowFloatingText()
    {
        Instantiate(floatingTextPrefab, transform.position, Quaternion.identity, transform);
    }

    
    
}
