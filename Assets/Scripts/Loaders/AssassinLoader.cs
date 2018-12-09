using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssassinLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void NewClass()
    {
        Assassin.Clear();
        Assassin.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.name = "Assassin";
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.classWeapons.classWeapon1.type = "Light Blades";
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.classWeapons.classWeapon2.type = "Close";
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.caps = Assassin.Caplist();
        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Assassin.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.modifiers = Assassin.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.assassin.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.assassin.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.modifiers;
                    u.unitClass.main.human.assassin.level = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.assassin.unlocked = true;
    }

    public static int HowManySkills(UnitClassSkill u)
    {
        int i = 0;

        if (u.skill1.name != "")
        {
            i++;
        }
        if (u.skill2.name != "")
        {
            i++;
        }
        if (u.skill3.name != "")
        {
            i++;
        }
        if (u.skill4.name != "")
        {
            i++;
        }
        if (u.skill5.name != "")
        {
            i++;
        }
        if (u.skill6.name != "")
        {
            i++;
        }
        if (u.skill7.name != "")
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
        UnitSkillDetail kidneyShot = new UnitSkillDetail();
        kidneyShot.name = "Kidney Shot";
        kidneyShot.effects.stun = true;
        kidneyShot.physicalDamage = true;
        kidneyShot.range = 4;

        UnitSkillDetail assassination = new UnitSkillDetail();
        assassination.name = "Assassination";
        assassination.effects.kill = true;
        assassination.range = 1;

        UnitSkillDetail twinFangs = new UnitSkillDetail();
        twinFangs.name = "Twin Fangs";
        twinFangs.effects.extraHit = true;
        twinFangs.range = 1;

        UnitSkillDetail envenom = new UnitSkillDetail();
        envenom.physicalDamage = true;
        envenom.range = 1;
        envenom.effects.poison = true;
        envenom.name = "Envenom";


        UnitSkillDetail rupture = new UnitSkillDetail();
        rupture.name = "Rupture";
        rupture.extraDamageMod = 1.2f;//if target is suffering a debuff, deal extra damage
        rupture.physicalDamage = true;//Use Def instead of Str for counter


        UnitSkillDetail blackjack = new UnitSkillDetail();
        blackjack.name = "Blackjack";
        blackjack.range = 1;
        blackjack.effects.confuse = true;
        blackjack.physicalDamage = true;

        UnitSkillDetail bloodyJake = new UnitSkillDetail();
        bloodyJake.name = "Bloody Jake";
        bloodyJake.support = true;
        bloodyJake.effects.increaseDebuffs = true;//increase debuff duration

        if (sk == kidneyShot.name)
        {
            u.skill1 = kidneyShot;
        }
        else if (sk == assassination.name)
        {
            u.skill2 = assassination;
        }
        else if (sk == twinFangs.name)
        {
            u.skill3 = twinFangs;
        }
        else if (sk == envenom.name)
        {
            u.skill4 = envenom;
        }
        else if (sk == rupture.name)
        {
            u.skill5 = rupture;
        }
        else if (sk == blackjack.name)
        {
            u.skill6 = blackjack;
        }
        else if (sk == bloodyJake.name)
        {
            u.skill7 = bloodyJake;
        }
        else if (sk == "CloseMaster1")
        {
            un.unitInfo.weaponRanks.Close.canUse = true;
            un.unitInfo.weaponRanks.Close.rank = 3;
        }
        else if (sk == "LightBladesMaster1")
        {
            un.unitInfo.weaponRanks.LightBlades.canUse = true;
            un.unitInfo.weaponRanks.LightBlades.rank = 3;
        }

    }


}

