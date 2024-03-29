﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swashbuckler : MonoBehaviour {

    /* public static int strStatIncrease = 0;
               public static int defStatIncrease = 0;
               public static int skillStatIncrease = 0;
               public static int spdStatIncrease = 0;
               public static int magicStatIncrease = 0;
               public static int willStatIncrease = 0;
               public static int strAmount = 0;
               public static int defAmount = 0;
               public static int skillAmount = 0;
               public static int spdAmount = 0;
               public static int magicAmount = 0;
               public static int willAmount = 0;*/
    public static float increaseStr = 0;
    public static float increaseDef = 0;
    public static float increaseSkill = 0;
    public static float increaseSpd = 0;
    public static float increaseMagic = 0;
    public static float increaseWill = 0;


    public static float baseStrModifer = 3;
    public static float baseDefModifer = 2.5f;
    public static float baseSkillModifer = 3;
    public static float baseSpdModifer = 2.5f;
    public static float baseMagicModifer = 2.5f;
    public static float baseWillModifer = 2;
    public static float strModifer = 3;
    public static float defModifer = 2.5f;
    public static float skillModifer = 3;
    public static float spdModifer = 2.5f;
    public static float magicModifer = 2.5f;
    public static float willModifer = 2;
    public static float strCap = 25;
    public static float defCap = 20;
    public static float skillCap = 25;
    public static float spdCap = 20;
    public static float magicCap = 18;
    public static float willCap = 10;
    public static float hpCap = 30;

    public static int level = 0;
    public static int move = 4;
    public static int baseHp = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public static void LevelUp()
    {
        level = level + 1;
        IncreaseStats();

    }

    /*public static List<int> IncList()
    {
        List<int> newList = new List<int>();
        newList.Add(strStatIncrease);
        newList.Add(defStatIncrease);
        newList.Add(spdStatIncrease);
        newList.Add(skillStatIncrease);
        newList.Add(magicStatIncrease);
        newList.Add(willStatIncrease);
        return newList;
    }*/
    public static void Clear()
    {
        increaseStr = 0;
        increaseDef = 0;
        increaseSkill = 0;
        increaseSpd = 0;
        increaseMagic = 0;
        increaseWill = 0;
        strModifer = 3;
        defModifer = 2.5f;
        skillModifer = 3;
        spdModifer = 2.5f;
        magicModifer = 2.5f;
        willModifer = 2;
        level = 0;
        move = 6;
        baseHp = 14;
    }

    public static List<float> Caplist()
    {
        List<float> newList = new List<float>();
        newList.Add(strCap);
        newList.Add(defCap);
        newList.Add(spdCap);
        newList.Add(skillCap);
        newList.Add(magicCap);
        newList.Add(willCap);
        newList.Add(hpCap);
        return newList;
    }

    public static List<float> ModList()
    {
        List<float> newList = new List<float>();
        newList.Add(strModifer);
        newList.Add(defModifer);
        newList.Add(spdModifer);
        newList.Add(skillModifer);
        newList.Add(magicModifer);
        newList.Add(willModifer);
        return newList;
    }

    public static void IncreaseStats()
    {
        /*  increaseStr = (Mathf.Round(level / baseStrModifer) * .1f) + 1;
          increaseDef = (Mathf.Round(level / baseDefModifer) * .1f) + 1;
          increaseSkill = (Mathf.Round(level / baseSkillModifer) * .1f) + 1;
          increaseSpd = (Mathf.Round(level / baseSpdModifer) * .1f) + 1;
          increaseMagic = (Mathf.Round(level / baseMagicModifer) * .1f) + 1;
          increaseWill = (Mathf.Round(level / baseWillModifer) * .1f) + 1;*/

        increaseStr = baseStrModifer + (Mathf.Round(level / baseStrModifer) * .1f) + 1;
        increaseDef = baseDefModifer + (Mathf.Round(level / baseDefModifer) * .1f) + 1;
        increaseSkill = baseDefModifer + (Mathf.Round(level / baseSkillModifer) * .1f) + 1;
        increaseSpd = baseSpdModifer + (Mathf.Round(level / baseSpdModifer) * .1f) + 1;
        increaseMagic = baseMagicModifer + (Mathf.Round(level / baseMagicModifer) * .1f) + 1;
        increaseWill = baseWillModifer + (Mathf.Round(level / baseWillModifer) * .1f) + 1;


        StrIncrease();
        DefIncrease();
        SkillIncrease();
        SpdIncrease();
        MagicIncrease();
        WillIncrease();

        /*strAmount = (int)(1 * increaseStr);
        defAmount = (int)(1 * increaseDef);
        skillAmount = (int)(1 * increaseSkill);
        spdAmount = (int)(1 * increaseWill);
        magicAmount = (int)(1 * increaseMagic);
        willAmount = (int)(1 * increaseWill);

        StrBonus();
        DefBonus();
        SkillBonus();
        SpdBonus();
        MagicBonus();
        WillBonus();*/



    }

    public static void StrIncrease()
    {
        strModifer = baseStrModifer + (Mathf.Round(level / baseStrModifer) * .1f) + 1;
    }

    public static void DefIncrease()
    {
        defModifer = baseDefModifer + (Mathf.Round(level / baseDefModifer) * .1f) + 1;
    }

    public static void SkillIncrease()
    {
        skillModifer = baseDefModifer + (Mathf.Round(level / baseSkillModifer) * .1f) + 1;
    }

    public static void SpdIncrease()
    {
        spdModifer = increaseSpd;
    }

    public static void MagicIncrease()
    {
        magicModifer = increaseMagic;
    }

    public static void WillIncrease()
    {
        willModifer = increaseWill;
    }


    /*public static void StrBonus()
    {
        strStatIncrease = strAmount;
    }

    public static void DefBonus()
    {
        defStatIncrease = defAmount;
    }

    public static void SkillBonus()
    {
        skillStatIncrease = skillAmount;
    }

    public static void SpdBonus()
    {
        spdStatIncrease = spdAmount;
    }

    public static void MagicBonus()
    {
        magicStatIncrease = magicAmount;
    }

    public static void WillBonus()
    {
        willStatIncrease = willAmount;
    }*/


}
