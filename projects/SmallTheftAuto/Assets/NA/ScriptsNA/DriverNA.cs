using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverNA : MonoBehaviour
{
    void Update(){
        if (Input.GetButton("Interact-Vehicle")){
            VehicleNA[] cars = FindbjectsOfType<VehicleNA>();
            VehicleNA closestCar;
            float shortestDistance = 3;
            foreach(VehicleNA vehicle in cars){
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
