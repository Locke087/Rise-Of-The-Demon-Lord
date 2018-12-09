using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannoneerLoader : MonoBehaviour {

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
        Cannoneer.Clear();
        Cannoneer.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.name = "Cannoneer";
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.classWeapons.classWeapon1.type = "Ranged";
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.classWeapons.classWeapon2.type = "Close";
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.caps = Cannoneer.Caplist();
        LevelUpClass();
    }


    public static void LevelUpClass()
    {
       // Cannoneer.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level + 1;
       // CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.modifiers = Cannoneer.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.cannoneer.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.modifiers;
                    u.unitClass.main.imp.cannoneer.level = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.cannoneer.unlocked = true;
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
        UnitSkillDetail lightItUp = new UnitSkillDetail();
        lightItUp.name = "Light it Up!";
        lightItUp.range = 1;
        lightItUp.magicDamage = true;
        lightItUp.effects.fireDamage = true;//deal fire damage to foe


        UnitSkillDetail kaboom = new UnitSkillDetail();
        kaboom.name = "Kaboom";
        kaboom.magicDamage = true;
        kaboom.effects.fireDamage = true;
        kaboom.effects.knockBack = true;
        kaboom.range = 4;
        kaboom.attackPattern = "cross";


        UnitSkillDetail chainshot = new UnitSkillDetail();
        chainshot.name = "Chainshot";
        chainshot.effects.movementDown = true;
        chainshot.range = 5;
        chainshot.physicalDamage = true;


        UnitSkillDetail breachBlast = new UnitSkillDetail();
        breachBlast.range = 2;
        breachBlast.attackPattern = "2 tile cross";
        breachBlast.physicalDamage = true;//deal half physical, half fire damage to surrounding foes and self
        breachBlast.effects.fireDamage = true;
        breachBlast.effects.selfDamage = true;
        breachBlast.name = "Breach Blast";


        UnitSkillDetail blowTheGates = new UnitSkillDetail();
        blowTheGates.name = "Blow the Gates";
        blowTheGates.range = 4;
        blowTheGates.attackPattern = "4 tile line";
        blowTheGates.magicDamage = true;
        blowTheGates.effects.metalDamage = true;


        UnitSkillDetail cannonSwing = new UnitSkillDetail();
        cannonSwing.name = "Cannon Swing";
        cannonSwing.range = 1;
        cannonSwing.effects.metalDamage = true;
        cannonSwing.magicDamage = true;
        cannonSwing.effects.counter = true;
        cannonSwing.effects.knockBack = true;


        UnitSkillDetail flechette = new UnitSkillDetail();
        flechette.name = "Flechette";
        flechette.range = 3;
        flechette.attackPattern = "3x3 tile cone";
        flechette.effects.reduceDefense = true;//reduce enemy defense


        if (sk == lightItUp.name)
        {
            u.skill1 = lightItUp;
        }
        else if (sk == kaboom.name)
        {
            u.skill2 = kaboom;
        }
        else if (sk == chainshot.name)
        {
            u.skill3 = chainshot;
        }
        else if (sk == breachBlast.name)
        {
            u.skill4 = breachBlast;
        }
        else if (sk == blowTheGates.name)
        {
            u.skill5 = blowTheGates;
        }
        else if (sk == cannonSwing.name)
        {
            u.skill6 = cannonSwing;
        }
        else if (sk == flechette.name)
        {
            u.skill7 = flechette;
        }

        else if (sk == "CloseMaster1")
        {
            un.unitInfo.weaponRanks.Close.canUse = true;
            un.unitInfo.weaponRanks.Close.rank = 3;
        }
        else if (sk == "RangedMaster1")
        {
            un.unitInfo.weaponRanks.LightBlades.canUse = true;
            un.unitInfo.weaponRanks.LightBlades.rank = 3;
        }
    }
}
