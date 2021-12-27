using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TODO: Nice, I like that you split money, score etc. into multiple scripts
public class UIMoney : MonoBehaviour
{
    public static UIMoney instance;
    
    public Text moneyText;

    int money = 0;


    private void Awake()
    {
        instance = this;
        
        //UIMoney.instance.AddMoney();
        //  ^ call this to update ui when u pick up money
    }

    void Start()
    {
        moneyText.text = money.ToString() + " $";
    }

    
    public void AddMoney()
    {
        money += 20;
        moneyText.text = money.ToString() + " $";
    }
}
