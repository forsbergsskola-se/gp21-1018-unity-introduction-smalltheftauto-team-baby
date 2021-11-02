using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleNA : MonoBehaviour{
    public GameObject playerNa;
    private CarMovementNA carMovementNa;
    private DriverNA driver;

    void Start(){
        carMovementNa = FindObjectOfType<CarMovementNA>();
    }

    void Update(){
        if (Input.GetButton("Interact-Vehicle")){
            if (!(driver == null)){
                LeaveCar();
            }        
        }
    }

    public void EnterCar(DriverNA driver){
        this.driver = driver;
        driver.SetActive(false);
        this.carMovementNa.enabled = true;
    }

    public void LeaveCar(){
        this.driver.transform.position = this.transform.position;
        this.driver.SetActive(true);
        this.carMovementNa.enabled = false;
        this.driver = null;
    }

}
