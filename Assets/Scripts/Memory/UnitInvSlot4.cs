using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInvSlot4 {

    public string holding;
    public UnitWeapon weapon;
    public UnitAssessory assessory;

    public UnitInvSlot4()
    {
        holding = "";
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
