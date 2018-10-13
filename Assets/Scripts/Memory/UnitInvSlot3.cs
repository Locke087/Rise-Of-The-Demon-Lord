using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInvSlot3 {

    public UnitWeapon weapon;
    public UnitAssessory assessory;

    public UnitInvSlot3()
    {
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
