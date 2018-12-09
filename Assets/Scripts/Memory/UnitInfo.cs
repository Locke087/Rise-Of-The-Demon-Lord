using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInfo {

    public string nature;
    public List<int> bases;
    public List<float> currentMods;
    public List<float> currentCaps;
    public bool human;
    public bool vira;
    public bool imp;
    public string mugName;
    public string affinity;
    public UnitWeaponRanks weaponRanks;
    public UnitClassDetail main;
    public UnitClassDetail sub;
    public UnitInfo()
    {
        bases = new List<int>();
        main = new UnitClassDetail();
        sub = new UnitClassDetail();
        weaponRanks = new UnitWeaponRanks();
        nature = "";
        affinity = "";
        currentCaps = new List<float>();
        currentMods = new List<float>();
        human = false;
        imp = false;
        vira = false;
        nature = "random";
    }
}
