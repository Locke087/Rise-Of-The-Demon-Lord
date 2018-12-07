using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavalierLoader : MonoBehaviour
{

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
        Cavalier.Clear();
        Cavalier.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level = 0;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.name = "Cavalier";
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.movement = 6;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.classWeapons.classWeapon1.type = "Spears";
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.classWeapons.classWeapon1.rank = 3;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.classWeapons.classWeapon2.type = "Axes";
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.classWeapons.classWeapon2.rank = 2;

        LevelUpClass();
    }


    public static void LevelUpClass()
    {
        Cavalier.LevelUp();
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level + 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.modifiers = Cavalier.ModList();

        foreach (string id in CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.subbed)
        {
            Unit me = new Unit();
            foreach (Unit u in CurrentGame.game.storeroom.units)
            {
                if (id == u.unitID)
                {
                    u.unitClass.main.human.cavalier.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.modifiers;
                    u.unitClass.main.human.cavalier.level = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level;
                }
            }
        }
    }

    public static void ClassUnlocked(Unit me)
    {
        me.unitClass.main.human.cavalier.unlocked = true;
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
        UnitSkillDetail trample = new UnitSkillDetail();
        trample.name = "Trample";
        trample.effects.overRun = true;
        trample.physicalDamage = true;
        trample.attackPattern = "Self";

        UnitSkillDetail joust = new UnitSkillDetail();
        joust.name = "Joust";
        joust.physicalDamage = true;
        joust.range = 1;
        joust.effects.movementDown = true;

        UnitSkillDetail lance = new UnitSkillDetail();
        lance.name = "Lance";
        lance.physicalDamage = true;
        lance.effects.extraHit = true;
        lance.range = 1;
        lance.attackPattern = "2TileLine";
        lance.physicalDamage = true;

        UnitSkillDetail protectFlanks = new UnitSkillDetail();
        protectFlanks.physicalDamage = true;
        protectFlanks.range = 1;
        protectFlanks.name = "Protect Flanks";
        protectFlanks.attackPattern = "BackAndFront";

        UnitSkillDetail vault = new UnitSkillDetail();
        vault.name = "Vault";
        vault.attackPattern = "Self";

        UnitSkillDetail hospitalier = new UnitSkillDetail();
        hospitalier.name = "Hospitalier";
        hospitalier.range = 1;
        hospitalier.attackPattern = "Self";

        UnitSkillDetail warTrainedMount = new UnitSkillDetail();
        warTrainedMount.name = "War Trained Mount";
        warTrainedMount.support = true;
        warTrainedMount.effects.counter = true;

        if (sk == trample.name)
        {
            u.skill1 = trample;
        }
        else if (sk == joust.name)
        {
            u.skill2 = joust;
        }
        else if (sk == lance.name)
        {
            u.skill3 = lance;
        }
        else if (sk == protectFlanks.name)
        {
            u.skill4 = protectFlanks;
        }
        else if (sk == vault.name)
        {
            u.skill5 = vault;
        }
        else if (sk == hospitalier.name)
        {
            u.skill6 = hospitalier;
        }
        else if (sk == warTrainedMount.name)
        {
            u.skill7 = warTrainedMount;
        }



    }
}

