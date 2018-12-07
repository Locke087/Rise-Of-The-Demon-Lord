using System.Collections;
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

    public static void NewClass()
    {
        Priest.Clear();
        Priest.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.name = "Priest";
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.classWeapons.classWeapon1.type = "Axe";
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.classWeapons.classWeapon2.type = "Staff?";
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.classWeapons.classWeapon2.rank = 2;

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Priest.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.level = CurrentGame.game.memoryGeneral.humanClassProgress.priest.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.modifiers = Priest.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.priest.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.priest.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.priest.modifiers;
                    u.unitClass.main.human.priest.level = CurrentGame.game.memoryGeneral.humanClassProgress.priest.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.priest.unlocked = true;
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