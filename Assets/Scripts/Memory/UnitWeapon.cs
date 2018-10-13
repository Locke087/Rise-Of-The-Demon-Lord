using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeapon {

    public string weapon;
    public bool inSlot;
    public bool equipped;

    public UnitWeapon()
    {
        weapon = "";
        inSlot = false;
        equipped = false;
    }
}
