using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleNA : MonoBehaviour{
    public GameObject playerNa;
    private CarMovementNA carMovementNa;

    void Start(){
        carMovementNa = FindObjectOfType<CarMovementNA>();
    }

    void Update(){
        if (Input.GetButton("Interact-Vehicle")){
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
        return Vector3.Distance(this.playerNa.transform.position, this.transform.position) < 2;
    }

    public void EnterCar(){
        this.playerNa.SetActive(false);
        this.carMovementNa.enabled = true;
    }

    public void LeaveCar(){
        this.playerNa.transform.position = this.transform.position;
        this.playerNa.SetActive(true);
        this.carMovementNa.enabled = false;
    }

}
