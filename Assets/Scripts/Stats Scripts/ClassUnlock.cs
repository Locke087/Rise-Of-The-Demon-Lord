using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassUnlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void CheckOnClass(Unit u)
    {
        if (u.unitInfo.human)
        {
            if (WarriorLoader.HowManySkills(u.unitClass.main.human.warrior.pickSkill) >= 3
               && PriestLoader.HowManySkills(u.unitClass.main.human.priest.pickSkill) >= 2)
            {
                // PaladinLoader.ClassUnlocked(u);
            }
            if (WarriorLoader.HowManySkills(u.unitClass.main.human.warrior.pickSkill) >= 2
              && CavalierLoader.HowManySkills(u.unitClass.main.human.cavalier.pickSkill) >= 3)
            {
                // ChargerLoader.ClassUnlocked(u);
            }
            if (WarriorLoader.HowManySkills(u.unitClass.main.human.warrior.pickSkill) >= 3
             && CavalierLoader.HowManySkills(u.unitClass.main.human.cavalier.pickSkill) >= 2)
            {
                // KnightLoader.ClassUnlocked(u);
            }
            if (MageLoader.HowManySkills(u.unitClass.main.human.mage.pickSkill) >= 3
             && PriestLoader.HowManySkills(u.unitClass.main.human.priest.pickSkill) >= 3)
            {
                // BardLoader.ClassUnlocked(u);
            }
            if (MageLoader.HowManySkills(u.unitClass.main.human.mage.pickSkill) >= 4)    
            {
                // ArchmageLoader.ClassUnlocked(u);
            }
            if (ArcherLoader.HowManySkills(u.unitClass.main.human.archer.pickSkill) >= 4)
            {
                // SniperLoader.ClassUnlocked(u);
            }
            if (RogueLoader.HowManySkills(u.unitClass.main.human.rogue.pickSkill) >= 4)
            {
                // AssassinLoader.ClassUnlocked(u);
            }
        }
        if (u.unitInfo.imp)
        {

           if ( SwashbucklerLoader.HowManySkills(u.unitClass.main.imp.swashbuckler.pickSkill) >= 2
                && FusilierLoader.HowManySkills(u.unitClass.main.imp.fusilier.pickSkill) >= 3)
            {
              // CannoneerLoader.ClassUnlocked(u);
            }
            if (DreadLoader.HowManySkills(u.unitClass.main.imp.fusilier.pickSkill) >= 2
                && ShadowLoader.HowManySkills(u.unitClass.main.imp.shadow.pickSkill) >= 3)
            {
                // NightbladeLoader.ClassUnlocked(u);
            }
            if (SwashbucklerLoader.HowManySkills(u.unitClass.main.imp.swashbuckler.pickSkill) >= 4)           
            {
                // DuelistLoader.ClassUnlocked(u);
            }
            if (ShrikeLoader.HowManySkills(u.unitClass.main.imp.shrike.pickSkill) >= 4)
            {
                // DemonriderLoader.ClassUnlocked(u);
            }
            if (DreadLoader.HowManySkills(u.unitClass.main.imp.dread.pickSkill) >= 4)
            {
                // DarkKnightLoader.ClassUnlocked(u);
            }
        }
    }
}
