using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarInputSO : MonoBehaviour
{
    private NewCarScriptSO newCarScriptSO;
    void Awake()
    {
        newCarScriptSO = GetComponent<NewCarScriptSO>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical"); 
        
        
        newCarScriptSO.SetInputVector(inputVector);
    }
}
