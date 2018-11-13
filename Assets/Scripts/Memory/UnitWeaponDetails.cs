using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeaponDetails {

    public string name;
    public int might;
    public int weight;
    public int hitrate;
    public float critrate;
    public int critchance;
    public int range;
    public bool magic;
    public bool physical;
    public UnitWeaponEffects effects;
    public UnitWeaponDetails()
    {
        name = "";
        might = 0;
        weight = 0;
        hitrate = 0;
        critrate = 0;
        critchance = 0;
        magic = false;
        physical = false;
        effects = new UnitWeaponEffects();
    }
}
