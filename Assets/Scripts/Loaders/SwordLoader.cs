using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    
    

    public static void AssignSword(string sw, UnitWeapon u)
    {
        UnitWeaponDetails warhammer = new UnitWeaponDetails();
        warhammer.might = 14;
        warhammer.weight = 10;
        warhammer.hitrate = 55;
        warhammer.critrate = 3;
        warhammer.critchance = 1;
        warhammer.name = "Warhammer";
        warhammer.unlocks = "Smite";
        warhammer.rank = 2;
        warhammer.type = "Axes";
        if (sw == warhammer.name) u.details = warhammer;

        UnitWeaponDetails rifle = new UnitWeaponDetails();
        rifle.might = 10;
        rifle.weight = 10;
        rifle.hitrate = 75;
        rifle.critrate = 3;
        rifle.critchance = 1;
        rifle.name = "Rifle";
        rifle.unlocks = "Deadeye";
        rifle.rank = 2;
        rifle.type = "Ranged";
        if (sw == rifle.name) u.details = rifle;

        UnitWeaponDetails vemonBlade = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.type = "HeavyBlade";
        if (sw == vemonBlade.name) u.details = vemonBlade;

    }

    public static void StartingInventoryWeapon()
    {

        ///  if (a == vemonBlade.name) u.details = vemonBlade;
        UnitWeapon vemonBlade = new UnitWeapon();
        vemonBlade.name = "Vemon Blade";
        vemonBlade.cost = 200;
        vemonBlade.details.might = 12;
        vemonBlade.details.weight = 8;
        vemonBlade.details.hitrate = 65;
        vemonBlade.details.critrate = 3;
        vemonBlade.details.critchance = 1;
        vemonBlade.details.effects.poison = true;
        vemonBlade.details.physical = true;
        vemonBlade.details.name = "Vemon Blade";
        vemonBlade.details.type = "HeavyBlade";
        vemonBlade.details.rank = 2;
        vemonBlade.details.range = 1;
        vemonBlade.details.unlocks = "Blitz";      
        vemonBlade.idx = "Vemon Blade" + IDMaker.NewID();
        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(vemonBlade);
        CurrentGame.game.memoryGeneral.shopWares.weapons.Add(vemonBlade);

        UnitWeapon warhammer = new UnitWeapon();
        warhammer.name = "Warhammer";
        warhammer.cost = 180;
        warhammer.details.might = 14;
        warhammer.details.weight = 10;
        warhammer.details.hitrate = 55;
        warhammer.details.critrate = 3;
        warhammer.details.critchance = 1;
        warhammer.details.physical = true;
        warhammer.details.name = "Warhammer";
        warhammer.details.type = "Axes";
        warhammer.details.rank = 2;
        warhammer.details.range = 1;
        warhammer.details.unlocks = "Smite";
        warhammer.idx = "Warhammer" + IDMaker.NewID();
        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(warhammer);
        CurrentGame.game.memoryGeneral.shopWares.weapons.Add(warhammer);

        UnitWeapon rifle = new UnitWeapon();
        rifle.name = "Rifle";
        rifle.cost = 230;
        rifle.details.might = 9;
        rifle.details.weight = 9;
        rifle.details.hitrate = 75;
        rifle.details.critrate = 3;
        rifle.details.critchance = 1;
        rifle.details.physical = true;
        rifle.details.name = "Rifle";
        rifle.details.type = "Ranged";
        rifle.details.rank = 3;
        rifle.details.range = 6;
        rifle.details.unlocks = "Deadeye";
        rifle.idx = "Rifle" + IDMaker.NewID();
        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(rifle);
        CurrentGame.game.memoryGeneral.shopWares.weapons.Add(rifle);

        
    }

}
