using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleNA : MonoBehaviour{
    public GameObject playerNa;
    public CarMovementNA carMovementNa;

    void Update(){
        if (Input.GetKeyDown("Interact-Vehicle")){
            if (PlayerIsOutsideCar()){
                if(PlayerIsCloseToCar()){
                EnterCar();
                }
            }
            else {
            LeaveCar();
            }        
        }
    }
    
    bool PlayerIsOutsideCar(){
        return this.playerNa.activeInHierarchy;
    }

    bool PlayerIsCloseToCar(){
        return Vector3.Distance(this.playerNa.transform.position, this.transform.position) < 1;
    }

    void EnterCar(){
        this.playerNa.SetActive(false);
        this.carMovementNa.enabled = true;
    }

    void LeaveCar(){
        this.playerNa.transform.position = this.transform.position;
        this.playerNa.SetActive(true);
        this.carMovementNa.enabled = false;
    }

}
