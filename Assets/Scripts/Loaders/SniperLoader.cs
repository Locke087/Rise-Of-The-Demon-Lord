using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void NewClass()
    {
        Sniper.Clear();
        Sniper.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.name = "Sniper";
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.classWeapons.classWeapon1.type = "Ranged";
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.classWeapons.classWeapon2.type = "Close";
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.caps = Sniper.Caplist();

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Sniper.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.modifiers = Sniper.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.sniper.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.sniper.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.modifiers;
                    u.unitClass.main.human.sniper.level = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.sniper.unlocked = true;
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

    public static void AssignSkill(string sk, UnitClassSkill u, Unit un)
    {
        UnitSkillDetail eyeline = new UnitSkillDetail();
        eyeline.name = "Eyeline";
        eyeline.effects.hitrateReduce = true;
        eyeline.range = 5;

        UnitSkillDetail enfiliade = new UnitSkillDetail();
        enfiliade.name = "Enfilade";
        enfiliade.physicalDamage = true;
        enfiliade.attackPattern = "3x3cone";

        UnitSkillDetail hailOfArrows = new UnitSkillDetail();
        hailOfArrows.name = "Hail of Arrows";
        hailOfArrows.physicalDamage = true;
        hailOfArrows.range = 4;
        hailOfArrows.attackPattern = "cross";

        UnitSkillDetail fullDraw = new UnitSkillDetail();
        fullDraw.physicalDamage = true;
        fullDraw.range = 7;
        fullDraw.effects.hitReduction = true;
        fullDraw.name = "Full Draw";


        UnitSkillDetail counterfire = new UnitSkillDetail();
        counterfire.name = "Counterfire";
        counterfire.effects.counter = true;//return fire when recieving ranged attack
        counterfire.support = true;
        counterfire.physicalDamage = true;


        UnitSkillDetail overDraw = new UnitSkillDetail();
        overDraw.name = "Over Draw";
        overDraw.range = 5;
        overDraw.extraDamageMod = 1.2f;
        overDraw.physicalDamage = true;

        UnitSkillDetail eagleEye = new UnitSkillDetail();
        eagleEye.name = "Eagle Eye";
        eagleEye.support = true;
        eagleEye.effects.increaseAccuracy = true;//+def, -move

        if (sk == eyeline.name)
        {
            u.skill1 = eyeline;
        }
        else if (sk == enfiliade.name)
        {
            u.skill2 = enfiliade;
        }
        else if (sk == hailOfArrows.name)
        {
            u.skill3 = hailOfArrows;
        }
        else if (sk == fullDraw.name)
        {
            u.skill4 = fullDraw;
        }
        else if (sk == counterfire.name)
        {
            u.skill5 = counterfire;
        }
        else if (sk == overDraw.name)
        {
            u.skill6 = overDraw;
        }
        else if (sk == eagleEye.name)
        {
            u.skill7 = eagleEye;
        }
        else if (sk == "RangedMaster1")
        {
            un.unitInfo.weaponRanks.Ranged.canUse = true;
            un.unitInfo.weaponRanks.Ranged.rank = 3;
            un.unitInfo.weaponRanks.Close.canUse = true;
            un.unitInfo.weaponRanks.Close.rank = 3;
        }
        else if (sk == "CloseMaster1")
        {
            un.unitInfo.weaponRanks.Close.canUse = true;
            un.unitInfo.weaponRanks.Close.rank = 3;
        }

    }


}

