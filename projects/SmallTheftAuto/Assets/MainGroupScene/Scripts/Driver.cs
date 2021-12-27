using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour{
    public CameraFollow camera;

    void Update(){
        // TODO: Great use of the Input Manager! Not many have utilized it this well! (Also for the Phone Box)
        if (Input.GetButton("Interact-Vehicle")){
            Vehicle[] cars = FindObjectsOfType<Vehicle>();
            Vehicle closestCar = null;
            float shortestDistance = 3;
            
            foreach(Vehicle vehicle in cars){
               float carDistance = Vector3.Distance(this.gameObject.transform.position, vehicle.gameObject.transform.position); 
               if (carDistance < shortestDistance){
                   closestCar = vehicle;
                   shortestDistance = carDistance;
               }
            }

            if (!(closestCar == null)){
                closestCar.EnterCar(this);
                camera.targetPlayer = closestCar.gameObject;
                closestCar.camera = camera;
            }
        }
    }
}
