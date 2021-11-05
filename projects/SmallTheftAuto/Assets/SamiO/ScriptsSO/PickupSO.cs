using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSO : MonoBehaviour
{
    private InventorySO inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<InventorySO>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
