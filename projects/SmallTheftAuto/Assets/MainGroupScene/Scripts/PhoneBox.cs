using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBox : MonoBehaviour{
    
    public GameObject FloatingTextQuestAcceptedPrefab; 
    public Quest StartQuest(){
        Quest carHater = new Quest();
        Debug.Log("carHater");
        return carHater;
    }

    public void HandInQuest(Quester quester){
        //UI "You're great, killed car!"
        //Get reward!
        quester.quest = null;
    }
}

public class Quest{
    public bool carDead = false;
    public int reward = 0; //Money???
}
