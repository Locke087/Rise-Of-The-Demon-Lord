using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateNewUnit(UnitStoreroom storeroom)
    {

        Unit me = new Unit();

        me.unitID = "findMe";
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Human";
        me.unitClass.main.human.warrior.level = 5;
        for (int i = 0; i < me.unitClass.main.human.warrior.level; i++) {
            Warrior.LevelUp();
        }
        me.unitClass.main.human.warrior.modifiers = Warrior.ModList();
        WarriorLoader.AssignSkill("Bull Rush", me.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Bull Rush", me.unitClass.sub.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Focused", me.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Focused", me.unitClass.sub.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Wild Rush", me.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Wild Rush", me.unitClass.sub.human.warrior.pickSkill);
        me.unitInfo.main = me.unitClass.main.human.warrior;

        // str, def, spd, skill, magic, will
        int[] bases = { 7, 5, 3, 5, 2, 1 };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = "Nimble";
        me.inventory.invSlot1.weapon.equipped = true;

        SwordLoader.AssignSword("Vemon Blade", me.inventory.invSlot1.weapon);

        storeroom.units.Add(me);

    }
}
