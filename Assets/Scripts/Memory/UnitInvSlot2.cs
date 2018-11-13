using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInvSlot2 {

    public string holding;
    public UnitWeapon weapon;
    public UnitAssessory assessory;

    public UnitInvSlot2()
    {
        holding = "";
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
