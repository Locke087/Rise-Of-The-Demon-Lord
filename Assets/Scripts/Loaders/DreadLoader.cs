using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreadLoader : MonoBehaviour {


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
        Dread.Clear();
        Dread.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.dread.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.dread.name = "Dread";
        CurrentGame.game.memoryGeneral.impClassProgress.dread.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.dread.classWeapons.classWeapon1.type = "Heavy Blades";
        CurrentGame.game.memoryGeneral.impClassProgress.dread.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.dread.classWeapons.classWeapon2.type = "Axes";
        CurrentGame.game.memoryGeneral.impClassProgress.dread.classWeapons.classWeapon2.rank = 2;

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Dread.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.dread.level = CurrentGame.game.memoryGeneral.impClassProgress.dread.level + 1;
        CurrentGame.game.memoryGeneral.impClassProgress.dread.modifiers = Dread.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.dread.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.dread.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.dread.modifiers;
                    u.unitClass.main.imp.dread.level = CurrentGame.game.memoryGeneral.impClassProgress.dread.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.dread.unlocked = true;
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
        UnitSkillDetail endarken = new UnitSkillDetail();
        endarken.name = "Endarken";
        endarken.range = 4;
        endarken.effects.darkDamage = true;//buff ally's weapon with dark damage


        UnitSkillDetail darkbolt = new UnitSkillDetail();
        darkbolt.name = "Darkbolt";
        darkbolt.magicDamage = true;
        darkbolt.effects.holyDamage = true;
        darkbolt.range = 4;


        UnitSkillDetail fear = new UnitSkillDetail();
        fear.name = "Fear";
        fear.effects.shaken = true;
        fear.range = 4;
        fear.attackPattern = "2tiles adjacent";


        UnitSkillDetail darkBlast = new UnitSkillDetail();
        darkBlast.range = 4;
        darkBlast.magicDamage = true;
        darkBlast.effects.darkDamage = true;
        darkBlast.name = "Dark Blast";
        darkBlast.attackPattern = "burst";


        UnitSkillDetail viciousness = new UnitSkillDetail();
        viciousness.name = "Viciousness";
        viciousness.support = true;
        viciousness.range = 0;
        viciousness.effects.attackBoost = true;
        viciousness.effects.darkDamage = true;


        UnitSkillDetail shadePulse = new UnitSkillDetail();
        shadePulse.name = "Shade Pulse";
        shadePulse.range = 1;
        shadePulse.effects.counter = true;
        shadePulse.effects.hitrateReduce = true;


        UnitSkillDetail feedTheNight = new UnitSkillDetail();
        feedTheNight.name = "Feed the Night";
        feedTheNight.range = 3;
        feedTheNight.extraDamageMod = 1.5f;
        feedTheNight.effects.darkDamage = true;
        feedTheNight.effects.selfDamage = true;// 1/4 damage dealt


        if (sk == endarken.name)
        {
            u.skill1 = endarken;
        }
        else if (sk == darkbolt.name)
        {
            u.skill2 = darkbolt;
        }
        else if (sk == fear.name)
        {
            u.skill3 = fear;
        }
        else if (sk == darkBlast.name)
        {
            u.skill4 = darkBlast;
        }
        else if (sk == viciousness.name)
        {
            u.skill5 = viciousness;
        }
        else if (sk == shadePulse.name)
        {
            u.skill6 = shadePulse;
        }
        else if (sk == feedTheNight.name)
        {
            u.skill7 = feedTheNight;
        }
    }
}