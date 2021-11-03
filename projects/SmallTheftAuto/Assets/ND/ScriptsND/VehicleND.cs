using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleND : MonoBehaviour{
    public GameObject PlayerND;
    public CarMovementND carMovementNd;
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
        return this.playerda.activeInHierarchy;
    }
    bool PlayerIsCloseToCar(){
        return Vector3.Distance(this.playerNd.transform.position, this.transform.position) < 1;
    }
    void EnterCar(){
        this.playerNd.SetActive(false);
        this.carMovementNd.enabled = true;
    }
    void LeaveCar(){
        this.playerNd.transform.position = this.transform.position;
        this.playerNd.SetActive(true);
        this.carMovementNd.enabled = false;
    }
}
