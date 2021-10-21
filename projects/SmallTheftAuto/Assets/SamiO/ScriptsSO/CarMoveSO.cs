using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveSO : MonoBehaviour
{


    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 10f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 10f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, -165*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        if (Input.GetKey(KeyCode.D))
            
        {
            transform.Rotate(0f, 0f, -165*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        
    }
}
