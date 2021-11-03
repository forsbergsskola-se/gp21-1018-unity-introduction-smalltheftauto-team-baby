using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class VehicleMT : MonoBehaviour
{
    public GameObject playerMT;
    //public CarMovementMT carMovement;
    

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
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
        return this.playerMT.activeInHierarchy;
    }

    bool PlayerIsCloseToCar(){
        return Vector3.Distance(this.playerMT.transform.position, this.transform.position) < 1;
    }

    void EnterCar(){
        this.playerMT.SetActive(false);
        this.GetComponent<CarMovementMT>().enabled = true;
    }

    void LeaveCar(){
        this.playerMT.transform.position = this.transform.position;
        this.playerMT.SetActive(true);
        GetComponent<CarMovementMT>().enabled = false ;
    }
}
