using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UnitInvSlot5 {

    public string holding;
    public UnitWeapon weapon;
    public UnitAssessory assessory;

    public UnitInvSlot5()
    {
        holding = "";
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
