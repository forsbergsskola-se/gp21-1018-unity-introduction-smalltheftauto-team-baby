using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float moveSpeed;
    public GameObject targetPlayer;
    public GameObject targetCar;
    private Transform rigTransform; 

    void Start(){
        
        rigTransform = this.transform.parent;
    }

    void FixedUpdate (){
        if(targetPlayer == null){
            return;
        }
        if(targetPlayer.activeInHierarchy){
            rigTransform.position = Vector3.Lerp(rigTransform.position, targetPlayer.transform.position, 
                Time.deltaTime * moveSpeed);
        }
        else{
            rigTransform.position = Vector3.Lerp(rigTransform.position, targetCar.transform.position, 
                Time.deltaTime * moveSpeed);
        }
    }
}
