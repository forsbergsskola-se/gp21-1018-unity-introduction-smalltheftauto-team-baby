
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timePassed;
    public float timeStart = 0;
    public Text timeText;
    
    
    void Start()
    {
        timePassed = timeStart;
    }

    
    void Update()
    {
        timePassed += 1 * Time.deltaTime;
        
        DisplayTime(timePassed);
        
        
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}