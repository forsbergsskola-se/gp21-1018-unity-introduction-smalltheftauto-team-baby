using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMT : MonoBehaviour
{

    public float timePassed;
    public float timeStart;
    
    
    void Start()
    {
        timePassed = timeStart;
    }

    
    void Update()
    {
        timePassed += 1 * Time.deltaTime;
        
    }
}
