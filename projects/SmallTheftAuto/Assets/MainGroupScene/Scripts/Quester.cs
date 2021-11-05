using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quester : MonoBehaviour{

    public Quest quest;
    void Update(){
        if (Input.GetButton("Interact-Phonebooth")){
            PhoneBox[] phones = FindObjectsOfType<PhoneBox>();
            PhoneBox closestPhone = null;
            float shortestDistance = 2;
            foreach(PhoneBox phone in phones){
               float phoneDistance = Vector3.Distance(this.transform.position, phone.transform.position); 
               if (phoneDistance < shortestDistance){
                   closestPhone = phone;
                   shortestDistance = phoneDistance;
               }
            }
            if (!(closestPhone == null)){
                if (quest == null){
                    quest = closestPhone.StartQuest();
                }
                if (quest.carDead){
                    closestPhone.HandInQuest(this);
                }
            }
        }
    }
}