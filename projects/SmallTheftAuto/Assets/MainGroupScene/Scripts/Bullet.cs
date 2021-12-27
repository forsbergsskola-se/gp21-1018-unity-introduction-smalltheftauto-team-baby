using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collison)
    {
        // TODO: Fix: Calling this twice.
        Destroy(gameObject);
        Destroy(gameObject, 4f);
        
       
    } 
}
