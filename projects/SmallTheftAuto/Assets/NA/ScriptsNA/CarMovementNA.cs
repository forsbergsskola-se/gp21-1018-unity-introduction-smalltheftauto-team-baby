using System;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class CarMovementNA : MonoBehaviour{
    public float moveSpeed;
    public int turnSpeed;
    
    void FixedUpdate(){
        
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0f, moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0f, moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime*Input.GetAxis("Horizontal"));
        }
    }
}