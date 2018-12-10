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

    public static void NewClass()
    {
        Swashbuckler.Clear();
        Swashbuckler.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.name = "Swashbuckler";
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.classWeapons.classWeapon1.type = "Light Blades";
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.classWeapons.classWeapon2.type = "Ranged";
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.classWeapons.classWeapon2.rank = 2;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.caps = Swashbuckler.Caplist();

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Swashbuckler.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level + 1;
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.modifiers = Swashbuckler.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.swashbuckler.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.modifiers;
                    u.unitClass.main.imp.swashbuckler.level = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.swashbuckler.unlocked = true;
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
        scatterShot.attackPattern = "3x3cone";
        scatterShot.effects.randomDamage = true;//deals random damage (weapon + atk * 2 max)
        scatterShot.physicalDamage = true;


        UnitSkillDetail parry = new UnitSkillDetail();
        parry.name = "Parry";
        parry.range = 0;
        parry.support = true;
        parry.attackPattern = "self";
        parry.effects.dodge = true;
        parry.effects.counter = true;


        UnitSkillDetail shotOffTheBow = new UnitSkillDetail();
        shotOffTheBow.name = "Shot off the Bow";
        shotOffTheBow.range = 5;
        shotOffTheBow.effects.shaken = true;
        shotOffTheBow.attackPattern = "4tileLine";
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
        else if (sk == parry.name)
        {
            u.skill6 = parry;
        }
        else if (sk == shotOffTheBow.name)
        {
            u.skill7 = shotOffTheBow;
        }
    }
}
