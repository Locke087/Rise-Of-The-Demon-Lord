using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeaponEffects {

    public bool sleep;
    public bool vampire;
    public bool poison;
    public bool fireDamage;
    public bool devil;

    public UnitWeaponEffects()
    {
        sleep = false;
        poison = false;
        fireDamage = false;
        devil = false;
        vampire = false;
    }
}
