using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBox : MonoBehaviour{
    public Quest StartQuest(){
        //UI accept quest, telling you you're on a quest
        Quest carHater = new Quest();
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
    int reward = 0; //Money???
}
