using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusilierLoader : MonoBehaviour
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
        UnitSkillDetail pistolWhip = new UnitSkillDetail();
        pistolWhip.name = "Pistol-Whip";
        pistolWhip.physicalDamage = true;//magic / 2
        pistolWhip.range = 1;
        pistolWhip.effects.stun = true;


        UnitSkillDetail targeting = new UnitSkillDetail();
        targeting.name = "Targeting";
        targeting.support = true;
        targeting.effects.attackBoost = true;


        UnitSkillDetail deadEye = new UnitSkillDetail();
        deadEye.name = "Deadeye";
        deadEye.effects.critIncrease = true;
        deadEye.physicalDamage = true;
        deadEye.range = 4;


        UnitSkillDetail backBlast = new UnitSkillDetail();
        backBlast.range = 4;
        backBlast.attackPattern = "1 tile behind, 4 in front line";
        backBlast.effects.fireDamage = true;
        backBlast.magicDamage = true;//50% life
        backBlast.name = "Backblast";


        UnitSkillDetail cauterize = new UnitSkillDetail();
        cauterize.name = "Cauterize";
        cauterize.attackPattern = "self";
        cauterize.effects.selfDamage = true;
        cauterize.effects.fireDamage = true;
        cauterize.effects.statusHeal = true;


        UnitSkillDetail flashAndFire = new UnitSkillDetail();
        flashAndFire.name = "Flash and Fire";
        flashAndFire.range = 3;
        flashAndFire.attackPattern = "2x3 cone";
        flashAndFire.effects.fireDamage = true;
        flashAndFire.effects.hitReduction = true;


        UnitSkillDetail recoil = new UnitSkillDetail();
        recoil.name = "Recoil";
        recoil.support = true;
        recoil.physicalDamage = true;
        recoil.effects.counter = true;


        if (sk == pistolWhip.name)
        {
            u.skill1 = pistolWhip;
        }
        else if (sk == targeting.name)
        {
            u.skill2 = targeting;
        }
        else if (sk == deadEye.name)
        {
            u.skill3 = deadEye;
        }
        else if (sk == backBlast.name)
        {
            u.skill4 = backBlast;
        }
        else if (sk == cauterize.name)
        {
            u.skill5 = cauterize;
        }
        else if (sk == flashAndFire.name)
        {
            u.skill6 = flashAndFire;
        }
        else if (sk == recoil.name)
        {
            u.skill7 = recoil;
        }
    }
}
