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
        battleAxe.unlocks = "Wild Strike";
        battleAxe.unlocks = "Trample";
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
        waraxe.unlocks = "Double-Edged";
        waraxe.unlocks = "Flanking";
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
        greatAxe.unlocks = "Counter";
        greatAxe.unlocks = "Retaliate";
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
        mattock.unlocks = "Divine Protection";
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


        //-----------------------------Heavy Blades------------------------------------
        UnitWeaponDetails vemonBlade = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Focused";
        vemonBlade.unlocks = "Feed the Darkness";
        vemonBlade.unlocks = "";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;


        UnitWeaponDetails lightningSword = new UnitWeaponDetails();
        lightningSword.might = 10;
        lightningSword.weight = 7;
        lightningSword.hitrate = 60;
        lightningSword.critrate = 3;
        lightningSword.critchance = 1;
        lightningSword.name = "Lightning Sword";
        lightningSword.unlocks = "SwordMaster1";
        lightningSword.unlocks = "Blitz";
        lightningSword.rank = 3;
        lightningSword.range = 2;
        lightningSword.type = "HeavyBlade";
        lightningSword.magic = true;
        if (sw == lightningSword.name) u.details = lightningSword;

        UnitWeaponDetails bastardSword = new UnitWeaponDetails();
        bastardSword.might = 12;
        bastardSword.weight = 8;
        bastardSword.hitrate = 65;
        bastardSword.critrate = 3;
        bastardSword.critchance = 1;
        bastardSword.name = "Bastard Sword";
        bastardSword.unlocks = "Lunge";
        bastardSword.unlocks = "Endarken";
        bastardSword.rank = 2;
        bastardSword.range = 1;
        bastardSword.type = "HeavyBlade";
        bastardSword.physical = true;
        if (sw == bastardSword.name) u.details = bastardSword;

        UnitWeaponDetails falchion = new UnitWeaponDetails();
        falchion.might = 12;
        falchion.weight = 8;
        falchion.hitrate = 65;
        falchion.critrate = 3;
        falchion.critchance = 1;
        falchion.name = "Falchion";
        falchion.unlocks = "Bullrush";
        falchion.unlocks = "Viciousness";
        falchion.rank = 2;
        falchion.range = 1;
        falchion.type = "HeavyBlade";
        falchion.physical = true;
        if (sw == falchion.name) u.details = falchion;

        UnitWeaponDetails greatSword = new UnitWeaponDetails();
        greatSword.might = 12;
        greatSword.weight = 8;
        greatSword.hitrate = 65;
        greatSword.critrate = 3;
        greatSword.critchance = 1;
        greatSword.name = "Great Sword";
        greatSword.unlocks = "Blitz";
        greatSword.rank = 3;
        greatSword.range = 1;
        greatSword.type = "HeavyBlade";
        greatSword.physical = true;
        if (sw == greatSword.name) u.details = greatSword;

        UnitWeaponDetails executionersSword = new UnitWeaponDetails();
        executionersSword.might = 12;
        executionersSword.weight = 8;
        executionersSword.hitrate = 65;
        executionersSword.critrate = 3;
        executionersSword.critchance = 1;
        executionersSword.name = "Executioners Sword";
        executionersSword.unlocks = "Blitz";
        executionersSword.rank = 3;
        executionersSword.range = 1;
        executionersSword.type = "HeavyBlade";
        executionersSword.physical = true;
        if (sw == executionersSword.name) u.details = executionersSword;

        UnitWeaponDetails endEdge = new UnitWeaponDetails();
        endEdge.might = 12;
        endEdge.weight = 8;
        endEdge.hitrate = 65;
        endEdge.critrate = 3;
        endEdge.critchance = 1;
        endEdge.name = "End Edge";
        endEdge.unlocks = "Blitz";
        endEdge.rank = 3;
        endEdge.range = 1;
        endEdge.type = "HeavyBlade";
        endEdge.physical = true;
        if (sw == endEdge.name) u.details = endEdge;

        UnitWeaponDetails runeBlade = new UnitWeaponDetails();
        runeBlade.might = 12;
        runeBlade.weight = 8;
        runeBlade.hitrate = 65;
        runeBlade.critrate = 3;
        runeBlade.critchance = 1;
        runeBlade.name = "Rune Blade";
        runeBlade.unlocks = "Blitz";
        runeBlade.rank = 3;
        runeBlade.range = 1;
        runeBlade.type = "HeavyBlade";
        runeBlade.magic = true;
        if (sw == runeBlade.name) u.details = runeBlade;



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
        UnitWeaponDetails cudgel = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Cudgel";
        vemonBlade.unlocks = "Dark Blast";
        vemonBlade.unlocks = "";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;


        UnitWeaponDetails mace = new UnitWeaponDetails();
        lightningSword.might = 10;
        lightningSword.weight = 7;
        lightningSword.hitrate = 60;
        lightningSword.critrate = 3;
        lightningSword.critchance = 1;
        lightningSword.name = "Mace";
        lightningSword.unlocks = "Darkbolt";
        lightningSword.unlocks = "Pray";
        lightningSword.rank = 3;
        lightningSword.range = 2;
        lightningSword.type = "HeavyBlade";
        lightningSword.magic = true;
        if (sw == lightningSword.name) u.details = lightningSword;

        UnitWeaponDetails ironBar = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Iron Bar";
        vemonBlade.unlocks = "Fear";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails caudice = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Caudice";
        vemonBlade.unlocks = "Shade Pulse";
        vemonBlade.unlocks = "Purify";
        vemonBlade.rank = 2;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails heavensWrath = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        vemonBlade.unlocks = "Blitz";
        vemonBlade.rank = 3;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails goldenRule = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Golden Rule";
        vemonBlade.unlocks = "Breath of Life";
        vemonBlade.rank = 3;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails holyRod = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Holy Rod";
        vemonBlade.unlocks = "Healing Light";
        vemonBlade.rank = 3;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.physical = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;

        UnitWeaponDetails luminary = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Luminary";
        vemonBlade.unlocks = "Divine Mastery";
        vemonBlade.rank = 3;
        vemonBlade.range = 1;
        vemonBlade.type = "HeavyBlade";
        vemonBlade.magic = true;
        if (sw == vemonBlade.name) u.details = vemonBlade;



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
