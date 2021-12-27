using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// TODO: Good! :)
public class Vehicle : MonoBehaviour{

    public GameObject player;
    private CarMovement carMovement;
    private Driver driver;
    public CameraFollow camera;

    void Start(){
        carMovement = gameObject.GetComponent<CarMovement>();
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
        camera.targetPlayer = driver.gameObject;
        this.driver.camera = camera;
        this.driver = null;
    }
}
