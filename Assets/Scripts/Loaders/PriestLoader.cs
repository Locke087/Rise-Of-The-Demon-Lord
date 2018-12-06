﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void AssignSkill(string sk, UnitClassSkill u)
    {
        UnitSkillDetail healingLight = new UnitSkillDetail();
        healingLight.name = "Healing Light";
        healingLight.restore = 0;//magic / 2
        healingLight.range = 4;
        healingLight.effects.healing = true;


        UnitSkillDetail smite = new UnitSkillDetail();
        smite.name = "Smite";
        smite.magicDamage = true;
        smite.effects.holyDamage = true;
        smite.range = 4;


        UnitSkillDetail purify = new UnitSkillDetail();
        purify.name = "Purify";
        purify.effects.statusHeal = true;
        purify.range = 4;


        UnitSkillDetail breathOfLife = new UnitSkillDetail();
        breathOfLife.range = 4;
        breathOfLife.effects.revive = true;//1/5 magic stat
        breathOfLife.restore = 0;//50% life
        breathOfLife.name = "Breath of Life";


        UnitSkillDetail divineProtection = new UnitSkillDetail();
        divineProtection.name = "Divine Protection";
        divineProtection.range = 4;
        divineProtection.effects.defenseBoost = true;
        divineProtection.effects.magicDefenseBoost = true;


        UnitSkillDetail pray = new UnitSkillDetail();
        pray.name = "Pray";
        pray.range = 0;
        pray.attackPattern = "self";
        pray.effects.attackBoost = true;


        UnitSkillDetail divineMastery = new UnitSkillDetail();
        divineMastery.name = "Divine Mastery";
        divineMastery.support = true;
        divineMastery.extraDamageMod = 1.2f;


        if (sk == healingLight.name)
        {
            u.skill1 = healingLight;
        }
        else if (sk == smite.name)
        {
            u.skill2 = smite;
        }
        else if (sk == purify.name)
        {
            u.skill3 = purify;
        }
        else if (sk == breathOfLife.name)
        {
            u.skill4 = breathOfLife;
        }
        else if (sk == divineProtection.name)
        {
            u.skill5 = divineProtection;
        }
        else if (sk == pray.name)
        {
            u.skill6 = pray;
        }
        else if (sk == divineMastery.name)
        {
            u.skill7 = divineMastery;
        }
    }
}