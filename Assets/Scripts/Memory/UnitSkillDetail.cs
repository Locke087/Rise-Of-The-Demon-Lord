﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitSkillDetail {

    public string name;
    public float extraDamageMod;
    public int restore;
    public int range;
    public bool support;
    public bool magicDamage;
    public bool physicalDamage;

    public UnitSkillEffects effects;
    // public GameObject attackPattern;
    public string attackPattern;

    public UnitSkillDetail()
    {
        name = "";
        extraDamageMod = 0;
        restore = 0;
        range = 0;
        support = false;
        effects = new UnitSkillEffects();
        magicDamage = false;
        physicalDamage = false;
        attackPattern = "";

    }
}