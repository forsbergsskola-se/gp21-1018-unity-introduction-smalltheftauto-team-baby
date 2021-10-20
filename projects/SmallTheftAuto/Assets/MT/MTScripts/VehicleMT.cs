using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleMT : MonoBehaviour
{
    public GameObject player;
    public CarMovementMT carMovement;
    public GameObject car;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if ( player.activeInHierarchy)
            {
                EnterCar();
            }
            else
            {
                LeaveCar();
            }
            
        }
    }

    private void EnterCar()
    {
        player.SetActive(false);
        carMovement.enabled = true;
    }

    private void LeaveCar()
    {
        player.transform.position = transform.position;
        player.SetActive(true);
        carMovement.enabled = true;
    }
}
