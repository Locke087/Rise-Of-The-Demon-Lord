using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeapon {

    public string idx;
    public int cost;
    public string name;
    public bool inSlot;
    public bool equipped;
    public UnitWeaponDetails details;

    public UnitWeapon()
    {
        idx = "";
        name = "";
        cost = 0;
        inSlot = false;
        equipped = false;
        details = new UnitWeaponDetails();
    }
}
