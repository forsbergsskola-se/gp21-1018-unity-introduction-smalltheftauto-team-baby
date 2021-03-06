using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMoveSO : MonoBehaviour
{
    public List<string> inventory;


    private void Start()
    {
        inventory = new List<string>();
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 8f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 8f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -160*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        if (Input.GetKey(KeyCode.D))
            
        {
            transform.Rotate(0f, 0f, -160*Time.deltaTime*Input.GetAxis("Horizontal"));
        } 
        
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectable"))
        {
            string itemType = collision.gameObject.GetComponent<CollectItemsSO>().itemType;
            print("You picked up a:" + itemType);
            
            inventory.Add(itemType);
            Destroy(collision.gameObject);
            
            
        }
    }
}
