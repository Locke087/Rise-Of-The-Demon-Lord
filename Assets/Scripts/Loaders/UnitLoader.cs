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

    public void CreateNewUnit()
    {

        Unit me = new Unit();
        me.unitID = "findMe";
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Human";
        me.unitClass.main.human.warrior.level = 5;
        WarriorLoader.AssignSkill("Bull Rush", me.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Bull Rush", me.unitClass.sub.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Focused", me.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Focused", me.unitClass.sub.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Wild Rush", me.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Wild Rush", me.unitClass.sub.human.warrior.pickSkill);

        me.inventory.invSlot1.weapon.equipped = true;

        SwordLoader.AssignSword("Vemon Blade", me.inventory.invSlot1.weapon);

        UnitStoreroom.AddUnit(me);

    }
}
