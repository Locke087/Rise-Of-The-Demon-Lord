using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentGame 
{

    public static CurrentGame game;
    public UnitStoreroom storeroom;

    public CurrentGame()
    {
        storeroom = new UnitStoreroom();
    }
}
