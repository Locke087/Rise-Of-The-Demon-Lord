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
        WarriorLoader.AssignSkill("Bull Rush", me.unitClass.main.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Bull Rush", me.unitClass.sub.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Focused", me.unitClass.main.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Focused", me.unitClass.sub.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Wild Rush", me.unitClass.main.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Wild Rush", me.unitClass.sub.human.warrior.pickSkill, me);
        me.unitInfo.main = me.unitClass.main.human.warrior;
        
        // str, def, spd, skill, magic, will
        int[] bases = { 7, 5, 3, 5, 2, 1 };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = "Nimble";
        me.inventory.invSlot1.weapon.equipped = true;

        SwordLoader.AssignSword("Vemon Blade", me.inventory.invSlot1.weapon);

        CurrentGame.game.storeroom.units.Add(me);

    }
    ///For Directions
    // List<Sprite> sprites = new List<Sprite>();       
    // sprites.AddRange(Resources.LoadAll<Sprite>(me.unitActor.mapActor.groupName));
    // if (north) string direction = "North";
    //string idle = "Idle";
    // string[] allText = { "1", "Idle", "3" };
    //  List<string> texter = new List<string>();
    //texter.AddRange(allText);
    // string spriteName = me.unitActor.mapActor.personalID + direction + idle;
    // List<Sprite> spritesNew = new List<Sprite>();
    /*foreach (string st in texter)
    {
        spritesNew.Add(sprites.Find(x => x.name == (me.unitActor.mapActor.personalID + direction + st)));
    }
    foreach (Sprite s in spritesNew)
    {

    }*/

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
        Archer.Clear();
        Rogue.Clear();
        Fusilier.Clear();
        Priest.Clear();
        Cavalier.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.archer.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.mage.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.rogue.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.paladin.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.assassin.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.bard.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.archmage.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.charger.subbed.Clear();
        CurrentGame.game.memoryGeneral.humanClassProgress.knight.subbed.Clear();;
        CurrentGame.game.memoryGeneral.humanClassProgress.sniper.subbed.Clear();

        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.dread.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.shadow.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.shrike.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.nightblade.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.darkknight.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.demonRider.subbed.Clear();
        CurrentGame.game.memoryGeneral.impClassProgress.duelist.subbed.Clear();

        WarriorLoader.NewClass();
        PriestLoader.NewClass();
        CavalierLoader.NewClass();
        ArcherLoader.NewClass();
        RogueLoader.NewClass();
        MageLoader.NewClass();

        FusilierLoader.NewClass();
        ShadowLoader.NewClass();
        DreadLoader.NewClass();
        ShrikeLoader.NewClass();
        SwashbucklerLoader.NewClass();

        Unit me = new Unit();

        me.unitID = "Jeorge";
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Human";
        me.unitInfo.human = true;
        me.idx = me.unitID + IDMaker.NewID();
        me.unitInfo.mugName = "Dude";
    
        //  me.unitActor.mapActor.groupName = "sdsjkhsd";
        //   me.unitActor.mapActor.personalID = "goblin";


        me.unitClass.main.human.warrior.powerLevel = 1;
  ;
      
        me.unitClass.main.human.warrior = CurrentGame.game.memoryGeneral.humanClassProgress.warrior;
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.subbed.Add(me.unitID);
  
        WarriorLoader.AssignSkill("Focused", me.unitClass.main.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Focused", me.unitClass.sub.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Lunge", me.unitClass.main.human.warrior.pickSkill, me);
        WarriorLoader.AssignSkill("Lunge", me.unitClass.sub.human.warrior.pickSkill, me);
        me.unitClass.main.human.warrior.unlocked = true;
        me.unitClass.main.human.cavalier.unlocked = true;
        me.unitClass.main.human.archer.unlocked = true;
        me.unitClass.main.human.mage.unlocked = true;
        me.unitClass.main.human.priest.unlocked = true;
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
     
        // str, def, spd, skill, magic, will

        Unit newMe = new Unit();
  
        newMe.unitID = "Melvin";
        newMe.idx = newMe.unitID + IDMaker.NewID();
        newMe.unitClass.main.mainClass = "Warrior";
        newMe.unitInfo.mugName = "Actor_FW01_4";
        newMe.unitClass.main.race = "Human";
        newMe.unitInfo.human = true;
        newMe.unitClass.main.human.warrior.powerLevel = 1;
        
        newMe.unitClass.main.human.warrior = CurrentGame.game.memoryGeneral.humanClassProgress.warrior;
        newMe.unitClass.main.human.warrior.caps = Warrior.Caplist();
        newMe.unitInfo.currentMods = Warrior.ModList();
        CurrentGame.game.memoryGeneral.humanClassProgress.warrior.subbed.Add(newMe.unitID);
        WarriorLoader.AssignSkill("Double Edged", newMe.unitClass.main.human.warrior.pickSkill, newMe);
        WarriorLoader.AssignSkill("Double Edged", newMe.unitClass.sub.human.warrior.pickSkill, newMe);
        WarriorLoader.AssignSkill("Focused", newMe.unitClass.main.human.warrior.pickSkill, newMe);
        WarriorLoader.AssignSkill("Focused", newMe.unitClass.sub.human.warrior.pickSkill, newMe);
        newMe.unitClass.main.human.warrior.unlocked = true;
        newMe.unitClass.main.human.cavalier.unlocked = true;
        newMe.unitClass.main.human.archer.unlocked = true;
        newMe.unitClass.main.human.mage.unlocked = true;
        newMe.unitClass.main.human.priest.unlocked = true;
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
     

        Unit newMe2 = new Unit();

        newMe2.unitID = "Jesel";
        newMe2.unitClass.main.mainClass = "Cavalier";
        newMe2.unitClass.main.race = "Human";
        newMe2.unitInfo.human = true;
        newMe2.unitInfo.mugName = "Actor_FW01_8";
        newMe2.unitActor.neutralPortrait.groupName = "";
        newMe2.unitActor.neutralPortrait.personalID = "";
        newMe2.idx = me.unitID + IDMaker.NewID();
  

        newMe2.unitClass.main.human.cavalier = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier;
        newMe2.unitClass.main.human.cavalier.caps = Cavalier.Caplist();

        newMe2.unitInfo.currentMods = Cavalier.ModList();
        newMe2.unitClass.main.human.cavalier.powerLevel = 1;
        CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.subbed.Add(newMe2.unitID);
        CavalierLoader.AssignSkill("Trample", newMe2.unitClass.main.human.cavalier.pickSkill);
        CavalierLoader.AssignSkill("Lance", newMe2.unitClass.main.human.cavalier.pickSkill);
        //  CavalierLoader.AssignSkill("Joust", newMe2.unitClass.sub.human.cavalier.pickSkill);
        // CavalierLoader.AssignSkill("Protect Flanks", newMe2.unitClass.sub.human.cavalier.pickSkill);
        // CavalierLoader.AssignSkill("Vault", newMe2.unitClass.main.human.cavalier.pickSkill);
        //CavalierLoader.AssignSkill("Hospitalier", newMe2.unitClass.sub.human.cavalier.pickSkill);
        // CavalierLoader.AssignSkill("War Trained Mount", newMe2.unitClass.sub.human.cavalier.pickSkill);
        newMe2.unitClass.main.human.warrior.unlocked = true;
        newMe2.unitClass.main.human.cavalier.unlocked = true;
        newMe2.unitClass.main.human.archer.unlocked = true;
        newMe2.unitClass.main.human.mage.unlocked = true;
        newMe2.unitClass.main.human.priest.unlocked = true;

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
        SwordLoader.AssignSword("Vemon Blade", newMe2.inventory.invSlot1.weapon);

        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(newMe2.inventory.invSlot1.weapon);
        CurrentGame.game.storeroom.units.Add(newMe2);
        CurrentGame.game.memoryGeneral.unitsInRoster.Add(newMe2);
    


        Unit newMe3 = new Unit();
       
        newMe3.unitID = "Alice";
        newMe3.idx = newMe.unitID + IDMaker.NewID();
        newMe3.unitClass.main.mainClass = "Priest";
        newMe3.unitInfo.mugName = "Actor_FW01_4";
        newMe3.unitClass.main.race = "Human";
        newMe3.unitInfo.human = true;
        newMe3.unitClass.main.human.priest.powerLevel = 1;
        
        newMe3.unitClass.main.human.priest = CurrentGame.game.memoryGeneral.humanClassProgress.priest;
        newMe3.unitClass.main.human.priest.caps = Priest.Caplist();
        newMe3.unitInfo.currentMods = Priest.ModList();
        CurrentGame.game.memoryGeneral.humanClassProgress.priest.subbed.Add(newMe.unitID);
        PriestLoader.AssignSkill("Smite", newMe3.unitClass.main.human.priest.pickSkill);
        PriestLoader.AssignSkill("Smite", newMe3.unitClass.sub.human.priest.pickSkill);
        PriestLoader.AssignSkill("Healing Light", newMe3.unitClass.main.human.priest.pickSkill);
        PriestLoader.AssignSkill("Healing Light", newMe3.unitClass.sub.human.priest.pickSkill);
      //  PriestLoader.AssignSkill("Purify", newMe3.unitClass.main.human.priest.pickSkill);
       // PriestLoader.AssignSkill("Purify", newMe3.unitClass.sub.human.priest.pickSkill);

        newMe3.unitClass.main.human.warrior.unlocked = true;
        newMe3.unitClass.main.human.cavalier.unlocked = true;
        newMe3.unitClass.main.human.archer.unlocked = true;
        newMe3.unitClass.main.human.mage.unlocked = true;
        newMe3.unitClass.main.human.priest.unlocked = true;

        newMe3.unitInfo.main = newMe3.unitClass.main.human.priest;

        // str, def, spd, skill, magic, will
        int[] bases4 = { 2, 4, 2, 4, 6, 8 };
        newMe3.unitInfo.bases.AddRange(bases4);
        newMe3.unitInfo.nature = "Magical";
        newMe3.inventory.invSlot1.holding = "Warhammer";
        newMe3.inventory.invSlot1.weapon.equipped = true;
        newMe3.inventory.invSlot1.weapon.name = "Warhammer";
        newMe3.inventory.invSlot1.weapon.inSlot = true;
        newMe3.inventory.invSlot1.weapon.cost = 100;
        newMe3.inventory.invSlot1.weapon.idx = "Warhammer" + IDMaker.NewID();
        SwordLoader.AssignSword("Warhammer", newMe3.inventory.invSlot1.weapon);

        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(newMe3.inventory.invSlot1.weapon);
        CurrentGame.game.storeroom.units.Add(newMe3);
        CurrentGame.game.memoryGeneral.unitsInRoster.Add(newMe3);
    



        Unit newMe4 = new Unit();

        newMe4.unitID = "Sascha";
        newMe4.idx = newMe.unitID + IDMaker.NewID();
        newMe4.unitClass.main.mainClass = "Fusilier";
        newMe4.unitInfo.mugName = "Actor_FW02_Sascha";
        newMe4.unitClass.main.race = "Imp";
        newMe4.unitInfo.imp = true;
        newMe4.unitClass.main.imp.fusilier.powerLevel = 1;

        CurrentGame.game.memoryGeneral.impClassProgress.fusilier.subbed.Add(newMe4.unitID);

        newMe4.unitClass.main.imp.fusilier = CurrentGame.game.memoryGeneral.impClassProgress.fusilier;
        newMe4.unitClass.main.imp.fusilier.caps = Fusilier.Caplist();
        newMe4.unitInfo.currentMods = Priest.ModList();
        FusilierLoader.AssignSkill("Pistol-Whip", newMe4.unitClass.main.imp.fusilier.pickSkill);
        FusilierLoader.AssignSkill("Pistol-Whip", newMe4.unitClass.sub.imp.fusilier.pickSkill);
        FusilierLoader.AssignSkill("Deadeye", newMe4.unitClass.main.imp.fusilier.pickSkill);
        FusilierLoader.AssignSkill("Deadeye", newMe4.unitClass.sub.imp.fusilier.pickSkill);
        //FusilierLoader.AssignSkill("Cauterize", newMe4.unitClass.main.imp.fusilier.pickSkill);
        //FusilierLoader.AssignSkill("Backblast", newMe4.unitClass.sub.imp.fusilier.pickSkill);
        // FusilierLoader.AssignSkill("Flash and Fire", newMe4.unitClass.sub.imp.fusilier.pickSkill);
        //FusilierLoader.AssignSkill("Targeting", newMe4.unitClass.sub.imp.fusilier.pickSkill);
        newMe4.unitClass.main.imp.swashbuckler.unlocked = true;
        newMe4.unitClass.main.imp.shrike.unlocked = true;
        newMe4.unitClass.main.imp.shadow.unlocked = true;
        newMe4.unitClass.main.imp.dread.unlocked = true;
        newMe4.unitClass.main.imp.fusilier.unlocked = true;

        newMe4.unitInfo.main = newMe4.unitClass.main.imp.fusilier;

        // str, def, spd, skill, magic, will
        int[] bases5 = { 2, 4, 6, 8, 3, 3 };
        newMe4.unitInfo.bases.AddRange(bases5);
        newMe4.unitInfo.nature = "Quick";
        newMe4.inventory.invSlot1.holding = "Rifle";
        newMe4.inventory.invSlot1.weapon.equipped = true;
        newMe4.inventory.invSlot1.weapon.name = "Rifle";
        newMe4.inventory.invSlot1.weapon.inSlot = true;
        newMe4.inventory.invSlot1.weapon.cost = 100;
        newMe4.inventory.invSlot1.weapon.idx = "Rifle" + IDMaker.NewID();
        SwordLoader.AssignSword("Rifle", newMe4.inventory.invSlot1.weapon);

        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(newMe4.inventory.invSlot1.weapon);
        CurrentGame.game.storeroom.units.Add(newMe4);
        CurrentGame.game.memoryGeneral.unitsInRoster.Add(newMe4);
       



        NewOGLevel();
        NewFTLevel();
        NewSWLevel();
        NewGDLevel();
   
      

    
    }

    public int lastPick = 0;
    public int count = 0;

    public List<Unit> LoadEnemies(int rating)
    {
        List<Unit> enemiesInMap = new List<Unit>();
        int armysize = 0;
        int armylevel = 0;
        if (rating == 1)
        {
            armysize = 6;
            armylevel = 1;

            for (int i = 0; i < armysize; i++)
            {
                pickOneLowLevel(Random.Range(0, 5), armylevel, enemiesInMap);
            }

        }




        return enemiesInMap;
    }

   
    void pickOneLowLevel(int num, int level, List<Unit> enemies)
    {
        if (num == 0)
        {
            if (num == lastPick && count > 1)
            {
                pickOneLowLevel(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedGoblin(level, enemies);
            }
        }
        if (num == 1)
        {
            if (num == lastPick && count > 1)
            {
                pickOneLowLevel(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedSkeleton(level, enemies);
            }
        }
        if (num == 2)
        {
            if (num == lastPick && count > 1)
            {
                pickOneLowLevel(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedBlueSlime(level, enemies);
            }
        }
        if (num == 3)
        {
            if (num == lastPick && count > 1)
            {
                pickOneLowLevel(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedBabyDevil(level, enemies);
            }
        }
        if (num == 4)
        {
            if (num == lastPick && count > 1)
            {
                pickOneLowLevel(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedGreenSlime(level, enemies);
            }
        }
        

    }

    void pickOneHigh(int num, int level, List<Unit> enemies)
    {
        if (num == 0)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedBabyGreenDragon(level, enemies);
            }
        }
        if (num == 1)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedBabyRedDragon(level, enemies);
            }
        }
        if (num == 2)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedBlueVinetrap(level, enemies);
            }
        }
        if (num == 3)
        {
            if (num == lastPick && count > 1)
            {
                pickOneLowLevel(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedDevil(level, enemies);
            }
        }
        if (num == 4)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedEfreet(level, enemies);
            }
        }
        if (num == 5)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedGhost(level, enemies);
            }
        }
        if (num == 6)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedReaper(level, enemies);
            }
        }
        if (num == 7)
        {
            if (num == lastPick && count > 1)
            {
                pickOneHigh(Random.Range(0, 4), level, enemies);
            }
            else
            {
                lastPick = num;
                if (num == lastPick) count++;
                else count = 0;
                DelayedRedVinetrap(level, enemies);
            }
        }
       


    }

    void DelayedGoblin(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Goblin.LevelUp();      
            me.unitClass.main.monster.goblinCharger.modifiers = Goblin.ModList();
            me.unitClass.main.monster.goblinCharger.caps = Goblin.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.goblinCharger;
        }
        me.unitClass.main.mainClass = "Warrior";
        me.unitClass.main.race = "Goblin";
        me.unitClass.main.monster.goblinCharger.level = level;
        me.unitClass.main.monster.goblinCharger.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Goblin" + IDMaker.NewID();
      
        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        Goblin.Clear();
    }


    void DelayedBlueSlime(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            BlueSlimeE.LevelUp();
            me.unitClass.main.monster.blueSlime.modifiers = BlueSlimeE.ModList();
            me.unitClass.main.monster.blueSlime.caps = BlueSlimeE.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.blueSlime;
        }
        me.unitClass.main.mainClass = "Slime";
        me.unitClass.main.race = "Blue Slime";
        me.unitClass.main.monster.blueSlime.level = level;
        me.unitClass.main.monster.blueSlime.movement = 3;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Blue Slime" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        BlueSlimeE.Clear();
    }


    void DelayedGreenSlime(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            GreenSlimeE.LevelUp();
            me.unitClass.main.monster.greenSlime.modifiers = GreenSlimeE.ModList();
            me.unitClass.main.monster.greenSlime.caps = GreenSlimeE.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.greenSlime;
        }
        me.unitClass.main.mainClass = "Slime";
        me.unitClass.main.race = "Green Slime";
        me.unitClass.main.monster.greenSlime.level = level;
        me.unitClass.main.monster.greenSlime.movement = 3;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Green Slime" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        GreenSlimeE.Clear();
    }


    void DelayedBabyDevil(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            BabyDevil.LevelUp();
            me.unitClass.main.monster.babyDevil.modifiers = BabyDevil.ModList();
            me.unitClass.main.monster.babyDevil.caps = BabyDevil.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.babyDevil;
        }
        me.unitClass.main.mainClass = "Devil";
        me.unitClass.main.race = "Baby Devil";
        me.unitClass.main.monster.babyDevil.level = level;
        me.unitClass.main.monster.babyDevil.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Baby Devil" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        BabyDevil.Clear();
    }


    void DelayedBabyGreenDragon(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            BabyGreenDragonE.LevelUp();
            me.unitClass.main.monster.babyGreenDragon.modifiers = BabyGreenDragonE.ModList();
            me.unitClass.main.monster.babyGreenDragon.caps = BabyGreenDragonE.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.babyGreenDragon;
        }
        me.unitClass.main.mainClass = "Dragon";
        me.unitClass.main.race = "Baby Green Dragon";
        me.unitClass.main.monster.babyGreenDragon.level = level;
        me.unitClass.main.monster.babyGreenDragon.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Baby Green Dragon" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        BabyGreenDragonE.Clear();
    }


    void DelayedBabyRedDragon(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            BabyRedDragonE.LevelUp();
            me.unitClass.main.monster.babyRedDragon.modifiers = BabyRedDragonE.ModList();
            me.unitClass.main.monster.babyRedDragon.caps = BabyRedDragonE.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.babyRedDragon;
        }
        me.unitClass.main.mainClass = "Dragon";
        me.unitClass.main.race = "Baby Red Dragon";
        me.unitClass.main.monster.babyRedDragon.level = level;
        me.unitClass.main.monster.babyRedDragon.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Baby Red Dragon" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        BabyRedDragonE.Clear();
    }


    void DelayedBlueVinetrap(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            BlueVinetrapE.LevelUp();
            me.unitClass.main.monster.blueVineTrap.modifiers = BlueVinetrapE.ModList();
            me.unitClass.main.monster.blueVineTrap.caps = BlueVinetrapE.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.blueVineTrap;
        }
        me.unitClass.main.mainClass = "Vinetrap";
        me.unitClass.main.race = "Blue Vinetrap";
        me.unitClass.main.monster.blueVineTrap.level = level;
        me.unitClass.main.monster.blueVineTrap.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Blue Vinetrap" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        BlueVinetrapE.Clear();
    }


    void DelayedRedVinetrap(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            RedVinetrapE.LevelUp();
            me.unitClass.main.monster.redVineTrap.modifiers = RedVinetrapE.ModList();
            me.unitClass.main.monster.redVineTrap.caps = RedVinetrapE.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.blueSlime;
        }
        me.unitClass.main.mainClass = "Vinetrap";
        me.unitClass.main.race = "Red Vinetrap";
        me.unitClass.main.monster.redVineTrap.level = level;
        me.unitClass.main.monster.redVineTrap.movement = 3;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Red Vinetrap" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        RedVinetrapE.Clear();
    }


    void DelayedDevil(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Devil.LevelUp();
            me.unitClass.main.monster.devil.modifiers = Devil.ModList();
            me.unitClass.main.monster.devil.caps = Devil.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.devil;
        }
        me.unitClass.main.mainClass = "Devil";
        me.unitClass.main.race = "Devil";
        me.unitClass.main.monster.devil.level = level;
        me.unitClass.main.monster.devil.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Devil" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        Devil.Clear();
    }


    void DelayedEfreet(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Efreet.LevelUp();
            me.unitClass.main.monster.efreet.modifiers = Efreet.ModList();
            me.unitClass.main.monster.efreet.caps = Efreet.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.efreet;
        }
        me.unitClass.main.mainClass = "Efree";
        me.unitClass.main.race = "Efreet";
        me.unitClass.main.monster.efreet.level = level;
        me.unitClass.main.monster.efreet.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Efreet" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        Efreet.Clear();
    }


    void DelayedGhost(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Ghost.LevelUp();
            me.unitClass.main.monster.ghost.modifiers = Ghost.ModList();
            me.unitClass.main.monster.ghost.caps = Ghost.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.ghost;
        }
        me.unitClass.main.mainClass = "Undead";
        me.unitClass.main.race = "Ghost";
        me.unitClass.main.monster.ghost.level = level;
        me.unitClass.main.monster.ghost.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Ghost" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        Ghost.Clear();
    }


    void DelayedReaper(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Reaper.LevelUp();
            me.unitClass.main.monster.reaper.modifiers = Reaper.ModList();
            me.unitClass.main.monster.reaper.caps = Reaper.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.reaper;
        }
        me.unitClass.main.mainClass = "Undead";
        me.unitClass.main.race = "Reaper";
        me.unitClass.main.monster.reaper.level = level;
        me.unitClass.main.monster.reaper.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Reaper" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        Reaper.Clear();
    }


    void DelayedSkeleton(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Skeleton.LevelUp();
            me.unitClass.main.monster.skeleton.modifiers = Skeleton.ModList();
            me.unitClass.main.monster.skeleton.caps = Skeleton.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.skeleton;
        }
        me.unitClass.main.mainClass = "Undead";
        me.unitClass.main.race = "Skeleton";
        me.unitClass.main.monster.skeleton.level = level;
        me.unitClass.main.monster.skeleton.movement = 5;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Skeleton" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        Skeleton.Clear();
    }


    void Ogre(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Skeleton.LevelUp();
            me.unitClass.main.monster.Ogre.modifiers = OgreBoss.ModList();
            me.unitClass.main.monster.Ogre.caps = OgreBoss.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.Ogre;
        }
        me.unitClass.main.mainClass = "Ogre";
        me.unitClass.main.race = "Ogre";
        me.unitClass.main.monster.Ogre.level = level;
        me.unitClass.main.monster.Ogre.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Ogre" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        OgreBoss.Clear();
    }

    void Dragon(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            DragonBoss.LevelUp();
            me.unitClass.main.monster.Dragon.modifiers = DragonBoss.ModList();
            me.unitClass.main.monster.Dragon.caps = DragonBoss.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.Dragon;
        }
        me.unitClass.main.mainClass = "Dragon";
        me.unitClass.main.race = "Dragon";
        me.unitClass.main.monster.Dragon.level = level;
        me.unitClass.main.monster.Dragon.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Dragon" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        DragonBoss.Clear();
    }

    void NineTails(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Skeleton.LevelUp();
            me.unitClass.main.monster.NineTails.modifiers = NinetailsBoss.ModList();
            me.unitClass.main.monster.NineTails.caps = NinetailsBoss.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.NineTails;
        }
        me.unitClass.main.mainClass = "Nine Tails";
        me.unitClass.main.race = "Nine Tails";
        me.unitClass.main.monster.NineTails.level = level;
        me.unitClass.main.monster.NineTails.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Nine Tails" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        NinetailsBoss.Clear();
    }

    void Naga(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Skeleton.LevelUp();
            me.unitClass.main.monster.Naga.modifiers = NagaBoss.ModList();
            me.unitClass.main.monster.Naga.caps = NagaBoss.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.Naga;
        }
        me.unitClass.main.mainClass = "Naga";
        me.unitClass.main.race = "Naga";
        me.unitClass.main.monster.Naga.level = level;
        me.unitClass.main.monster.Naga.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Naga" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        NagaBoss.Clear();
    }

    void DemonKing(int level, List<Unit> enemiesInMap)
    {
        int amin = 3;
        int amax = 10;
        Unit me = new Unit();
        for (int i = 0; i < level; i++)
        {
            Skeleton.LevelUp();
            me.unitClass.main.monster.DemonKing.modifiers = LichBoss.ModList();
            me.unitClass.main.monster.DemonKing.caps = LichBoss.Caplist();
            me.unitInfo.main = me.unitClass.main.monster.DemonKing;
        }
        me.unitClass.main.mainClass = "Lich";
        me.unitClass.main.race = "Lich";
        me.unitClass.main.monster.DemonKing.level = level;
        me.unitClass.main.monster.DemonKing.movement = 4;
        //yield return new WaitForSeconds(0.01f);      
        me.unitID = "Demon King" + IDMaker.NewID();

        // str, def, spd, skill, magic, will
        int[] bases = { RB(amin, amax, 2), RB(amin, amax, 3), RB(amin, amax, -2), RB(amin, amax, 2), RB(amin, amax, 0), RB(amin, amax, -1) };
        me.unitInfo.bases.AddRange(bases);
        me.unitInfo.nature = ARandomNature.RandomNature();
        me.inventory.invSlot1.weapon = SwordLoader.RandomWeapon();
        me.inventory.invSlot1.weapon.inSlot = true;
        me.inventory.invSlot1.weapon.equipped = true;

        enemiesInMap.Add(me);
        CurrentGame.game.storeroom.units.Add(me);
        LichBoss.Clear();
    }










    public static int RB(int min, int max, int alt)
    {
        return Random.Range(min + alt, max + alt);
    }


    public void NewSWLevel()
    {
        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Clear();

        CurrentLevel level1 = new CurrentLevel();
        level1.deployLimit = 2;
        level1.powerRanking = 2;
        level1.enemiesInMap.units = LoadEnemies(level1.powerRanking);
        level1.name = "A Sweaty Welcome";
        level1.idx = "1" + IDMaker.NewID();
        level1.sceneName = "SWMap1";
        level1.goldReward = 100;
        level1.xpReward = 100;
        level1.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level1.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level1.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Add(level1);
        CurrentLevel level2 = new CurrentLevel();
        level2.deployLimit = 4;
        level2.powerRanking = 1;
        level2.enemiesInMap.units = LoadEnemies(level2.powerRanking);
        level2.name = "An Oasis Of Evil";
        level2.idx = "2" + IDMaker.NewID();
        level2.sceneName = "SWMap1";
        level2.goldReward = 150;
        level2.xpReward = 100;
        level2.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level2.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level2.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Add(level2);
        CurrentLevel level3 = new CurrentLevel();
        level3.deployLimit = 8;
        level3.powerRanking = 3;
        level3.enemiesInMap.units = LoadEnemies(level3.powerRanking);
        level3.name = "The Sands of Danger";
        level3.idx = "3" + IDMaker.NewID();
        level3.sceneName = "SWMap1";
        level3.goldReward = 200;
        level3.xpReward = 100;
        level3.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level3.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level3.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Add(level3);
    }

    public void NewOGLevel()
    {
        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Clear();

        CurrentLevel level1 = new CurrentLevel();
        level1.deployLimit = 2;
        level1.powerRanking = 2;
        level1.enemiesInMap.units = LoadEnemies(level1.powerRanking);
        level1.name = "A Grassy Start";
        level1.idx = "1" + IDMaker.NewID();
        level1.sceneName = "OGLMap1";
        level1.goldReward = 100;
        level1.xpReward = 100;
        level1.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level1.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level1.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Add(level1);
        CurrentLevel level2 = new CurrentLevel();
        level2.deployLimit = 4;
        level2.powerRanking = 1;
        level2.enemiesInMap.units = LoadEnemies(level2.powerRanking);
        level2.name = "A Deadly Knoll";
        level2.idx = "2" + IDMaker.NewID();
        level2.sceneName = "OGLMap1";
        level2.goldReward = 150;
        level2.xpReward = 100;
        level2.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level2.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level2.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Add(level2);
        CurrentLevel level3 = new CurrentLevel();
        level3.deployLimit = 8;
        level3.powerRanking = 4;
        level3.enemiesInMap.units = LoadEnemies(level3.powerRanking);
        level3.name = "Weed Out The Enemy";
        level3.idx = "3" + IDMaker.NewID();
        level3.sceneName = "OGLMap1";
        level3.goldReward = 200;
        level3.xpReward = 100;
        level3.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level3.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level3.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Add(level3);


    }


    public void NewGDLevel()
    {
        CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Clear();

        CurrentLevel level1G = new CurrentLevel();
        level1G.deployLimit = 2;
        level1G.powerRanking = 2;
        level1G.enemiesInMap.units = LoadEnemies(level1G.powerRanking);
        level1G.name = "A Heated Greeting";
        level1G.idx = "1" + IDMaker.NewID();
        level1G.sceneName = "GDMap1";
        level1G.goldReward = 100;
        level1G.xpReward = 100;
        level1G.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level1G.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level1G.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Add(level1G);
        CurrentLevel level2G = new CurrentLevel();
        level2G.deployLimit = 4;
        level2G.powerRanking = 1;
        level2G.enemiesInMap.units = LoadEnemies(level2G.powerRanking);
        level2G.name = "Ablaze With Wickedness";
        level2G.idx = "2" + IDMaker.NewID();
        level2G.sceneName = "GDMap1";
        level2G.goldReward = 150;
        level2G.xpReward = 100;
        level2G.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level2G.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level2G.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Add(level2G);
        CurrentLevel level3G = new CurrentLevel();
        level3G.deployLimit = 8;
        level3G.powerRanking = 4;
        level3G.enemiesInMap.units = LoadEnemies(level3G.powerRanking);
     
        level3G.name = "The Burning Hellscape";
        level3G.idx = "3" + IDMaker.NewID();
        level3G.sceneName = "GDMap1";
        level3G.goldReward = 200;
        level3G.xpReward = 100;
        level3G.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level3G.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level3G.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Add(level3G);
    }


    public void NewFTLevel()
    {
        CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Clear();

        CurrentLevel level1F = new CurrentLevel();
        level1F.deployLimit = 2;
        level1F.powerRanking = 2;
        level1F.enemiesInMap.units = LoadEnemies(level1F.powerRanking);
        level1F.name = "A Frosty Beginning";
        level1F.idx = "1" + IDMaker.NewID();
        level1F.sceneName = "FTMap1";
        level1F.goldReward = 100;
        level1F.xpReward = 100;
        level1F.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level1F.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level1F.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Add(level1F);
        CurrentLevel level2F = new CurrentLevel();
        level2F.deployLimit = 4;
        level2F.powerRanking = 1;
        level2F.enemiesInMap.units = LoadEnemies(level2F.powerRanking);
        level2F.name = "The Frozen Front";
        level2F.idx = "2" + IDMaker.NewID();
        level2F.sceneName = "FTMap1";
        level2F.goldReward = 150;
        level2F.xpReward = 100;
        level2F.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level2F.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level2F.chestPool.gold = 75;

        CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Add(level2F);
        CurrentLevel level3F = new CurrentLevel();
        level3F.deployLimit = 8;
        level3F.powerRanking = 4;
        level3F.enemiesInMap.units = LoadEnemies(level3F.powerRanking);
        level3F.name = "Chilled Out Baddies";
        level3F.idx = "3" + IDMaker.NewID();
        level3F.sceneName = "FTMap1";
        level3F.goldReward = 200;
        level3F.xpReward = 100;
        level3F.chestPool.weapons.AddRange(SwordLoader.ChestWeapons());
        level3F.chestPool.assessories.AddRange(AssessoryLoader.ChestAssessories());
        level3F.chestPool.gold = 75;
       CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Add(level3F);
    }

    
    
         
   
}
