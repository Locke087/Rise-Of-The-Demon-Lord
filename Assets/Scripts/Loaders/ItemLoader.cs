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

    }
}
