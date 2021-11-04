using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniMapCameraFollow : MonoBehaviour
{
    // public Transform Player;
    // public Vector3 offset;
    // void Start()
    // {
    //     transform.position = Player.position + offset;
    //
    //     Vector3 rot = new Vector3(90, 0, Player.eulerAngles.z);
    //     
    //     transform.rotation = Quaternion.Euler(rot); 
    // }
    
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
