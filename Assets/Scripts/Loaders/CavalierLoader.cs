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

