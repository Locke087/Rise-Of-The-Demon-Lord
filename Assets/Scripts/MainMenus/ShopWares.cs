using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopWares {

    public List<UnitWeapon> weapons;
    public List<UnitAssessory> assessories;

    public ShopWares()
    {
        weapons = new List<UnitWeapon>();
        assessories = new List<UnitAssessory>();
    }
}
