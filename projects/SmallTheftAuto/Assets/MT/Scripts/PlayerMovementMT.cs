using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
public class PlayerMovementMT : MonoBehaviour
{
    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 15f*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
            transform.Rotate(0f, 0f, -180*Time.deltaTime*Input.GetAxis("Horizontal"));
        }
        
    }
}
