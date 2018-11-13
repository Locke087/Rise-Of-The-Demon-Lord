using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEffects {

    public bool heal;
    public bool revive;
    public bool doorKey;
    public bool chestKey;
    public bool boostRes;
    public bool curePoison;
    public bool timeLimit;
    public int effectBase;
    public int effectimeLimit;
    public float effectMod;
	public ItemEffects()
    {
        heal = false;
        revive = false;
        doorKey = false;
        boostRes = false;
        chestKey = false;
        curePoison = false;
        timeLimit = false;
        effectBase = 0;
        effectMod = 0;
        effectimeLimit = 0;
    }
}
