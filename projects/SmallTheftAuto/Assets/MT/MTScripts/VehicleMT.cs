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

    bool PlayerIsOutsideCar(){
        return this.player.activeInHierarchy;
    }

    bool PlayerIsCloseToCar(){
        return Vector3.Distance(this.player.transform.position, this.transform.position) < 1;
    }

    void EnterCar(){
        this.player.SetActive(false);
        this.carMovement.enabled = true;
    }

    void LeaveCar(){
        this.player.transform.position = this.transform.position;
        this.player.SetActive(true);
        this.carMovement.enabled = false;
    }
}
