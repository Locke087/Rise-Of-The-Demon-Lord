using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitSkillEffects {

    public bool knockBack;
    public bool attackBoost;
    public bool defenseBoost;
    public bool hitReduction;
    public bool damageReduction;
    public bool extraHit;
    public bool holyDamage;
    public bool fireDamage;
    public bool healing;
    public bool extraTurn;
    public bool revive;
    public bool willBoost;
    public bool skillUseRestore;
    public bool poison;
    public bool sleep;
    public bool berserk;
    public bool vampire;
    public bool selfDamage;
    public bool counter;
    public bool hitrateReduce;
    public UnitSkillEffects()
    {
        counter = false;
        selfDamage = false;
        hitReduction = false;
        knockBack = false;
        attackBoost = false;
        defenseBoost = false;
        skillUseRestore = false;
        willBoost = false;
        damageReduction = false;
        extraHit = false;
        extraTurn = false;
        poison = false;
        sleep = false;
        berserk = false;
        vampire = false;
        holyDamage = false;
        fireDamage = false;
        healing = false;
        revive = false;


    }
}
