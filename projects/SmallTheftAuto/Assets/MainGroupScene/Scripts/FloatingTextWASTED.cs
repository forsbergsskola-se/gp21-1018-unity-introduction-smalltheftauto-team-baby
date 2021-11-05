using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextWASTED : MonoBehaviour
{

    public float DestroyTime = 3f;    
    
    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }
    
}
