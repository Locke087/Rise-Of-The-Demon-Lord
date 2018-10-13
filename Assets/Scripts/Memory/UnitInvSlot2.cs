using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInvSlot2 {

    public UnitWeapon weapon;
    public UnitAssessory assessory;

    public UnitInvSlot2()
    {
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
