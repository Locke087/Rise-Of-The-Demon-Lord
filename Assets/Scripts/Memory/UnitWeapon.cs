using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeapon {

    public bool inSlot;
    public bool equipped;
    public UnitWeaponDetails details;

    public UnitWeapon()
    {
        inSlot = false;
        equipped = false;
        details = new UnitWeaponDetails();
    }
}
