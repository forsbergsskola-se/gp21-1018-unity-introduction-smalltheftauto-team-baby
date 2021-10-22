using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssetsSO : MonoBehaviour
{
   
   
    private static GameAssetsSO _i;

    public static GameAssetsSO I
    {
        get
        {
            if ( _i == null) _i = Instantiate(Resources.Load<GameAssetsSO>("GameAssetsSO"));
            return _i;
        }
        
    }

    public Transform TextPopUp;

}
