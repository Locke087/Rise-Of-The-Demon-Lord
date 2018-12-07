using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrikeLoader : MonoBehaviour {

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
        UnitSkillDetail descend = new UnitSkillDetail();
        descend.name = "Descend";
        descend.range = 0;
        descend.effects.attackBoost = true;


        UnitSkillDetail demonEyes = new UnitSkillDetail();
        demonEyes.name = "Demon Eyes";
        demonEyes.effects.shaken = true;
        demonEyes.range = 3;


        UnitSkillDetail nightfall = new UnitSkillDetail();
        nightfall.name = "Nightfall";
        nightfall.physicalDamage = true;
        nightfall.effects.hitrateReduce = true;
        nightfall.range = 4;


        UnitSkillDetail razorWings = new UnitSkillDetail();
        razorWings.range = 4;
        razorWings.magicDamage = true;
        razorWings.effects.darkDamage = true;
        razorWings.attackPattern = "2x3 cone";
        razorWings.name = "Razor Wings";


        UnitSkillDetail hackTheBlack = new UnitSkillDetail();
        hackTheBlack.name = "Hack The Black";
        hackTheBlack.range = 0;
        hackTheBlack.effects.darkDamage = true;//all attacks deal dark damage instead of physical for 3 turns
        hackTheBlack.support = true;


        UnitSkillDetail abyssalImpact = new UnitSkillDetail();
        abyssalImpact.name = "Abyssal Inheritor";
        abyssalImpact.range = 1;
        abyssalImpact.attackPattern = "melee";
        abyssalImpact.effects.darkDamage = true;
        abyssalImpact.physicalDamage = true;


        UnitSkillDetail bloodyCall = new UnitSkillDetail();
        bloodyCall.name = "Bloody Call";
        bloodyCall.support = true;
        bloodyCall.restore = 0;//heal 10% of dark damage you deal


        if (sk == descend.name)
        {
            u.skill1 = descend;
        }
        else if (sk == demonEyes.name)
        {
            u.skill2 = demonEyes;
        }
        else if (sk == nightfall.name)
        {
            u.skill3 = nightfall;
        }
        else if (sk == razorWings.name)
        {
            u.skill4 = razorWings;
        }
        else if (sk == hackTheBlack.name)
        {
            u.skill5 = hackTheBlack;
        }
        else if (sk == abyssalImpact.name)
        {
            u.skill6 = abyssalImpact;
        }
        else if (sk == bloodyCall.name)
        {
            u.skill7 = bloodyCall;
        }
    }
}