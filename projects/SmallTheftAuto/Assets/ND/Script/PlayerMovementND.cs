using System;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
public class PlayerMovementND : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 15f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
            //transform.Rotate(0f, 0f, -180*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -180*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        if (Input.GetKey(KeyCode.D))
            
        {
            transform.Rotate(0f, 0f, -180*Time.deltaTime*Input.GetAxis("Horizontal"));
        }
    }
}