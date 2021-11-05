using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMoney : MonoBehaviour
{
    public static UIMoney instance;
    
    public Text moneyText;

    int money = 0;


    private void Awake()
    {
        instance = this;
        
        //UIMoney.Instance.AddMoney();
        //  ^ call this to update ui when u pick up money
    }

    void Start()
    {
        moneyText.text = money.ToString() + " $";
    }

    
    public void AddMoney()
    {
        money += 1;
        moneyText.text = money.ToString() + " $";
    }
}
