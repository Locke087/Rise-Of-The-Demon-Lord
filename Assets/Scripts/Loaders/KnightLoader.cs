using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void NewClass()
    {
        Knight.Clear();
        Knight.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.name = "Knight";
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.movement = 5;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.classWeapons.classWeapon1.type = "HeavyBlade";
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.classWeapons.classWeapon2.type = "Axe";
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.caps = Knight.Caplist();

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Knight.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.level = CurrentGame.game.memoryGeneral.humanClassProgress.knight.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.modifiers = Knight.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.knight.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.knight.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.knight.modifiers;
                    u.unitClass.main.human.knight.level = CurrentGame.game.memoryGeneral.humanClassProgress.knight.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.knight.unlocked = true;
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
        UnitSkillDetail knightsChallenge = new UnitSkillDetail();
        knightsChallenge.name = "Knight's Challenge";
        knightsChallenge.effects.attackBoost = true;
        knightsChallenge.attackPattern = "SupportTile";
        knightsChallenge.range = 4;

        UnitSkillDetail shieldBash = new UnitSkillDetail();
        shieldBash.name = "Shield Bash";
        shieldBash.physicalDamage = true;
        shieldBash.effects.stun = true;
        shieldBash.range = 1;

        UnitSkillDetail guard = new UnitSkillDetail();
        guard.name = "Guard";
        guard.effects.damageReduction = true;
        guard.range = 0;

        UnitSkillDetail blackSwordStrike = new UnitSkillDetail();
        blackSwordStrike.physicalDamage = true;
        blackSwordStrike.range = 1;
        blackSwordStrike.extraDamageMod = 1.2f;
        blackSwordStrike.name = "Black Sword Strike";


        UnitSkillDetail spikedArmor = new UnitSkillDetail();
        spikedArmor.name = "Spiked Armor";
        spikedArmor.effects.counter = true;
        spikedArmor.physicalDamage = true;//Use Def instead of Str for counter


        UnitSkillDetail pommelStrike = new UnitSkillDetail();
        pommelStrike.name = "Pommel Strike";
        pommelStrike.range = 1;
        pommelStrike.effects.confuse = true;
        pommelStrike.physicalDamage = true;

        UnitSkillDetail heavy = new UnitSkillDetail();
        heavy.name = "Heavy";
        heavy.support = true;
        heavy.effects.defenseBoost = true;//+def, -move

        if (sk == knightsChallenge.name)
        {
            u.skill1 = knightsChallenge;
        }
        else if (sk == shieldBash.name)
        {
            u.skill2 = shieldBash;
        }
        else if (sk == guard.name)
        {
            u.skill3 = guard;
        }
        else if (sk == blackSwordStrike.name)
        {
            u.skill4 = blackSwordStrike;
        }
        else if (sk == spikedArmor.name)
        {
            u.skill5 = spikedArmor;
        }
        else if (sk == pommelStrike.name)
        {
            u.skill6 = pommelStrike;
        }
        else if (sk == heavy.name)
        {
            u.skill7 = heavy;
        }
        else if (sk == "SwordMaster1")
        {
            un.unitInfo.weaponRanks.HeavyBlade.canUse = true;
            un.unitInfo.weaponRanks.HeavyBlade.rank = 3;
        }
        else if (sk == "AxeMaster1")
        {
            un.unitInfo.weaponRanks.Axe.canUse = true;
            un.unitInfo.weaponRanks.Axe.rank = 3;
        }

    }


}
