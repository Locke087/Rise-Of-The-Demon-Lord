using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour {

    public static float strModifer = 3;
    public static float defModifer = 3;
    public static float skillModifer = 2.5f;
    public static float spdModifer = 2.5f;
    public static float magicModifer = 2;
    public static float willModifer = 2;
    public int level = 0;
    public static int strStatIncrease = 0;
    public static int defStatIncrease = 0;
    public static int skillStatIncrease = 0;
    public static int spdStatIncrease = 0;
    public static int magicStatIncrease = 0;
    public static int willStatIncrease = 0;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  
    public static void IncreaseStr()
    {
        strModifer = strModifer + 1;
    }

    public static void IncreaseDef()
    {
        defModifer = defModifer + 1;
    }

    public static void SkillIncrease()
    {
        skillModifer = skillModifer + 1;
    }

    public static void spdIncrease()
    {
        spdModifer = spdModifer + 1;
    }

    public static void magicIncrease()
    {
        magicModifer = magicModifer + 1;
    }

    public static void willIncrease()
    {
        willModifer = willModifer + 1;
    }


    public static void StrBonus()
    {
        strStatIncrease = strStatIncrease + 1;
    }

    public static void DefBonus()
    {
        defStatIncrease = defStatIncrease + 1;
    }

    public static void SkillBonus()
    {
        skillStatIncrease = skillStatIncrease + 1;
    }

    public static void spdBonus()
    {
        spdStatIncrease = spdStatIncrease + 1;
    }

    public static void magicBonus()
    {
        magicStatIncrease = magicStatIncrease + 1;
    }

    public static void willBonus()
    {
        willStatIncrease = willStatIncrease + 1;
    }
}
