using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLoader : MonoBehaviour {

	
    public void CreateNewUnit()
    {

        Unit me = new Unit();

        me.unitID = "findMe";
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Human";
        me.unitClass.main.human.warrior.level = 5;
        for (int i = 0; i < me.unitClass.main.human.warrior.level; i++) {
            Warrior.LevelUp();
        }
        me.unitClass.main.human.warrior.movement = 5;
        me.unitClass.main.human.warrior.modifiers = Warrior.ModList();
        me.unitClass.main.human.warrior.caps = Warrior.Caplist();
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

        CurrentGame.game.storeroom.units.Add(me);

    }


    public void CreateStartingRoster()
    {
        CurrentGame.game.memoryGeneral.itemsOwned.items.Clear();
        CurrentGame.game.memoryGeneral.itemsOwned.assessories.Clear();
        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Clear();
        CurrentGame.game.memoryGeneral.shopWares.items.Clear();
        CurrentGame.game.memoryGeneral.shopWares.assessories.Clear();
        CurrentGame.game.memoryGeneral.shopWares.weapons.Clear();
        CurrentGame.game.storeroom.units.Clear();
        CurrentGame.game.memoryGeneral.unitsInRoster.Clear();
        CurrentGame.game.memoryGeneral.unitsInParty.Clear();
        CurrentGame.game.memoryGeneral.enemiesInMaps.units.Clear();
        Warrior.Clear();
        Unit me = new Unit();

        me.unitID = "Jeorge";
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Human";
        me.unitClass.main.human.warrior.level = 5;
        for (int i = 0; i < me.unitClass.main.human.warrior.level; i++)
        {
            Warrior.LevelUp();
            me.unitClass.main.human.warrior.modifiers = Warrior.ModList();
            me.unitClass.main.human.warrior.caps = Warrior.Caplist();
        }
        me.unitClass.main.human.warrior.movement = 5;

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
        me.inventory.invSlot1.holding = "Vemon Blade";
        me.inventory.invSlot1.weapon.equipped = true;
        me.inventory.invSlot1.weapon.name = "Vemon Blade";
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.cost = 100;
        me.inventory.invSlot1.weapon.idx = "Vemon Blade" + IDMaker.NewID();
        SwordLoader.AssignSword("Vemon Blade", me.inventory.invSlot1.weapon);
        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(me.inventory.invSlot1.weapon);
        CurrentGame.game.storeroom.units.Add(me);
        CurrentGame.game.memoryGeneral.unitsInRoster.Add(me);
        CurrentGame.game.memoryGeneral.unitsInParty.Add(me);
        // str, def, spd, skill, magic, will

        Unit newMe = new Unit();
  
        newMe.unitID = "Melvin";
        newMe.unitClass.main.mainClass = "Warrior";
        newMe.unitClass.main.race = "Human";
        newMe.unitClass.main.human.warrior.level = 5;
        newMe.unitClass.main.human.warrior.movement = 5;
      //  newMe.unitClass.main.human.warrior.modifiers.Clear();
      //  newMe.unitClass.main.human.warrior.caps.Clear();
        newMe.unitClass.main.human.warrior.modifiers = Warrior.ModList();
        newMe.unitClass.main.human.warrior.caps = Warrior.Caplist();
        WarriorLoader.AssignSkill("Double Edged", newMe.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Double Edged", newMe.unitClass.sub.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Focused", newMe.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Focused", newMe.unitClass.sub.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Lunge", newMe.unitClass.main.human.warrior.pickSkill);
        WarriorLoader.AssignSkill("Lunge", newMe.unitClass.sub.human.warrior.pickSkill);
        newMe.unitInfo.main = newMe.unitClass.main.human.warrior;

        // str, def, spd, skill, magic, will
        int[] bases2 = { 8, 4, 2, 6, 1, 2 };
        newMe.unitInfo.bases.AddRange(bases2);
        newMe.unitInfo.nature = "Tough";
        newMe.inventory.invSlot1.holding = "Vemon Blade";
        newMe.inventory.invSlot1.weapon.equipped = true;
        newMe.inventory.invSlot1.weapon.name = "Vemon Blade";
        newMe.inventory.invSlot1.weapon.inSlot = true;
        newMe.inventory.invSlot1.weapon.cost = 100;
        newMe.inventory.invSlot1.weapon.idx = "Vemon Blade" + IDMaker.NewID();
        SwordLoader.AssignSword("Vemon Blade", newMe.inventory.invSlot1.weapon);
       
        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(newMe.inventory.invSlot1.weapon);
        CurrentGame.game.storeroom.units.Add(newMe);
        CurrentGame.game.memoryGeneral.unitsInRoster.Add(newMe);
        CurrentGame.game.memoryGeneral.unitsInParty.Add(newMe);

        Unit newMe2 = new Unit();

        newMe2.unitID = "Jesel";
        newMe2.unitClass.main.mainClass = "Cavalier";
        newMe2.unitClass.main.race = "Human";
        newMe2.unitClass.main.human.cavalier.level = 5;
        for (int i = 0; i < newMe2.unitClass.main.human.cavalier.level; i++)
        {
            Cavalier.LevelUp();
            newMe2.unitClass.main.human.cavalier.modifiers = Cavalier.ModList();
            newMe2.unitClass.main.human.cavalier.caps = Cavalier.Caplist();
        }
        newMe2.unitClass.main.human.cavalier.movement = 6;
    
        CavalierLoader.AssignSkill("Trample", newMe2.unitClass.main.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("Joust", newMe2.unitClass.sub.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("Lance", newMe2.unitClass.main.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("Protect Flanks", newMe2.unitClass.sub.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("Vault", newMe2.unitClass.main.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("Hospitalier", newMe2.unitClass.sub.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("War Trained Mount", newMe2.unitClass.sub.human.cavalier.pickSkill);
        newMe2.unitInfo.main = newMe2.unitClass.main.human.cavalier;

        // str, def, spd, skill, magic, will
        int[] bases3 = { 8, 4, 2, 6, 1, 2 };
        newMe2.unitInfo.bases.AddRange(bases2);
        newMe2.unitInfo.nature = "Tough";
        newMe2.inventory.invSlot1.holding = "Vemon Blade";
        newMe2.inventory.invSlot1.weapon.equipped = true;
        newMe2.inventory.invSlot1.weapon.name = "Vemon Blade";
        newMe2.inventory.invSlot1.weapon.inSlot = true;
        newMe2.inventory.invSlot1.weapon.cost = 100;
        newMe2.inventory.invSlot1.weapon.idx = "Vemon Blade" + IDMaker.NewID();
        SwordLoader.AssignSword("Vemon Blade", newMe.inventory.invSlot1.weapon);

        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(newMe2.inventory.invSlot1.weapon);
        CurrentGame.game.storeroom.units.Add(newMe2);
        CurrentGame.game.memoryGeneral.unitsInRoster.Add(newMe2);
        CurrentGame.game.memoryGeneral.unitsInParty.Add(newMe2);

    }


    public List<Unit> LoadEnemies(int rating)
    {
        List<Unit> enemiesInMap = new List<Unit>();
        Unit me = new Unit();

        me.unitID = "BadGuy";
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Human";
        me.unitClass.main.human.warrior.level = rating;
     
        me.unitClass.main.human.warrior.movement = 5;
        me.unitClass.main.human.warrior.modifiers = Warrior.ModList();
        me.unitClass.main.human.warrior.caps = Warrior.Caplist();
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
       
        me.inventory.invSlot1.weapon.name = "Vemon Blade";
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.idx = "Vemon Blade" + IDMaker.NewID();
        SwordLoader.AssignSword("Vemon Blade", me.inventory.invSlot1.weapon);
      
        enemiesInMap.Add(me);
        enemiesInMap.Add(me);
        enemiesInMap.Add(me);
        enemiesInMap.Add(me);
        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);

        // str, def, spd, skill, magic, will

        Unit newMe = new Unit();

        newMe.unitID = "DadGuy";
        newMe.unitClass.main.mainClass = "Warrior";
        newMe.unitClass.main.race = "Human";
        newMe.unitClass.main.human.warrior.level = rating;
   
        newMe.unitClass.main.human.warrior.movement = 5;
        newMe.unitClass.main.human.warrior.modifiers = Warrior.ModList();
        newMe.unitClass.main.human.warrior.caps = Warrior.Caplist();
        newMe.unitInfo.main = newMe.unitClass.main.human.warrior;

        // str, def, spd, skill, magic, will
        int[] bases2 = { 8, 4, 2, 6, 1, 2 };
        newMe.unitInfo.bases.AddRange(bases2);
        newMe.unitInfo.nature = "Hardy";
        newMe.inventory.invSlot1.weapon.equipped = true;

        newMe.inventory.invSlot1.weapon.name = "Vemon Blade";
        newMe.inventory.invSlot1.weapon.inSlot = true;
        newMe.inventory.invSlot1.weapon.idx = "Vemon Blade" + IDMaker.NewID();
        SwordLoader.AssignSword("Vemon Blade", newMe.inventory.invSlot1.weapon);

        enemiesInMap.Add(newMe);
        enemiesInMap.Add(newMe);
        enemiesInMap.Add(newMe);
        enemiesInMap.Add(newMe);
        enemiesInMap.Add(newMe);
        enemiesInMap.Add(newMe);
        CurrentGame.game.storeroom.units.Add(newMe);
        return enemiesInMap;
    }
}
