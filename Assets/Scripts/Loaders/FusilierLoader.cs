using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusilierLoader : MonoBehaviour
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
        Fusilier.Clear();
        Fusilier.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.name = "Fusilier";
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.classWeapons.classWeapon1.type = "Ranged";
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.classWeapons.classWeapon1.type = "Axe";
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.classWeapons.classWeapon2.rank = 2;

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Fusilier.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level + 1;
        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.modifiers = Fusilier.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.fusilier.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.fusilier.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.modifiers;
                    u.unitClass.main.imp.fusilier.level = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.fusilier.unlocked = true;
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
        UnitSkillDetail pistolWhip = new UnitSkillDetail();
        pistolWhip.name = "Pistol-Whip";
        pistolWhip.physicalDamage = true;//magic / 2
        pistolWhip.range = 1;
        pistolWhip.effects.stun = true;


        UnitSkillDetail targeting = new UnitSkillDetail();
        targeting.name = "Targeting";
        targeting.support = true;
        targeting.effects.attackBoost = true;


        UnitSkillDetail deadEye = new UnitSkillDetail();
        deadEye.name = "Deadeye";
        deadEye.effects.critIncrease = true;
        deadEye.physicalDamage = true;
        deadEye.range = 4;


        UnitSkillDetail backBlast = new UnitSkillDetail();
        backBlast.range = 4;
        backBlast.attackPattern = "1 tile behind, 4 in front line";
        backBlast.effects.fireDamage = true;
        backBlast.magicDamage = true;//50% life
        backBlast.name = "Backblast";


        UnitSkillDetail cauterize = new UnitSkillDetail();
        cauterize.name = "Cauterize";
        cauterize.attackPattern = "self";
        cauterize.effects.selfDamage = true;
        cauterize.effects.fireDamage = true;
        cauterize.effects.statusHeal = true;


        UnitSkillDetail flashAndFire = new UnitSkillDetail();
        flashAndFire.name = "Flash and Fire";
        flashAndFire.range = 3;
        flashAndFire.attackPattern = "2x3 cone";
        flashAndFire.effects.fireDamage = true;
        flashAndFire.effects.hitReduction = true;


        UnitSkillDetail recoil = new UnitSkillDetail();
        recoil.name = "Recoil";
        recoil.support = true;
        recoil.physicalDamage = true;
        recoil.effects.counter = true;


        if (sk == pistolWhip.name)
        {
            u.skill1 = pistolWhip;
        }
        else if (sk == targeting.name)
        {
            u.skill2 = targeting;
        }
        else if (sk == deadEye.name)
        {
            u.skill3 = deadEye;
        }
        else if (sk == backBlast.name)
        {
            u.skill4 = backBlast;
        }
        else if (sk == cauterize.name)
        {
            u.skill5 = cauterize;
        }
        else if (sk == flashAndFire.name)
        {
            u.skill6 = flashAndFire;
        }
        else if (sk == recoil.name)
        {
            u.skill7 = recoil;
        }
    }
}
