using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNA : MonoBehaviour{

    void Start(){
        
    }

    void Update(){
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0f, 0.01f, 0f);
        }
    }
}
