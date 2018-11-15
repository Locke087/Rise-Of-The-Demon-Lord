using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void AssignSkill(string sk, UnitClassSkill u)
    {
        UnitSkillDetail volley = new UnitSkillDetail();
        volley.name = "Volley";
        volley.physicalDamage = true;
        volley.range = 5;

        UnitSkillDetail overDraw = new UnitSkillDetail();
        overDraw.name = "Overdraw";
        overDraw.physicalDamage = true;
        overDraw.range = 8;
        overDraw.effects.hitrateReduce = true;

        UnitSkillDetail doubleNock = new UnitSkillDetail();
        doubleNock.name = "Double-Nock";
        doubleNock.physicalDamage = true;
        doubleNock.effects.damageReduction = true;
        doubleNock.effects.extraHit = true;
        doubleNock.range = 5;

        UnitSkillDetail pierce = new UnitSkillDetail();
        pierce.physicalDamage = true;
        pierce.range = 5;
        pierce.extraDamageMod = 1.2f;
        pierce.name = "Pierce";
        pierce.effects.selfDamage = true;

        UnitSkillDetail armShot = new UnitSkillDetail();
        armShot.name = "Arm Shot";
        armShot.range = 5;
        armShot.physicalDamage = true;
        armShot.effects.hitrateReduce = true;


        UnitSkillDetail legShot = new UnitSkillDetail();
        legShot.name = "Leg Shot";
        legShot.range = 1;
        legShot.attackPattern = "2TileLine";
        legShot.physicalDamage = true;

        UnitSkillDetail stabbingArrow = new UnitSkillDetail();
        stabbingArrow.name = "Stabbing Arrow";
        stabbingArrow.support = true;
        stabbingArrow.effects.counter = true;

        if (sk == volley.name)
        {
            u.skill1 = volley;
        }
        else if (sk == overDraw.name)
        {
            u.skill2 = overDraw;
        }
        else if (sk == doubleNock.name)
        {
            u.skill3 = doubleNock;
        }
        else if (sk == pierce.name)
        {
            u.skill4 = pierce;
        }
        else if (sk == armShot.name)
        {
            u.skill5 = armShot;
        }
        else if (sk == legShot.name)
        {
            u.skill6 = legShot;
        }
        else if (sk == stabbingArrow.name)
        {
            u.skill7 = stabbingArrow;
        }



    }
}

