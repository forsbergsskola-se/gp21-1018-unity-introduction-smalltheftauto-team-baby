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
}
