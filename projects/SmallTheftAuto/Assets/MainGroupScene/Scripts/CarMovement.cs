using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour{
    public float moveSpeed;
    public int turnSpeed;

    /// <summary>
    /// transform axis' can be called without an individual "GetButton" per direction
    /// </summary>
    /// <returns></returns>
    void FixedUpdate(){

        // 1: assign Vector2 (or 3) values to variable "inputVector"
        //    and set each vector to 0 by calling "Vector2.zero"
        //    shorthand for "Vector2(0, 0)" (or "Vector3(0, 0, 0)")
        //
        // Vector3 inputVector = Vector2.zero;

        // 2: assign to desired axis of inputVector and name appropriately
        // inputVector.y = Input.GetAxis("Vertical");
        
        // TODO: This is not utilizing game physics
        if (Input.GetButton("Interact-Forward")){
            transform.Translate(0f, moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        // delete redudant code
        if (Input.GetButton("Interact-Backward")){
            transform.Translate(0f, moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        // 3: inputVector.x = Input.GetAxis("Horizontal");
        if (Input.GetButton("Interact-Left")){
            // button assignement and values can then easily be set in a separate script
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        // delete redudant code
        if (Input.GetButton("Interact-Right")){
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime*Input.GetAxis("Horizontal"));
        }
    }
}
