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
        // TODO: This is functional, but quite ugly. It would be better, if someone would just replace the `target`-Field on this class whenever necessary. And if there's not targetPlayer and targetCar in parallel.
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
