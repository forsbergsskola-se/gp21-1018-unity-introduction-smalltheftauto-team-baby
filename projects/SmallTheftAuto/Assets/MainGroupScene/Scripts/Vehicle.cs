using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour{

    public GameObject player;
    private CarMovement carMovement;
    private Driver driver;

    void Start(){
        carMovement = FindObjectOfType<CarMovement>();
    }

    void Update(){
        if (Input.GetButton("Interact-Vehicle")){
            if (!(driver == null)){
                LeaveCar();
            }        
        }
    }

    public void EnterCar(Driver driver){
        this.driver = driver;
        driver.gameObject.SetActive(false);
        this.carMovement.enabled = true;
    }

    public void LeaveCar(){
        this.driver.transform.position = this.transform.position;
        this.driver.gameObject.SetActive(true);
        this.carMovement.enabled = false;
        this.driver = null;
    }
}
