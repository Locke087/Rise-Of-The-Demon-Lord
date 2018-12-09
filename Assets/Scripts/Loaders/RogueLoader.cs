using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueLoader : MonoBehaviour
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
        Rogue.Clear();
        Rogue.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.name = "Rogue";
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.classWeapons.classWeapon1.type = "Close";
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.classWeapons.classWeapon2.type = "Light Blades";
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.classWeapons.classWeapon2.rank = 2;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.caps = Rogue.Caplist();

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Rogue.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.modifiers = Rogue.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.rogue.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.rogue.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.modifiers;
                    u.unitClass.main.human.rogue.level = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.rogue.unlocked = true;
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
        UnitSkillDetail mug = new UnitSkillDetail();
        mug.name = "Mug";
        mug.physicalDamage = true;
        mug.range = 1;
        mug.effects.stealMoney = true;

        UnitSkillDetail knifeThrow = new UnitSkillDetail();
        knifeThrow.name = "Knife Throw";
        knifeThrow.physicalDamage = true;
        knifeThrow.range = 3;
        

        UnitSkillDetail disarm = new UnitSkillDetail();
        disarm.name = "Disarm";
        disarm.range = 1;
        disarm.physicalDamage = true;
        disarm.effects.reduceAttack = true;

        UnitSkillDetail hamstring = new UnitSkillDetail();
        hamstring.physicalDamage = true;
        hamstring.range = 1;
        hamstring.name = "Hamstring";
        hamstring.effects.movementDown = true;

        UnitSkillDetail gouge = new UnitSkillDetail();
        gouge.name = "Gouge";
        gouge.range = 1;
        gouge.physicalDamage = true;
        gouge.effects.hitrateReduce = true;


        UnitSkillDetail vanish = new UnitSkillDetail();
        vanish.name = "Vanish";
        vanish.attackPattern = "Self";
        vanish.range = 1;
        vanish.effects.invisible = true;

        UnitSkillDetail sanguinarian = new UnitSkillDetail();
        sanguinarian.name = "Sanguinarian";
        sanguinarian.range = 1;
        sanguinarian.effects.poison = true;
        sanguinarian.effects.counter = true;

        if (sk == mug.name)
        {
            u.skill1 = mug;
        }
        else if (sk == knifeThrow.name)
        {
            u.skill2 = knifeThrow;
        }
        else if (sk == disarm.name)
        {
            u.skill3 = disarm;
        }
        else if (sk == hamstring.name)
        {
            u.skill4 = hamstring;
        }
        else if (sk == gouge.name)
        {
            u.skill5 = gouge;
        }
        else if (sk ==vanish.name)
        {
            u.skill6 = vanish;
        }
        else if (sk == sanguinarian.name)
        {
            u.skill7 = sanguinarian;
        }



    }
}


