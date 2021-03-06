using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float moveSpeed;
    public int turnSpeed;
    public Animator animator;

    

    void Update(){
        if (Input.GetButton("Interact-Forward") || Input.GetButton("Interact-Backward")){
            animator.SetBool("Walk", true);
        }
        else {
            animator.SetBool("Walk", false);
        }
    }
    
    void FixedUpdate(){
        
        if (Input.GetButton("Interact-Forward")){
            transform.Translate(0f, moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        if (Input.GetButton("Interact-Backward")){
            transform.Translate(0f, moveSpeed*Time.deltaTime*Input.GetAxis("Vertical"), 0f);
        }

        if (Input.GetButton("Interact-Left")){
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime*Input.GetAxis("Horizontal"));
        }

        if (Input.GetButton("Interact-Right")){
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime*Input.GetAxis("Horizontal"));
        }
    }
    // This code block could be made into 4 lines of code. var horizontal = Input.GetAxis("Horizontal") * rotSpeed* Time.deltaTime;
    
    // var vertical = Input.GetAxis("Vertical") * speed*Time.deltaTime;
    // transform.Translate(0,vertical,0 );
    // transform.Rotate(0, 0, -horizontal);
}
