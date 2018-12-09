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
        //--------------------------------AXES-----------------------------------
        UnitWeaponDetails battleAxe = new UnitWeaponDetails();
        battleAxe.might = 10;
        battleAxe.weight = 7;
        battleAxe.hitrate = 65;
        battleAxe.critrate = 3;
        battleAxe.critchance = 1;
        battleAxe.name = "Battle Axe";
        battleAxe.unlocks = "Smite";
        battleAxe.rank = 2;
        battleAxe.range = 1;
        battleAxe.physical = true;
        battleAxe.type = "Axes";
        if (sw == battleAxe.name) u.details = battleAxe;

        UnitWeaponDetails waraxe = new UnitWeaponDetails();
        waraxe.might = 13;
        waraxe.weight = 10;
        waraxe.hitrate = 60;
        waraxe.critrate = 3;
        waraxe.critchance = 1;
        waraxe.name = "War Axe";
        waraxe.unlocks = "Smite";
        waraxe.rank = 2;
        waraxe.range = 1;
        waraxe.physical = true;
        waraxe.type = "Axes";
        if (sw == waraxe.name) u.details = waraxe;

        UnitWeaponDetails greatAxe = new UnitWeaponDetails();
        greatAxe.might = 15;
        greatAxe.weight = 12;
        greatAxe.hitrate = 55;
        greatAxe.critrate = 3;
        greatAxe.critchance = 1;
        greatAxe.name = "Great Axe";
        greatAxe.unlocks = "Smite";
        greatAxe.rank = 3;
        greatAxe.range = 1;
        greatAxe.physical = true;
        greatAxe.type = "Axes";
        if (sw == greatAxe.name) u.details = greatAxe;

        UnitWeaponDetails demonAxe = new UnitWeaponDetails();
        demonAxe.might = 17;
        demonAxe.weight = 14;
        demonAxe.hitrate = 55;
        demonAxe.critrate = 3;
        demonAxe.critchance = 1;
        demonAxe.name = "Demon Axe";
        demonAxe.unlocks = "Smite";
        demonAxe.rank = 3;
        demonAxe.range = 1;
        demonAxe.effects.darkDamage = true;
        demonAxe.type = "Axes";
        if (sw == demonAxe.name) u.details = demonAxe;

        UnitWeaponDetails warhammer = new UnitWeaponDetails();
        warhammer.might = 14;
        warhammer.weight = 12;
        warhammer.hitrate = 65;
        warhammer.critrate = 3;
        warhammer.critchance = 1;
        warhammer.name = "Warhammer";
        warhammer.unlocks = "Smite";
        warhammer.rank = 2;
        warhammer.range = 1;
        warhammer.physical = true;
        warhammer.type = "Axes";
        if (sw == warhammer.name) u.details = warhammer;

        UnitWeaponDetails mattock = new UnitWeaponDetails();
        mattock.might = 16;
        mattock.weight = 13;
        mattock.hitrate = 60;
        mattock.critrate = 3;
        mattock.critchance = 1;
        mattock.name = "Mattock";
        mattock.unlocks = "Smite";
        mattock.rank = 2;
        mattock.range = 1;
        mattock.physical = true;
        mattock.type = "Axes";
        if (sw == mattock.name) u.details = mattock;

        UnitWeaponDetails earthBreaker = new UnitWeaponDetails();
        earthBreaker.might = 18;
        earthBreaker.weight = 14;
        earthBreaker.hitrate = 60;
        earthBreaker.critrate = 3;
        earthBreaker.critchance = 1;
        earthBreaker.name = "Earth Breaker";
        earthBreaker.unlocks = "Smite";
        earthBreaker.rank = 3;
        earthBreaker.range = 1;
        earthBreaker.effects.earthDamage = true;
        earthBreaker.type = "Axes";
        if (sw == earthBreaker.name) u.details = earthBreaker;

        UnitWeaponDetails titansMaul = new UnitWeaponDetails();
        titansMaul.might = 20;
        titansMaul.weight = 16;
        titansMaul.hitrate = 60;
        titansMaul.critrate = 3;
        titansMaul.critchance = 1;
        titansMaul.name = "Titans Maul";
        titansMaul.unlocks = "Smite";
        titansMaul.rank = 3;
        titansMaul.range = 1;
        titansMaul.magic = true;
        titansMaul.effects.metalDamage = true;
        titansMaul.type = "Axes";
        if (sw == titansMaul.name) u.details = titansMaul;

        //--------------------------------------------RANGED--------------------------------
        UnitWeaponDetails rifle = new UnitWeaponDetails();
        rifle.might = 10;
        rifle.weight = 10;
        rifle.hitrate = 75;
        rifle.critrate = 3;
        rifle.critchance = 1;
        rifle.name = "Rifle";
        rifle.unlocks = "Deadeye";
        rifle.rank = 2;
        rifle.range = 6;
        rifle.type = "Ranged";
        rifle.physical = true;
        if (sw == rifle.name) u.details = rifle;


        //Heavy Blades
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
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails lightingSword = new UnitWeaponDetails();
        lightingSword.might = 10;
        lightingSword.weight = 7;
        lightingSword.hitrate = 60;
        lightingSword.critrate = 3;
        lightingSword.critchance = 1;
        lightingSword.name = "Lighting Sword";
        lightingSword.unlocks = "SwordMaster1";
        lightingSword.rank = 3;
        lightingSword.range = 2;
        lightingSword.type = "HeavyBlade";
        lightingSword.magic = true;
        if (sw == lightingSword.name) u.details = lightingSword;

        UnitWeaponDetails bastardSword = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails falchion = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails greatSword = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails executionersSword = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails endEdge = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails runeBlade = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.magic = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;



        //--------------------------------------------Light Blades--------------------------------------------

        UnitWeaponDetails estoc = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails sabre = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails swordCane = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails scimitar = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails spiralBalde = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails razorWhip = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails katana = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails piercer = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "LightBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;


        //--------------------------------------------Spears--------------------------------------------




        //--------------------------------------------Close--------------------------------------------







        //--------------------------------------------Staves--------------------------------------------




        //--------------------------------------------Tomes--------------------------------------------





        //--------------------------------------------Athames--------------------------------------------


    }
    public static List<UnitWeapon> ChestWeapons()
    {

        List<UnitWeapon> weapons = new List<UnitWeapon>();
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
        weapons.Add(vemonBlade);
       
        //Axes
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
        weapons.Add(warhammer);
      
        //Ranged
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
        weapons.Add(rifle);

        UnitWeapon lightingSword = new UnitWeapon();
        rifle.name = "Lighting Sword";
        rifle.cost = 230;
        lightingSword.details.might = 10;
        lightingSword.details.weight = 7;
        lightingSword.details.hitrate = 60;
        lightingSword.details.critrate = 3;
        lightingSword.details.critchance = 1;
        lightingSword.details.name = "Lighting Sword";
        lightingSword.details.unlocks = "SwordMaster1";
        lightingSword.details.rank = 3;
        lightingSword.details.range = 2;
        lightingSword.details.type = "HeavyBlade";
        lightingSword.details.magic = true;
        lightingSword.idx = "Lighting Sword" + IDMaker.NewID();
        weapons.Add(lightingSword);

        return weapons;
    }


    public static UnitWeapon RandomWeapon()
    {

        List<UnitWeapon> weapons = new List<UnitWeapon>();
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
        weapons.Add(vemonBlade);

        //Axes
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
        weapons.Add(warhammer);

        //Ranged
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
        weapons.Add(rifle);

        UnitWeapon lightingSword = new UnitWeapon();
        rifle.name = "Lighting Sword";
        rifle.cost = 230;
        lightingSword.details.might = 10;
        lightingSword.details.weight = 7;
        lightingSword.details.hitrate = 60;
        lightingSword.details.critrate = 3;
        lightingSword.details.critchance = 1;
        lightingSword.details.name = "Lighting Sword";
        lightingSword.details.unlocks = "SwordMaster1";
        lightingSword.details.rank = 3;
        lightingSword.details.range = 2;
        lightingSword.details.type = "HeavyBlade";
        lightingSword.details.magic = true;
        lightingSword.idx = "Lighting Sword" + IDMaker.NewID();
        weapons.Add(lightingSword);

        int i = Random.Range(0, weapons.Count);
        return weapons[i];
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

        UnitWeapon lightingSword = new UnitWeapon();
        lightingSword.name = "Lighting Sword";
        lightingSword.cost = 230;
        lightingSword.details.might = 10;
        lightingSword.details.weight = 7;
        lightingSword.details.hitrate = 60;
        lightingSword.details.critrate = 3;
        lightingSword.details.critchance = 1;
        lightingSword.details.name = "Lighting Sword";
        lightingSword.details.unlocks = "SwordMaster1";
        lightingSword.details.rank = 3;
        lightingSword.details.range = 2;
        lightingSword.details.type = "HeavyBlade";
        lightingSword.details.magic = true;
        lightingSword.idx = "Lighting Sword" + IDMaker.NewID();

        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(lightingSword);
        CurrentGame.game.memoryGeneral.shopWares.weapons.Add(lightingSword);
      
    }

}
