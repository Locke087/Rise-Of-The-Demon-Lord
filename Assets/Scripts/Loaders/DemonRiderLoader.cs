using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonRiderLoader : MonoBehaviour {

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
       // DemonRider.Clear();
       // DemonRider.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level = 0;
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.name = "Demon Rider";
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement = 5;
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.classWeapons.classWeapon1.type = "Light Blades";
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.classWeapons.classWeapon2.type = "Close";
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.classWeapons.classWeapon2.rank = 3;
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.caps = DemonRider.Caplist();
        LevelUpClass();
    }


    public static void LevelUpClass()
    {
      //  DemonRider.LevelUp();
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level + 1;
       // CurrentGame.game.memoryGeneral.impClassProgress.demonRider.modifiers = DemonRider.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.impClassProgress.demonRider.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.imp.demonRider.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.modifiers;
                    u.unitClass.main.imp.demonRider.level = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.imp.demonRider.unlocked = true;
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
        UnitSkillDetail possess = new UnitSkillDetail();
        possess.name = "Possess";
        possess.range = 4;
        possess.effects.absorbDamage = true;//for 1 turn, target takes half the damage you do


        UnitSkillDetail invidious = new UnitSkillDetail();
        invidious.name = "Invidious";
        invidious.magicDamage = true;
        invidious.effects.darkDamage = true;
        invidious.effects.shaken = true;
        invidious.range = 1;


        UnitSkillDetail hellBlade = new UnitSkillDetail();
        hellBlade.name = "Hell Blade";
        hellBlade.effects.fireDamage = true;//deals half fire, half dark
        hellBlade.effects.darkDamage = true;
        hellBlade.effects.stun = true;
        hellBlade.range = 1;
        hellBlade.magicDamage = true;


        UnitSkillDetail callTheDarkSpirits = new UnitSkillDetail();
        callTheDarkSpirits.range = 4;
        callTheDarkSpirits.physicalDamage = true;
        callTheDarkSpirits.effects.shaken = true;
        callTheDarkSpirits.effects.confuse = true;
        callTheDarkSpirits.name = "Call to Dark Spirits";
        callTheDarkSpirits.attackPattern = "cross";


        UnitSkillDetail blackSword = new UnitSkillDetail();
        blackSword.name = "Black Sword";
        blackSword.range = 1;
        blackSword.magicDamage = true;
        blackSword.effects.metalDamage = true;


        UnitSkillDetail darkProtection = new UnitSkillDetail();
        darkProtection.name = "Dark Protection";
        darkProtection.range = 0;
        darkProtection.effects.selfDamage = true;
        darkProtection.effects.defenseBoost = true;
        darkProtection.effects.magicDefenseBoost = true;


        UnitSkillDetail evilThoughts = new UnitSkillDetail();
        evilThoughts.name = "Evil Thoughts";
        evilThoughts.range = 0;
        evilThoughts.support = true;
        evilThoughts.effects.magicBoost = true;//reduce damage using second weapons might
        evilThoughts.effects.increaseDebuffs = true;

        if (sk == possess.name)
        {
            u.skill1 = possess;
        }
        else if (sk == invidious.name)
        {
            u.skill2 = invidious;
        }
        else if (sk == hellBlade.name)
        {
            u.skill3 = hellBlade;
        }
        else if (sk == callTheDarkSpirits.name)
        {
            u.skill4 = callTheDarkSpirits;
        }
        else if (sk == blackSword.name)
        {
            u.skill5 = blackSword;
        }
        else if (sk == darkProtection.name)
        {
            u.skill6 = darkProtection;
        }
        else if (sk == evilThoughts.name)
        {
            u.skill7 = evilThoughts;
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
