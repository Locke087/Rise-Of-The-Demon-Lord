using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeapon {

    public string idx;
    public string name;
    public bool inSlot;
    public bool equipped;
    public UnitWeaponDetails details;

    public UnitWeapon()
    {
        idx = "";
        name = "";
        inSlot = false;
        equipped = false;
        details = new UnitWeaponDetails();
    }
}
