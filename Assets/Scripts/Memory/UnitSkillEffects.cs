using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitSkillEffects
{
    public bool fourth;
    public bool reflectDamage;
    public bool absorbDamage;
    public bool reduceDefense;
    public bool reduceAttack;
    public bool kill;
    public bool increaseAccuracy;
    public bool increaseDebuffs;
    public bool randomDebuff;
    public bool invisible;
    public bool randomDamage;
    public bool swapPosition;
    public bool knockBack;
    public bool nullDamage;
    public bool mpRestore;
    public bool attackBoost;
    public bool defenseBoost;
    public bool magicDefenseBoost;
    public bool hitReduction;
    public bool critIncrease;
    public bool damageReduction;
    public bool extraHit;
    public bool holyDamage;
    public bool fireDamage;
    public bool healing;
    public bool extraTurn;
    public bool revive;
    public bool speedBoost;
    public bool magicBoost;
    public bool willBoost;
    public bool skillUseRestore;
    public bool poison;
    public bool sleep;
    public bool shaken;
    public bool stun;
    public bool root;
    public bool confuse;
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
    public bool movementIncrease;
    public bool statusHeal;

    public UnitSkillEffects()
    {
        fourth = false;//decrease health by 1/4
        reduceAttack = false;//lower attack
        absorbDamage = false;//take half damage for target, they take other half
        reflectDamage = false;//Target takes half of the damage you take for 1 turn
        reduceDefense = false;//defense -1
        kill = false;//minor chance to auto kill 
        increaseAccuracy = false;//
        increaseDebuffs = false;//increase chance to cause debuffs
        randomDebuff = false;//cause random debuff
        invisible = false;
        critIncrease = false;//increase crit chance 3 turns
        shaken = false;//damage reduced 50% 3 turns
        randomDamage = false;
        root = false;//cannot move 3 turns
        confuse = false;//50% chance to hit self 3 turns
        stun = false;//target cannot attack next turn
        swapPosition = false;//swap positions with target
        statusHeal = false;//heal debuffs
        counter = false;//counter type skill
        mpRestore = false;//restore mp
        nullDamage = false;//nullify damage
        selfDamage = false;//damage self
        hitReduction = false;//reduce my accuracy 
        knockBack = false;//knock target back one tile
        attackBoost = false;//boost physical damage
        defenseBoost = false;//boost physical defense
        magicBoost = false;//boost magic damage
        speedBoost = false;//boost speed
        skillUseRestore = false;//Mp restore part 2?
        willBoost = false;//boost magic defense
        damageReduction = false;//reduce damage taken
        extraHit = false;//hit another time
        extraTurn = false;//get extra turn
        poison = false;//take 1/16 hp total each turn
        sleep = false;//unit takes no actions 3 turns
        berserk = false;//nope?
        vampire = false;//become undead and uncontrolled
        holyDamage = false;//deal holy damage
        darkDamage = false;//deal dark damage
        fireDamage = false;//deal fire damage
        waterDamage = false;//deal water damage
        earthDamage = false;//deal earth damage
        natureDamage = false;//deal nature damage
        metalDamage = false;//deal metal damage
        trueDamage = false;//deal damage that ignores defense/magic defense
        healing = false;//heal
        revive = false;//revive
        hitrateReduce = false;//reduce their accuracy
        dodge = false;//chance to dodge attacks and take no damage
        stealItem = false;//steal things
        stealMoney = false;//steal money
        overRun = false;//run over foe and deal damage
        movementDown = false;//decrease movement 3 turns
        movementIncrease = false;//increase movement 3 turns
    }
}
