using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowLoader : MonoBehaviour {

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
        UnitSkillDetail shadowstick = new UnitSkillDetail();
        shadowstick.name = "Shadowstick";
        shadowstick.magicDamage = true;//magic / 2
        shadowstick.effects.darkDamage = true;
        shadowstick.range = 3;
        shadowstick.effects.root = true;


        UnitSkillDetail lightFades = new UnitSkillDetail();
        lightFades.name = "Light Fades";
        lightFades.effects.invisible = true; ;
        lightFades.effects.hitrateReduce = true;
        lightFades.range = 0;
        lightFades.attackPattern = "Self";


        UnitSkillDetail dirtyTrick = new UnitSkillDetail();
        dirtyTrick.name = "Dirty Trick";
        dirtyTrick.effects.randomDebuff = true;
        dirtyTrick.range = 0;


        UnitSkillDetail shades = new UnitSkillDetail();
        shades.range = 0;
        shades.support = true;
        shades.effects.hitrateReduce = true;
        shades.effects.counter = true;
        shades.name = "Shades";


        UnitSkillDetail smokeBomb = new UnitSkillDetail();
        smokeBomb.name = "Smoke Bomb";
        smokeBomb.range = 3;
        smokeBomb.effects.hitrateReduce = true;
        smokeBomb.effects.poison = true;
        smokeBomb.attackPattern = "burst";


        UnitSkillDetail darkIntentions = new UnitSkillDetail();
        darkIntentions.name = "Dark Intentions";
        darkIntentions.effects.increaseDebuffs = true;
        darkIntentions.range = 0;
        darkIntentions.support = true;


        UnitSkillDetail knifeTheSoul = new UnitSkillDetail();
        knifeTheSoul.name = "Knife the Soul";
        knifeTheSoul.range = 0;
        knifeTheSoul.effects.trueDamage = true;//deals weapon half weapon might to enemy ignoring defense if it hits
        knifeTheSoul.effects.hitReduction = true;

        if (sk == shadowstick.name)
        {
            u.skill1 = shadowstick;
        }
        else if (sk == lightFades.name)
        {
            u.skill2 = lightFades;
        }
        else if (sk == dirtyTrick.name)
        {
            u.skill3 = dirtyTrick;
        }
        else if (sk == shades.name)
        {
            u.skill4 = shades;
        }
        else if (sk == smokeBomb.name)
        {
            u.skill5 = smokeBomb;
        }
        else if (sk == darkIntentions.name)
        {
            u.skill6 = darkIntentions;
        }
        else if (sk == knifeTheSoul.name)
        {
            u.skill7 = knifeTheSoul;
        }
    }
}
