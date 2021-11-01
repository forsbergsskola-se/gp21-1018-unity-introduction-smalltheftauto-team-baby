using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementMT : MonoBehaviour
{
    public float moveSpeed;
    public GameObject targetPlayer;
    public GameObject targetCar;
    private Transform rigTransform;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigTransform = this.transform.parent;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
