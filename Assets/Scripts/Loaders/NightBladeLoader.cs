using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightBladeLoader : MonoBehaviour {

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
        Nightblade.Clear();
        Nightblade.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.name = "Nightblade";
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.classWeapons.classWeapon1.type = "Athames";
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.classWeapons.classWeapon2.type = "Close";
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.caps = Nightblade.Caplist();
        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Nightblade.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.level = CurrentGame.game.memoryGeneral.impClassProgress.nightblade.level + 1;
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.modifiers = Nightblade.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.nightblade.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.nightblade.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.nightblade.modifiers;
                    u.unitClass.main.imp.nightblade.level = CurrentGame.game.memoryGeneral.impClassProgress.nightblade.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.nightblade.unlocked = true;
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
        UnitSkillDetail vampirism = new UnitSkillDetail();
        vampirism.name = "Vampirism";
        vampirism.range = 1;
        vampirism.magicDamage = true;
        vampirism.effects.darkDamage = true;
        vampirism.restore = 1 / 4;//heal 1/4 damage dealt


        UnitSkillDetail shadowStrike = new UnitSkillDetail();
        shadowStrike.name = "Shadow Strike";
        shadowStrike.magicDamage = true;
        shadowStrike.effects.darkDamage = true;
        shadowStrike.effects.extraHit = true;
        shadowStrike.range = 1;


        UnitSkillDetail bleedingEdge = new UnitSkillDetail();
        bleedingEdge.name = "Bleeding Edge";
        bleedingEdge.effects.poison = true;
        bleedingEdge.range = 1;
        bleedingEdge.magicDamage = true;
        bleedingEdge.effects.metalDamage = true;


        UnitSkillDetail tension = new UnitSkillDetail();
        tension.range = 0;
        tension.effects.speedBoost = true;
        tension.effects.selfDamage = true;
        tension.effects.attackBoost = true;
        tension.name = "Tension";


        UnitSkillDetail shred = new UnitSkillDetail();
        shred.name = "Shred";
        shred.range = 1;
        shred.physicalDamage = true;
        shred.effects.reduceDefense = true;


        UnitSkillDetail bloodFrenzy = new UnitSkillDetail();
        bloodFrenzy.name = "Blood Frenzy";
        bloodFrenzy.range = 0;
        bloodFrenzy.effects.counter = true;
        bloodFrenzy.effects.attackBoost = true;
        bloodFrenzy.effects.hitReduction = true;


        UnitSkillDetail feedOnDeath = new UnitSkillDetail();
        feedOnDeath.name = "Feed on Death";
        feedOnDeath.range = 0;
        feedOnDeath.support = true;
        feedOnDeath.restore = 1/4;//heal 1/4 damage you deal


        if (sk == vampirism.name)
        {
            u.skill1 = vampirism;
        }
        else if (sk == shadowStrike.name)
        {
            u.skill2 = shadowStrike;
        }
        else if (sk == bleedingEdge.name)
        {
            u.skill3 = bleedingEdge;
        }
        else if (sk == tension.name)
        {
            u.skill4 = tension;
        }
        else if (sk == shred.name)
        {
            u.skill5 = shred;
        }
        else if (sk == bloodFrenzy.name)
        {
            u.skill6 = bloodFrenzy;
        }
        else if (sk == feedOnDeath.name)
        {
            u.skill7 = feedOnDeath;
        }

        else if (sk == "CloseMaster1")
        {
            un.unitInfo.weaponRanks.Close.canUse = true;
            un.unitInfo.weaponRanks.Close.rank = 3;
        }
        else if (sk == "AthameMaster1")
        {
            un.unitInfo.weaponRanks.Athames.canUse = true;
            un.unitInfo.weaponRanks.Athames.rank = 3;
        }
    }
}
