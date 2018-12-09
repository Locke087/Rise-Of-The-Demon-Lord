using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void NewClass()
    {
        Paladin.Clear();
        Paladin.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.name = "Paladin";
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.movement = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.classWeapons.classWeapon1.type = "Heavy Blades";
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.classWeapons.classWeapon2.type = "Staves";
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.caps = Paladin.Caplist();

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Paladin.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.modifiers = Paladin.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.paladin.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.paladin.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.modifiers;
                    u.unitClass.main.human.paladin.level = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.paladin.unlocked = true;
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
        UnitSkillDetail cover = new UnitSkillDetail();
        cover.name = "Cover";//take damage for adjacent enemy for 1 turn
        cover.effects.absorbDamage = true;
        cover.range = 1;

        UnitSkillDetail judgement = new UnitSkillDetail();
        judgement.name = "Judgement";
        judgement.effects.holyDamage = true;
        judgement.range = 4;

        UnitSkillDetail holyAura = new UnitSkillDetail();
        holyAura.name = "Holy Aura";
        holyAura.effects.counter = true;//heal 1/4 magic stat to adjacent units
        holyAura.attackPattern = "cross";
        holyAura.range = 1;

        UnitSkillDetail mercy = new UnitSkillDetail();
        mercy.restore = 1;//heal magic stat to adjacent ally
        mercy.range = 1;
        mercy.effects.statusHeal = true;
        mercy.name = "Mercy";


        UnitSkillDetail divineStrike = new UnitSkillDetail();
        divineStrike.name = "Divine Strike";
        divineStrike.extraDamageMod = 1.2f;//if target is suffering a debuff, deal extra damage
        divineStrike.physicalDamage = true;//Use Def instead of Str for counter
        divineStrike.effects.holyDamage = true;

        UnitSkillDetail mightOfHeaven = new UnitSkillDetail();
        mightOfHeaven.name = "Might of Heaven";
        mightOfHeaven.range = 0;
        mightOfHeaven.effects.defenseBoost = true;
        mightOfHeaven.effects.magicDefenseBoost = true;
        mightOfHeaven.effects.magicBoost = true;

        UnitSkillDetail heavensSteps = new UnitSkillDetail();
        heavensSteps.name = "Heavens Steps";
        heavensSteps.support = true;
        heavensSteps.effects.movementIncrease = true;//increase debuff duration

        if (sk == cover.name)
        {
            u.skill1 = cover;
        }
        else if (sk == judgement.name)
        {
            u.skill2 = judgement;
        }
        else if (sk == holyAura.name)
        {
            u.skill3 = holyAura;
        }
        else if (sk == mercy.name)
        {
            u.skill4 = mercy;
        }
        else if (sk == divineStrike.name)
        {
            u.skill5 = divineStrike;
        }
        else if (sk == mightOfHeaven.name)
        {
            u.skill6 = mightOfHeaven;
        }
        else if (sk == heavensSteps.name)
        {
            u.skill7 = heavensSteps;
        }
        else if (sk == "HeavyBladesMaster1")
        {
            un.unitInfo.weaponRanks.HeavyBlade.canUse = true;
            un.unitInfo.weaponRanks.HeavyBlade.rank = 3;
        }
        else if (sk == "StavesMaster1")
        {
            un.unitInfo.weaponRanks.Stave.canUse = true;
            un.unitInfo.weaponRanks.Stave.rank = 3;
        }

    }


}


