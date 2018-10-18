using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cavalier : MonoBehaviour {

    public static float baseStrModifer = 3;
    public static float baseDefModifer = 2.5f;
    public static float baseSkillModifer = 2.5f;
    public static float baseSpdModifer = 3;
    public static float baseMagicModifer = 2;
    public static float baseWillModifer = 2;
    public static float strModifer = 3;
    public static float defModifer = 2.5f;
    public static float skillModifer = 2.5f;
    public static float spdModifer = 3;
    public static float magicModifer = 2;
    public static float willModifer = 2;
    public static int level = 0;
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
    public int amount = 10;
    public int finalLevel;
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