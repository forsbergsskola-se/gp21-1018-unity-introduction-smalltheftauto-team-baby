using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: You forgot to put this on the text. That's why it stays endlessly
public class FloatingTextAcceptQuest : MonoBehaviour
{

    public float DestroyTime = 3f;
    
    void Start()
        {
            Destroy(gameObject, DestroyTime);
        }

    
   
}
