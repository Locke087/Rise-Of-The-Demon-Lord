using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitStatBonus {

    public int str;
    public int def;
    public int will;
    public int mag;
    public int skill;
    public int spd;

    public UnitStatBonus()
    {
        str = 0;
        def = 0;
        will = 0;
        mag = 0;
        skill = 0;
        spd = 0;
    }
}
