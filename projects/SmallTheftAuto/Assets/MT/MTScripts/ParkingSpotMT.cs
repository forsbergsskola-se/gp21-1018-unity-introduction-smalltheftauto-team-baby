using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParkingSpotMT : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void Start()
    {
        if (hasCar == true)
        {
            
        }
    }


    public bool hasCar;
    
        

    public GameObject carPrefab;

    // void CreateCar() {
    //     
    //     GameObject parent = new GameObject("ParkingSpotMT");
    //     GameObject child = new GameObject("CarMT");
    //     child.transform.SetParent(parent.transform);
    //     newCarMT = child.AddComponent<CarMT>();
    //    
    // }
}
