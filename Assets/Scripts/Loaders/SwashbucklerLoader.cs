using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwashbucklerLoader : MonoBehaviour
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
        UnitSkillDetail avast = new UnitSkillDetail();
        avast.name = "Avast!";
        avast.extraDamageMod = 0;//+1/2 dmg vs target
        avast.range = 3;
        avast.effects.attackBoost = true;


        UnitSkillDetail ropeADope = new UnitSkillDetail();
        ropeADope.name = "Rope-A-Dope";
        ropeADope.physicalDamage = true;
        ropeADope.effects.swapPosition = true;
        ropeADope.range = 2;


        UnitSkillDetail pommelBash = new UnitSkillDetail();
        pommelBash.name = "Pommel Bash";
        pommelBash.physicalDamage = true;
        pommelBash.effects.confuse = true;
        pommelBash.range = 1;


        UnitSkillDetail toTheHilt = new UnitSkillDetail();
        toTheHilt.range = 1;
        toTheHilt.effects.root = true;//entangle enemy
        toTheHilt.physicalDamage = true;
        toTheHilt.name = "To The Hilt";


        UnitSkillDetail scatterShot = new UnitSkillDetail();
        scatterShot.name = "Scattershot";
        scatterShot.range = 3;
        scatterShot.attackPattern = "2x3 cone";
        scatterShot.effects.randomDamage = true;//deals random damage (weapon + atk * 2 max)
        scatterShot.physicalDamage = true;


        UnitSkillDetail parryAndRiposte = new UnitSkillDetail();
        parryAndRiposte.name = "Parry and Riposte";
        parryAndRiposte.range = 1;
        parryAndRiposte.support = true;
        parryAndRiposte.attackPattern = "self";
        parryAndRiposte.physicalDamage = true;
        parryAndRiposte.effects.counter = true;


        UnitSkillDetail shotOffTheBow = new UnitSkillDetail();
        shotOffTheBow.name = "Shot off the Bow";
        shotOffTheBow.range = 5;
        shotOffTheBow.effects.shaken = true;
        shotOffTheBow.attackPattern = "5 tile line";
        shotOffTheBow.physicalDamage = true;


        if (sk == avast.name)
        {
            u.skill1 = avast;
        }
        else if (sk == ropeADope.name)
        {
            u.skill2 = ropeADope;
        }
        else if (sk == pommelBash.name)
        {
            u.skill3 = pommelBash;
        }
        else if (sk == toTheHilt.name)
        {
            u.skill4 = toTheHilt;
        }
        else if (sk == scatterShot.name)
        {
            u.skill5 = scatterShot;
        }
        else if (sk == parryAndRiposte.name)
        {
            u.skill6 = parryAndRiposte;
        }
        else if (sk == shotOffTheBow.name)
        {
            u.skill7 = shotOffTheBow;
        }
    }
}
