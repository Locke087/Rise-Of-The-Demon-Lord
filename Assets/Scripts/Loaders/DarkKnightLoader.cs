using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkKnightLoader : MonoBehaviour {

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
        DarkKnight.Clear();
        DarkKnight.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.name = "Dark Knight";
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.classWeapons.classWeapon1.type = "Heavy Blades";
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.classWeapons.classWeapon2.type = "Axes";
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.caps = DarkKnight.Caplist();
        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        DarkKnight.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level + 1;
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.modifiers = DarkKnight.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.darkknight.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.darkknight.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.modifiers;
                    u.unitClass.main.imp.darkknight.level = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.darkknight.unlocked = true;
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
        UnitSkillDetail darkness = new UnitSkillDetail();
        darkness.name = "Darkness";
        darkness.range = 4;
        darkness.magicDamage = true;
        darkness.effects.darkDamage = true;
        darkness.effects.hitrateReduce = true;
        darkness.attackPattern = "cross";


        UnitSkillDetail darkrift = new UnitSkillDetail();
        darkrift.name = "Darkrift";
        darkrift.magicDamage = true;
        darkrift.effects.darkDamage = true;
        darkrift.effects.shaken = true;
        darkrift.range = 4;
        darkrift.attackPattern = "4 tile line";


        UnitSkillDetail crushingDarkness = new UnitSkillDetail();
        crushingDarkness.name = "Crushing Darkness";
        crushingDarkness.effects.fourth = true;
        crushingDarkness.range = 4;


        UnitSkillDetail sacrificialBlade = new UnitSkillDetail();
        sacrificialBlade.range = 1;
        sacrificialBlade.effects.selfDamage = true;//take 1/4 damage dealt
        sacrificialBlade.magicDamage = true;
        sacrificialBlade.effects.darkDamage = true;
        sacrificialBlade.extraDamageMod = 1.2f;
        sacrificialBlade.name = "Sacrificial Blade";


        UnitSkillDetail demonArmor = new UnitSkillDetail();
        demonArmor.name = "Demon Armor";
        demonArmor.range = 0;
        demonArmor.effects.selfDamage = true;
        demonArmor.effects.damageReduction = true;//decrease all damage taken for 3 turns


        UnitSkillDetail growingDarkness = new UnitSkillDetail();
        growingDarkness.name = "Growing Darkness";
        growingDarkness.range = 0;
        growingDarkness.effects.counter = true;
        growingDarkness.magicDamage = true;
        growingDarkness.effects.darkDamage = true;


        UnitSkillDetail resurgence = new UnitSkillDetail();
        resurgence.name = "Resurgence";
        resurgence.range = 0;
        resurgence.restore = 1 / 4;//heal 1/4 health


        if (sk == darkness.name)
        {
            u.skill1 = darkness;
        }
        else if (sk == darkrift.name)
        {
            u.skill2 = darkrift;
        }
        else if (sk == crushingDarkness.name)
        {
            u.skill3 = crushingDarkness;
        }
        else if (sk == sacrificialBlade.name)
        {
            u.skill4 = sacrificialBlade;
        }
        else if (sk == demonArmor.name)
        {
            u.skill5 = demonArmor;
        }
        else if (sk == growingDarkness.name)
        {
            u.skill6 = growingDarkness;
        }
        else if (sk == resurgence.name)
        {
            u.skill7 = resurgence;
        }

        else if (sk == "HeavyBladesMaster1")
        {
            un.unitInfo.weaponRanks.HeavyBlades.canUse = true;
            un.unitInfo.weaponRanks.HeavyBlades.rank = 3;
        }
        else if (sk == "AxesMaster1")
        {
            un.unitInfo.weaponRanks.Axes.canUse = true;
            un.unitInfo.weaponRanks.Axes.rank = 3;
        }
    }
}
}
