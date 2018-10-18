using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void AssignSkill(string sk, UnitClassSkill u)
    {
        UnitSkillDetail focused = new UnitSkillDetail();
        focused.name = "Focused";
        focused.effects.attackBoost = true;
        focused.support = true;
        focused.attackPattern = "Self";

        UnitSkillDetail wildStrike = new UnitSkillDetail();
        wildStrike.name = "Wild Strike";
        wildStrike.physicalDamage = true;
        wildStrike.attackPattern = "BackAndFront";

        UnitSkillDetail bullrush = new UnitSkillDetail();
        bullrush.name = "Bull Rush";
        bullrush.physicalDamage = true;
        bullrush.effects.damageReduction = true;
        bullrush.effects.knockBack = true;
        bullrush.range = 1;

        UnitSkillDetail doubleEdged = new UnitSkillDetail();
        doubleEdged.physicalDamage = true;
        doubleEdged.range = 1;
        doubleEdged.extraDamageMod = 1.2f;
        doubleEdged.name = "Double Edged";
        doubleEdged.effects.selfDamage = true;

        UnitSkillDetail blitz = new UnitSkillDetail();
        blitz.name = "Blitz";
        blitz.range = 1;
        blitz.physicalDamage = true;
        blitz.effects.extraHit = true;
        blitz.effects.hitrateReduce = true;


        UnitSkillDetail lunge = new UnitSkillDetail();
        lunge.name = "Lunge";
        lunge.range = 1;
        lunge.attackPattern = "2TileLine";
        lunge.physicalDamage = true;

        UnitSkillDetail counter = new UnitSkillDetail();
        counter.name = "Counter";
        counter.support = true;
        counter.effects.counter = true;

        if (sk == focused.name)
        {
            u.skill1 = focused;
        }
        else if (sk == wildStrike.name)
        {
            u.skill2 = wildStrike;
        }
        else if (sk == bullrush.name)
        {
            u.skill3 = bullrush;
        }
        else if (sk == doubleEdged.name)
        {
            u.skill4 = bullrush;
        }
        else if (sk == blitz.name)
        {
            u.skill5 = blitz;
        }
        else if (sk == lunge.name)
        {
            u.skill6 = lunge;
        }
        else if (sk == counter.name)
        {
            u.skill7 = counter;
        }



    }
}
