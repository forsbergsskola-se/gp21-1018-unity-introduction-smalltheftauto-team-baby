using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextWASTED : MonoBehaviour
{
    // You could use it so gameobject gets enabled after you die and then use Invoke to have it Destroy game object after 4 sec. 
    public float DestroyTime = 3f;    
    
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
    
}
