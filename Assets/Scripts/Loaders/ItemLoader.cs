using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoader : MonoBehaviour {




    public static void StartingInventoryItems()
    {

        ItemHolder potion = new ItemHolder();
        potion.cost = 50;
        potion.count = 1;
        potion.description = "Heals Your Unit By 10 HP";
        potion.name = "Potion Small";
        potion.effects.heal = true;
        potion.effects.effectBase = 10;
        CurrentGame.game.memoryGeneral.itemsOwned.items.Add(potion);
        CurrentGame.game.memoryGeneral.shopWares.items.Add(potion);

        ItemHolder potionLarge = new ItemHolder();
        potionLarge.cost = 100;
        potionLarge.count = 1;
        potionLarge.description = "Heals Your Unit By 20 HP";
        potionLarge.name = "Potion Large";
        potionLarge.effects.heal = true;
        potionLarge.effects.effectBase = 20;
        CurrentGame.game.memoryGeneral.itemsOwned.items.Add(potionLarge);
        CurrentGame.game.memoryGeneral.shopWares.items.Add(potionLarge);

        ItemHolder doorKey = new ItemHolder();
        doorKey.cost = 50;
        doorKey.count = 1;
        doorKey.description = "Opens Doors";
        doorKey.name = "Door Key";
        doorKey.effects.doorKey = true;
        doorKey.effects.effectBase = 10;
        CurrentGame.game.memoryGeneral.itemsOwned.items.Add(doorKey);
        CurrentGame.game.memoryGeneral.shopWares.items.Add(doorKey);

        ItemHolder chestKey = new ItemHolder();
        chestKey.cost = 100;
        chestKey.count = 1;
        chestKey.description = "Open Chest";
        chestKey.name = "Chest Key";
        chestKey.effects.chestKey = true;
        CurrentGame.game.memoryGeneral.itemsOwned.items.Add(chestKey);
        CurrentGame.game.memoryGeneral.shopWares.items.Add(chestKey);

    }
}
