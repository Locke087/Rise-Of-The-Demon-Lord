using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitSkillEffects
{

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
    public bool dodge;
    public bool stealMoney;
    public bool stealItem;
    public bool darkDamage;
    public bool waterDamage;
    public bool earthDamage;
    public bool natureDamage;
    public bool metalDamage;
    public bool trueDamage;
    public bool overRun;
    public bool movementDown;

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
        darkDamage = false;
        fireDamage = false;
        waterDamage = false;
        earthDamage = false;
        natureDamage = false;
        metalDamage = false;
        trueDamage = false;
        healing = false;
        revive = false;
        hitrateReduce = false;
        dodge = false;
        stealItem = false;
        stealMoney = false;
        overRun = false;
        movementDown = false;
    }
}
