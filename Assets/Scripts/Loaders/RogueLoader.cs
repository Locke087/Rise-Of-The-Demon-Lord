using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
        UnitSkillDetail mug = new UnitSkillDetail();
        mug.name = "Mug";
        mug.physicalDamage = true;
        mug.range = 1;

        UnitSkillDetail knifeThrow = new UnitSkillDetail();
        knifeThrow.name = "Knife Throw";
        knifeThrow.physicalDamage = true;
        knifeThrow.range = 3;
        

        UnitSkillDetail steal = new UnitSkillDetail();
        steal.name = "Steal";
        steal.range = 1;
        steal.support = true;

        UnitSkillDetail hamstring = new UnitSkillDetail();
        hamstring.physicalDamage = true;
        hamstring.range = 1;
        hamstring.name = "Hamstring";

        UnitSkillDetail gouge = new UnitSkillDetail();
        gouge.name = "Gouge";
        gouge.range = 1;
        gouge.physicalDamage = true;
        gouge.effects.hitrateReduce = true;


        UnitSkillDetail vanish = new UnitSkillDetail();
        vanish.name = "Vanish";
        vanish.attackPattern = "Self";
        vanish.support = true;

        UnitSkillDetail sanguinarian = new UnitSkillDetail();
        sanguinarian.name = "Sanguinarian";
        sanguinarian.support = true;
        sanguinarian.effects.counter = true;

        if (sk == mug.name)
        {
            u.skill1 = mug;
        }
        else if (sk == knifeThrow.name)
        {
            u.skill2 = knifeThrow;
        }
        else if (sk == steal.name)
        {
            u.skill3 = steal;
        }
        else if (sk == hamstring.name)
        {
            u.skill4 = hamstring;
        }
        else if (sk == gouge.name)
        {
            u.skill5 = gouge;
        }
        else if (sk ==vanish.name)
        {
            u.skill6 = vanish;
        }
        else if (sk == sanguinarian.name)
        {
            u.skill7 = sanguinarian;
        }



    }
}


