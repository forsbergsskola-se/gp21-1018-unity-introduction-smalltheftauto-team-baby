using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTimerSO : MonoBehaviour
{
  public float timePassed;
  public float startingTime;

   [SerializeField] Text countText;

  private void Start()
  {
    timePassed = startingTime;
    
  }


  private void Update()
  {
     timePassed += 1 * Time.deltaTime;
     countText.text = timePassed.ToString("0");
    
    countText.color = Color.yellow;
    
    //countText.text = timePassed.ToString("0,0s");
    //string minutes = ((int) startingTime / 60).ToString();
    //string seconds = (startingTime % 60).ToString("f2");
    //countText.text = minutes + ":" + seconds;

  }
}

