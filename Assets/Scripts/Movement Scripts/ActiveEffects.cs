using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActiveEffects {

    public string name;
    public int timer;
    public ActiveEffects(string n, int t)
    {
        name = n;
        timer = t;
    }


}
