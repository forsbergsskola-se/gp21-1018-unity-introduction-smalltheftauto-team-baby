using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quester : MonoBehaviour{
    public GameObject FloatingTextQuestAcceptedPrefab; 

    public Quest quest = null;
    void Update(){
        if (Input.GetButton("Interact-Phonebooth")){
            PhoneBox[] phones = FindObjectsOfType<PhoneBox>();
            PhoneBox closestPhone = null;
            float shortestDistance = 3;
            Debug.Log("meep");
            foreach(PhoneBox phone in phones){
               float phoneDistance = Vector3.Distance(this.transform.position, phone.transform.position); 
               if (phoneDistance < shortestDistance){
                   closestPhone = phone;
                   shortestDistance = phoneDistance;
                   Debug.Log(phoneDistance);
               }
            }
            if (!(closestPhone == null)){
                if (quest == null){
                    quest = closestPhone.StartQuest();
                    ShowFloatingText();
                }
                if (quest.carDead){
                    closestPhone.HandInQuest(this);
                }
            }
        }
    }

    void ShowFloatingText()
    {
        Instantiate(FloatingTextQuestAcceptedPrefab, transform.position, Quaternion.identity, transform);
    }
}