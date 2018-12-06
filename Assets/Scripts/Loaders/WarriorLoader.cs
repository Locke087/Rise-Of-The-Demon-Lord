using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void NewWarriorClass()
    {
        Warrior.Clear();
        Warrior.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.name = "Warrior";
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.classWeapons.classWeapon1.type = "HeavyBlade";
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.classWeapons.classWeapon2.type = "Axe";
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.classWeapons.classWeapon2.rank = 2;

        LevelUpClass();
    }
 

    public static void LevelUpClass()
    {
        Warrior.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.modifiers = Warrior.ModList();

        foreach(string id in CurrentGame.game.memoryGeneral.humanClassProgress.warrior.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID) {
                    u.unitClass.main.human.warrior.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.modifiers;
                    u.unitClass.main.human.warrior.level = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.warrior.unlocked = true;
    }

 
    public static void AssignSkill(string sk, UnitClassSkill u)
    {
        UnitSkillDetail focused = new UnitSkillDetail();
        focused.name = "Focused";
        focused.effects.attackBoost = true;
        focused.support = true;
        focused.attackPattern = "SupportTile";
        focused.range = 0;

        UnitSkillDetail wildStrike = new UnitSkillDetail();
        wildStrike.name = "Wild Strike";
        wildStrike.physicalDamage = true;
        wildStrike.attackPattern = "BackAndFront";

        UnitSkillDetail bullrush = new UnitSkillDetail();
        bullrush.name = "Bull Rush";
        bullrush.physicalDamage = true;
        bullrush.effects.damageReduction = true;
        bullrush.effects.knockBack = true;
        bullrush.range = 1;

        UnitSkillDetail doubleEdged = new UnitSkillDetail();
        doubleEdged.physicalDamage = true;
        doubleEdged.range = 1;
        doubleEdged.extraDamageMod = 1.2f;
        doubleEdged.name = "Double Edged";
        doubleEdged.effects.selfDamage = true;

        UnitSkillDetail blitz = new UnitSkillDetail();
        blitz.name = "Blitz";
        blitz.range = 1;
        blitz.physicalDamage = true;
        blitz.effects.extraHit = true;
        blitz.effects.hitrateReduce = true;


        UnitSkillDetail lunge = new UnitSkillDetail();
        lunge.name = "Lunge";
        lunge.range = 1;
        lunge.attackPattern = "LineVert";
        lunge.physicalDamage = true;

        UnitSkillDetail counter = new UnitSkillDetail();
        counter.name = "Counter";
        counter.support = true;
        counter.effects.counter = true;

        if (sk == focused.name)
        {
            u.skill1 = focused;
        }
        else if (sk == wildStrike.name)
        {
            u.skill2 = wildStrike;
        }
        else if (sk == bullrush.name)
        {
            u.skill3 = bullrush;
        }
        else if (sk == doubleEdged.name)
        {
            u.skill4 = doubleEdged;
        }
        else if (sk == blitz.name)
        {
            u.skill5 = blitz;
        }
        else if (sk == lunge.name)
        {
            u.skill6 = lunge;
        }
        else if (sk == counter.name)
        {
            u.skill7 = counter;
        }



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
}
