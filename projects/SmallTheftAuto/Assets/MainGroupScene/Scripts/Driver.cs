using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour{

    void Update(){
        if (Input.GetButton("Interact-Vehicle")){
            Vehicle[] cars = FindObjectsOfType<Vehicle>();
            Vehicle closestCar = null;
            float shortestDistance = 3;
            
            foreach(Vehicle vehicle in cars){
               float carDistance = Vector3.Distance(this.transform.position, vehicle.transform.position); 
               if (carDistance < shortestDistance){
                   closestCar = vehicle;
                   shortestDistance = carDistance;
               }
            }

            if (!(closestCar == null)){
                closestCar.EnterCar(this);
            }
        }
    }
}
