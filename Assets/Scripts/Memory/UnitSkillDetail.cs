using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitSkillDetail {

    public string name;
    public float extraDamageMod;
    public float boostMod;
    public float reduceMod;
    public int restore;
    public int baseEffect;
    public int range;
    public bool self;
    public bool support;
    public bool magicDamage;
    public bool physicalDamage;
    public UnitSkillEffects effects;
    public List<UnitMonsterTells> monsterTells;
    // public GameObject attackPattern;
    public string attackPattern;

    public UnitSkillDetail()
    {
        name = "";
        extraDamageMod = 0;
        restore = 0;
        range = 0;
        baseEffect = 0;
        support = false;
        self = false;
        effects = new UnitSkillEffects();
        magicDamage = false;
        physicalDamage = false;
        attackPattern = "";
        monsterTells = new List<UnitMonsterTells>();
    }
}
