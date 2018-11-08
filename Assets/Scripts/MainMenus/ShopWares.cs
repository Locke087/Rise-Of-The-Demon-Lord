using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopWares {

    public List<UnitWeapon> weapons;
    public List<UnitAssessory> assessories;

    public ShopWares()
    {
        weapons = new List<UnitWeapon>();
        assessories = new List<UnitAssessory>();
    }
}
