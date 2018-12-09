using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeaponEffects {

    public bool sleep;
    public bool vampire;
    public bool poison;
    public bool fireDamage;
    public bool darkDamage;
    public bool waterDamage;
    public bool natureDamage;
    public bool earthDamage;
    public bool metalDamage;

    public bool devil;

    public UnitWeaponEffects()
    {
        sleep = false;
        poison = false;
        fireDamage = false;
        waterDamage = false;
        natureDamage = false;
        darkDamage = false;
        earthDamage = false;
        metalDamage = false;
        devil = false;
        vampire = false;
        
    }
}
