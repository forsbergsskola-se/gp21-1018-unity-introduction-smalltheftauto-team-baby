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
        (quester.gameObject.GetComponent<Player>()).money += quester.quest.reward;
        quester.quest = null;
        carDead = false;
    }
}

public class Quest{
    public bool carDead = false;
    int reward = 100;
}
