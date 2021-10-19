using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementND : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            // Only, if the W-key is currently pressed...
        {
            transform.Translate(0f, .01f, 0f);
            // Translate the player on the y-axis
        }
        
        //Make player walk backwards, when S-key is pressed
        //Make player turn left, when A-key is pressed
        transform.Rotate(xAngle, yAngle, zAngle);
        //Make player turn right, if D is pressed
        
        //Update, Movement, Frame Rate (FPS)
    }
}
