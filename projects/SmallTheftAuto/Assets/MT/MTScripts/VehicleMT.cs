using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleMT : MonoBehaviour
{
    public GameObject player;
    public CarMovementMT carMovement;
    

    
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (PlayerIsOutsideCar())
            {
                if (PlayerIsCloseToCar())
                {
                    EnterCar();
                }
                
            }
            else
            {
                LeaveCar();
            }
            
        }
    }

    bool PlayerIsCloseToCar()
    {
        return Vector3.Distance(player.transform.position, transform.position) < 1;
    }

    bool PlayerIsOutsideCar() {
        return !player.activeInHierarchy;
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
