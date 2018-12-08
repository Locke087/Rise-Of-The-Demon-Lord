using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChestPool {

    public List<UnitWeapon> weapons;
    public List<UnitAssessory> assessories;
    public int gold;

    public ChestPool()
    {
        weapons = new List<UnitWeapon>();
        assessories = new List<UnitAssessory>();
        gold = 0;
    }
}
