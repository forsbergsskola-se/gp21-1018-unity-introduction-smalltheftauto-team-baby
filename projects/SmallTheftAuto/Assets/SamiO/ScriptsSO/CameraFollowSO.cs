using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSO : MonoBehaviour
{

    public Transform target;
    public float smooth;

    public Vector2 maxPos;
    public Vector2 minPOs;

    
    //public float moveSpeed;
   // public GameObject playerSO;
    //public GameObject CarMoveSO;
    //private Transform rigTransform;
    
    
   
    void FixedUpdate()
    {
        if (transform.position != target.position)
       { 
           Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPos.x = Mathf.Clamp(targetPos.x, minPOs.x, maxPos.x);
          
            targetPos.y = Mathf.Clamp(targetPos.y, minPOs.y, maxPos.y);
                
            transform.position = Vector3.Lerp(transform.position, targetPos, smooth);
       }

       // if (playerSO == null)
       // {
            return;
       // }

       // if (playerSO.activeInHierarchy)
       // {
       //     rigTransform.position = Vector3.Lerp(rigTransform.position, playerSO.transform.position,
       //         Time.deltaTime * moveSpeed); 
            
      //  }
       // else
       // {
          //  rigTransform.position = Vector3.Lerp(rigTransform.position, CarMoveSO.transform.position,
                //Time.deltaTime * moveSpeed);
       // }
        
    }  
    
}
