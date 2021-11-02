using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSO : MonoBehaviour{
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


//public Transform target
//public float smooth;   
                          
//public Vector2 maxPos; 
// public Vector2 minPOs; 


//if (transform.position != target.position)                                                      
// {                                                                                               
    //  Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
                                                                                                  
    // targetPos.x = Mathf.Clamp(targetPos.x, minPOs.x, maxPos.x);                                 
    //  targetPos.y = Mathf.Clamp(targetPos.y, minPOs.y, maxPos.y);                                 
                                                                                                  
    //transform.position = Vector3.Lerp(transform.position, targetPos, smooth);                   
    // }                                                                                               
