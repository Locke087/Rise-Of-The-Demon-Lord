using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static int HowManySkills(UnitClassSkill u)
    {
        int i = 0;

        if (u.skill1.name != "")
        {
            i++;
        }
        else if (u.skill2.name != "")
        {
            i++;
        }
        else if (u.skill3.name != "")
        {
            i++;
        }
        else if (u.skill4.name != "")
        {
            i++;
        }
        else if (u.skill5.name != "")
        {
            i++;
        }
        else if (u.skill6.name != "")
        {
            i++;
        }
        else if (u.skill7.name != "")
        {
            i++;
        }
        return i;
    }

    public static bool HasSkill(string sk, UnitClassSkill u)
    {

        if (u.skill1.name == sk)
        {
            return true;
        }
        else if (u.skill2.name == sk)
        {
            return true;
        }
        else if (u.skill3.name == sk)
        {
            return true;
        }
        else if (u.skill4.name == sk)
        {
            return true;
        }
        else if (u.skill5.name == sk)
        {
            return true;
        }
        else if (u.skill6.name == sk)
        {
            return true;
        }
        else if (u.skill7.name == sk)
        {
            return true;
        }

        return false;

    }

    public static void AssignSkill(string sk, UnitClassSkill u)
    {
        UnitSkillDetail barrier = new UnitSkillDetail();
        barrier.name = "Barrier";
        barrier.effects.nullDamage = true;
        barrier.range = 0;


        UnitSkillDetail arcaneBolt = new UnitSkillDetail();
        arcaneBolt.name = "Arcane Bolt";
        arcaneBolt.magicDamage = true;
        arcaneBolt.range = 5;


        UnitSkillDetail auraBurst = new UnitSkillDetail();
        auraBurst.name = "Aura Burst";
        auraBurst.magicDamage = true;
        auraBurst.attackPattern = "adjacentEnemies";
        auraBurst.range = 1;


        UnitSkillDetail meditation = new UnitSkillDetail();
        meditation.range = 0;
        meditation.effects.mpRestore = true;//1/5 magic stat
        meditation.name = "Meditation";


        UnitSkillDetail chant = new UnitSkillDetail();
        chant.name = "Chant";
        chant.range = 0;
        chant.effects.attackBoost = true;


        UnitSkillDetail powerThroughPain = new UnitSkillDetail();
        powerThroughPain.name = "Power Through Pain";
        powerThroughPain.range = 0;
        powerThroughPain.support = true;
        powerThroughPain.attackPattern = "self";
        powerThroughPain.effects.counter = true;


        UnitSkillDetail arcaneMastery = new UnitSkillDetail();
        arcaneMastery.name = "Arcane Mastery";
        arcaneMastery.support = true;
        arcaneMastery.extraDamageMod = 1.2f;


        if (sk == barrier.name)
        {
            u.skill1 = barrier;
        }
        else if (sk == arcaneBolt.name)
        {
            u.skill2 = arcaneBolt;
        }
        else if (sk == auraBurst.name)
        {
            u.skill3 = auraBurst;
        }
        else if (sk == meditation.name)
        {
            u.skill4 = meditation;
        }
        else if (sk == chant.name)
        {
            u.skill5 = chant;
        }
        else if (sk == powerThroughPain.name)
        {
            u.skill6 = powerThroughPain;
        }
        else if (sk == arcaneMastery.name)
        {
            u.skill7 = arcaneMastery;
        }
    }
}

