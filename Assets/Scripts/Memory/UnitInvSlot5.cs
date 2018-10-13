using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UnitInvSlot5 {

    public UnitWeapon weapon;
    public UnitAssessory assessory;

    public UnitInvSlot5()
    {
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
