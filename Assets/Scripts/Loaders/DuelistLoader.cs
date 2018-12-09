using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelistLoader : MonoBehaviour {

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
       // Duelist.Clear();
      //  Duelist.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.name = "Duelist";
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.classWeapons.classWeapon1.type = "Light Blades";
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.classWeapons.classWeapon2.type = "Close";
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.caps = Duelist.Caplist();
        LevelUpClass();
    }


    public static void LevelUpClass()
    {
      //  Duelist.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.level = CurrentGame.game.memoryGeneral.impClassProgress.duelist.level + 1;
      //  CurrentGame.game.memoryGeneral.impClassProgress.duelist.modifiers = Duelist.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.duelist.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.duelist.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.duelist.modifiers;
                    u.unitClass.main.imp.duelist.level = CurrentGame.game.memoryGeneral.impClassProgress.duelist.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.duelist.unlocked = true;
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
        UnitSkillDetail firstBlood = new UnitSkillDetail();
        firstBlood.name = "First Blood";
        firstBlood.range = 1;
        firstBlood.physicalDamage = true;
        firstBlood.effects.shaken = true;//buff ally's weapon with dark damage


        UnitSkillDetail daggerThrow = new UnitSkillDetail();
        daggerThrow.name = "Dagger Throw";
        daggerThrow.magicDamage = true;
        daggerThrow.effects.movementDown = true;
        daggerThrow.range = 4;


        UnitSkillDetail pommelBash = new UnitSkillDetail();
        pommelBash.name = "Pommel Bash";
        pommelBash.effects.confuse = true;
        pommelBash.range = 1;
        pommelBash.physicalDamage = true;


        UnitSkillDetail pierceDefenses = new UnitSkillDetail();
        pierceDefenses.range = 1;
        pierceDefenses.physicalDamage = true;
        pierceDefenses.effects.reduceDefense = true;
        pierceDefenses.name = "Pierce Defenses";


        UnitSkillDetail blitz = new UnitSkillDetail();
        blitz.name = "Blitz";
        blitz.range = 1;
        blitz.physicalDamage = true;
        blitz.effects.extraHit = true;


        UnitSkillDetail riposte = new UnitSkillDetail();
        riposte.name = "Riposte";
        riposte.range = 0;
        riposte.effects.counter = true;
        riposte.effects.dodge = true;


        UnitSkillDetail mainGauche = new UnitSkillDetail();
        mainGauche.name = "Feed the Night";
        mainGauche.range = 0;
        mainGauche.support = true;
        mainGauche.effects.damageReduction = true;//reduce damage using second weapons might


        if (sk == firstBlood.name)
        {
            u.skill1 = firstBlood;
        }
        else if (sk == daggerThrow.name)
        {
            u.skill2 = daggerThrow;
        }
        else if (sk == pommelBash.name)
        {
            u.skill3 = pommelBash;
        }
        else if (sk == pierceDefenses.name)
        {
            u.skill4 = pierceDefenses;
        }
        else if (sk == blitz.name)
        {
            u.skill5 = blitz;
        }
        else if (sk == riposte.name)
        {
            u.skill6 = riposte;
        }
        else if (sk == mainGauche.name)
        {
            u.skill7 = mainGauche;
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





