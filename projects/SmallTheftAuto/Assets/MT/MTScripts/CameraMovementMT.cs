using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementMT : MonoBehaviour
{
    public float moveSpeed;
    public GameObject targetPlayerMT;
    public GameObject targetCarMT;
    private Transform rigTransform;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigTransform = this.transform.parent;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(targetPlayerMT == null){
            return;
        }
        if(targetPlayerMT.activeInHierarchy){
            rigTransform.position = Vector3.Lerp(rigTransform.position, targetPlayerMT.transform.position, 
                Time.deltaTime * moveSpeed);
        }
        else{
            rigTransform.position = Vector3.Lerp(rigTransform.position, targetCarMT.transform.position, 
                Time.deltaTime * moveSpeed);
        }
    }
}
