using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargerLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void NewClass()
    {
        Charger.Clear();
        Charger.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.name = "Charger";
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.classWeapons.classWeapon1.type = "Heavy Blades";
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.classWeapons.classWeapon2.type = "Spears";
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.classWeapons.classWeapon2.rank = 3;

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Charger.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.level = CurrentGame.game.memoryGeneral.humanClassProgress.charger.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.modifiers = Charger.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.assassin.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.charger.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.charger.modifiers;
                    u.unitClass.main.human.charger.level = CurrentGame.game.memoryGeneral.humanClassProgress.charger.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.charger.unlocked = true;
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
        UnitSkillDetail spearThrust = new UnitSkillDetail();
        spearThrust.name = "Spear Thrust";
        spearThrust.attackPattern = "2-tile line";
        spearThrust.physicalDamage = true;
        spearThrust.range = 2;

        UnitSkillDetail hammerAndNail = new UnitSkillDetail();
        hammerAndNail.name = "Hammer and Nail";
        hammerAndNail.physicalDamage = true;
        hammerAndNail.range = 1;
        hammerAndNail.attackPattern = "1 tile front and back";

        UnitSkillDetail pierceDefenses = new UnitSkillDetail();
        pierceDefenses.name = "Pierce Defenses";
        pierceDefenses.effects.reduceDefense = true;
        pierceDefenses.physicalDamage = true;
        pierceDefenses.range = 1;

        UnitSkillDetail hurl = new UnitSkillDetail();
        hurl.physicalDamage = true;
        hurl.range = 4;
        hurl.attackPattern = "4 tile line";
        hurl.name = "Hurl";


        UnitSkillDetail helmCleaver = new UnitSkillDetail();
        helmCleaver.name = "Helm Cleaver";
        helmCleaver.extraDamageMod = 1.2f;
        helmCleaver.physicalDamage = true;
        helmCleaver.effects.confuse = true;


        UnitSkillDetail charge = new UnitSkillDetail();
        charge.name = "Charge!";
        charge.range = 5;//rush an enemy and blow them back
        charge.effects.knockBack = true;
        charge.physicalDamage = true;

        UnitSkillDetail ringTheBell = new UnitSkillDetail();
        ringTheBell.name = "Ring the Bell";
        ringTheBell.effects.counter = true;
        ringTheBell.effects.movementDown = true;//increase debuff duration

        if (sk == spearThrust.name)
        {
            u.skill1 = spearThrust;
        }
        else if (sk == hammerAndNail.name)
        {
            u.skill2 = hammerAndNail;
        }
        else if (sk == pierceDefenses.name)
        {
            u.skill3 = pierceDefenses;
        }
        else if (sk == hurl.name)
        {
            u.skill4 = hurl;
        }
        else if (sk == helmCleaver.name)
        {
            u.skill5 = helmCleaver;
        }
        else if (sk == charge.name)
        {
            u.skill6 = charge;
        }
        else if (sk == ringTheBell.name)
        {
            u.skill7 = ringTheBell;
        }
        else if (sk == "HeavyBladesMaster1")
        {
            un.unitInfo.weaponRanks.HeavyBlade.canUse = true;
            un.unitInfo.weaponRanks.HeavyBlade.rank = 3;
        }
        else if (sk == "SpearMaster1")
        {
            un.unitInfo.weaponRanks.Spear.canUse = true;
            un.unitInfo.weaponRanks.Spear.rank = 3;
        }

    }


}
