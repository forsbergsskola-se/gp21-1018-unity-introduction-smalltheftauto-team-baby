using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerMT : MonoBehaviour{

    public GameObject dogPreFab;
    GameObject dogInstance;

    

    private void OnEnable()
    {
        dogInstance = Instantiate(dogPreFab);
    }
    

    private void OnDisable()
    {
        Destroy(dogPreFab);
    }
}
