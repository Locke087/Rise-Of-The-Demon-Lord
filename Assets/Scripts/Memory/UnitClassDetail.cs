using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UnitClassDetail {

    public int level;
    public int movement;
    public List<float> modifiers;
    public List<float> caps;
    public UnitClassSkill pickSkill;
    public bool unlocked;
    public string name;
    public List<string> subbed;
    public ClassWeapons classWeapons;
    public UnitClassDetail()
    {
        level = 0;
        movement = 0;
        pickSkill = new UnitClassSkill();
        modifiers = new List<float>();
        caps = new List<float>();
        unlocked = false;
        subbed = new List<string>();
        classWeapons = new ClassWeapons();
    }
}
