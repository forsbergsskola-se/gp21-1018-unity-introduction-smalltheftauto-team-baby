using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSO : MonoBehaviour
{
    public GameObject playerSO;
   
  
  
    void Update(){
        if (Input.GetKeyDown(KeyCode.F)){
            if (PlayerIsOutsideCar()){
                if(PlayerIsCloseToCar()){
                    EnterCar();
                }
            }
            else {
                LeaveCar();
            }        
        }
    }
    bool PlayerIsOutsideCar(){
        return this.playerSO.activeInHierarchy;
    }

    bool PlayerIsCloseToCar(){
        return Vector3.Distance(this.playerSO.transform.position, this.transform.position) < 1;
    }

    void EnterCar(){
        this.playerSO.SetActive(false);
        this.GetComponent<CarMove2SO>().enabled = true;
        
        
    }

    void LeaveCar(){
        this.playerSO.transform.position = this.transform.position;
        this.playerSO.SetActive(true);
        this.GetComponent<CarMove2SO>().enabled = false;
        
    }

}
