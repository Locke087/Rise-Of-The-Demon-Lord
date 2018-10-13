using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInvSlot1 {

    public UnitWeapon weapon;
    public UnitAssessory assessory;

	public UnitInvSlot1()
    {
        weapon = new UnitWeapon();
        assessory = new UnitAssessory();
    }
}
