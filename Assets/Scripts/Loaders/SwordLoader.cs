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
        battleAxe.might = 11;
        battleAxe.weight = 7;
        battleAxe.hitrate = 65;
        battleAxe.critrate = 3;
        battleAxe.critchance = 1;
        battleAxe.name = "Battle Axe";
        //---------------Warrior-------------
        battleAxe.unlocks = "Wild Strike";
        battleAxe.moreUnlocks.Add("Double-Edged");
        battleAxe.moreUnlocks.Add("Counter");
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
        //---------------Cavalier-------------
        waraxe.unlocks = "Trample";
        waraxe.moreUnlocks.Add("Flanking");
        waraxe.moreUnlocks.Add("Retaliate");
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
        //---------------Knight-----------------
        greatAxe.unlocks = "Knight's Challenge";
        greatAxe.moreUnlocks.Add("Pommel Strike");
        greatAxe.moreUnlocks.Add("Black Sword Strike");
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
        //----------------Dark Knight----------
        demonAxe.unlocks = "Darkness";
        demonAxe.moreUnlocks.Add("Darkrift");
        demonAxe.moreUnlocks.Add("Sacrificial Blade");
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
        //----------------Priest---------------------
        warhammer.unlocks = "Smite";
        warhammer.moreUnlocks.Add("Divine Protection");
        warhammer.moreUnlocks.Add("Pray");
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
        //---------------Paladin--------------
        mattock.unlocks = "Judgement";
        mattock.moreUnlocks.Add("Mercy");
        mattock.moreUnlocks.Add("Might of Heaven");
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
        //earthBreaker.unlocks = "Smite";
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
        //titansMaul.unlocks = "Smite";
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

        UnitWeaponDetails flintlock = new UnitWeaponDetails();
        waraxe.might = 13;
        waraxe.weight = 10;
        waraxe.hitrate = 60;
        waraxe.critrate = 3;
        waraxe.critchance = 1;
        waraxe.name = "War Axe";
        //---------------Cavalier-------------
        waraxe.unlocks = "Trample";
        waraxe.moreUnlocks.Add("Flanking");
        waraxe.moreUnlocks.Add("Retaliate");
        waraxe.rank = 2;
        waraxe.range = 1;
        waraxe.physical = true;
        waraxe.type = "Axes";
        if (sw == waraxe.name) u.details = waraxe;

        UnitWeaponDetails blunderbuss = new UnitWeaponDetails();
        greatAxe.might = 15;
        greatAxe.weight = 12;
        greatAxe.hitrate = 55;
        greatAxe.critrate = 3;
        greatAxe.critchance = 1;
        greatAxe.name = "Great Axe";
        //---------------Knight-----------------
        greatAxe.unlocks = "Knight's Challenge";
        greatAxe.moreUnlocks.Add("Pommel Strike");
        greatAxe.moreUnlocks.Add("Black Sword Strike");
        greatAxe.rank = 3;
        greatAxe.range = 1;
        greatAxe.physical = true;
        greatAxe.type = "Axes";
        if (sw == greatAxe.name) u.details = greatAxe;

        UnitWeaponDetails cannon = new UnitWeaponDetails();
        demonAxe.might = 17;
        demonAxe.weight = 14;
        demonAxe.hitrate = 55;
        demonAxe.critrate = 3;
        demonAxe.critchance = 1;
        demonAxe.name = "Demon Axe";
        //----------------Dark Knight----------
        demonAxe.unlocks = "Darkness";
        demonAxe.moreUnlocks.Add("Darkrift");
        demonAxe.moreUnlocks.Add("Sacrificial Blade");
        demonAxe.rank = 3;
        demonAxe.range = 1;
        demonAxe.effects.darkDamage = true;
        demonAxe.type = "Axes";
        if (sw == demonAxe.name) u.details = demonAxe;

        UnitWeaponDetails shortbow = new UnitWeaponDetails();
        warhammer.might = 14;
        warhammer.weight = 12;
        warhammer.hitrate = 65;
        warhammer.critrate = 3;
        warhammer.critchance = 1;
        warhammer.name = "Warhammer";
        //----------------Priest---------------------
        warhammer.unlocks = "Smite";
        warhammer.moreUnlocks.Add("Divine Protection");
        warhammer.moreUnlocks.Add("Pray");
        warhammer.rank = 2;
        warhammer.range = 1;
        warhammer.physical = true;
        warhammer.type = "Axes";
        if (sw == warhammer.name) u.details = warhammer;

        UnitWeaponDetails longbow = new UnitWeaponDetails();
        mattock.might = 16;
        mattock.weight = 13;
        mattock.hitrate = 60;
        mattock.critrate = 3;
        mattock.critchance = 1;
        mattock.name = "Mattock";
        //---------------Paladin--------------
        mattock.unlocks = "Judgement";
        mattock.moreUnlocks.Add("Mercy");
        mattock.moreUnlocks.Add("Might of Heaven");
        mattock.rank = 2;
        mattock.range = 1;
        mattock.physical = true;
        mattock.type = "Axes";
        if (sw == mattock.name) u.details = mattock;

        UnitWeaponDetails greatbow = new UnitWeaponDetails();
        earthBreaker.might = 18;
        earthBreaker.weight = 14;
        earthBreaker.hitrate = 60;
        earthBreaker.critrate = 3;
        earthBreaker.critchance = 1;
        earthBreaker.name = "Earth Breaker";
        //earthBreaker.unlocks = "Smite";
        earthBreaker.rank = 3;
        earthBreaker.range = 1;
        earthBreaker.effects.earthDamage = true;
        earthBreaker.type = "Axes";
        if (sw == earthBreaker.name) u.details = earthBreaker;

        UnitWeaponDetails shockcaster = new UnitWeaponDetails();
        titansMaul.might = 20;
        titansMaul.weight = 16;
        titansMaul.hitrate = 60;
        titansMaul.critrate = 3;
        titansMaul.critchance = 1;
        titansMaul.name = "Titans Maul";
        //titansMaul.unlocks = "Smite";
        titansMaul.rank = 3;
        titansMaul.range = 1;
        titansMaul.magic = true;
        titansMaul.effects.metalDamage = true;
        titansMaul.type = "Axes";
        if (sw == titansMaul.name) u.details = titansMaul;




        //-----------------------------Heavy Blades------------------------------------
        UnitWeaponDetails vemonBlade = new UnitWeaponDetails();
        vemonBlade.might = 12;
        vemonBlade.weight = 8;
        vemonBlade.hitrate = 65;
        vemonBlade.critrate = 3;
        vemonBlade.critchance = 1;
        vemonBlade.effects.poison = true;
        vemonBlade.name = "Vemon Blade";
        //------------------Dread----------------
        vemonBlade.unlocks = "Endarken";
        vemonBlade.moreUnlocks.Add("Feed the Darkness");
        vemonBlade.moreUnlocks.Add("Viciousness");
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
        //lightningSword.unlocks = "Blitz";
        lightningSword.rank = 3;
        lightningSword.range = 2;
        lightningSword.type = "HeavyBlade";
        lightningSword.magic = true;
        lightningSword.effects.natureDamage = true;
        if (sw == lightningSword.name) u.details = lightningSword;

        UnitWeaponDetails bastardSword = new UnitWeaponDetails();
        bastardSword.might = 13;
        bastardSword.weight = 7;
        bastardSword.hitrate = 65;
        bastardSword.critrate = 3;
        bastardSword.critchance = 1;
        bastardSword.name = "Bastard Sword";
        //-------------warrior--------------
        bastardSword.unlocks = "Lunge";
        bastardSword.unlocks = "Blitz";
        bastardSword.moreUnlocks.Add("Focused");
        bastardSword.moreUnlocks.Add("Bullrush");
        bastardSword.rank = 2;
        bastardSword.range = 1;
        bastardSword.type = "HeavyBlade";
        bastardSword.physical = true;
        if (sw == bastardSword.name) u.details = bastardSword;

        UnitWeaponDetails falchion = new UnitWeaponDetails();
        falchion.might = 15;
        falchion.weight = 10;
        falchion.hitrate = 65;
        falchion.critrate = 3;
        falchion.critchance = 1;
        falchion.name = "Falchion";
        //------------------knight---------------
        falchion.unlocks = "Shield Bash";
        falchion.moreUnlocks.Add("Guard");
        falchion.moreUnlocks.Add("Armor Spikes");
        falchion.rank = 2;
        falchion.range = 1;
        falchion.type = "HeavyBlade";
        falchion.physical = true;
        if (sw == falchion.name) u.details = falchion;

        UnitWeaponDetails greatSword = new UnitWeaponDetails();
        greatSword.might = 17;
        greatSword.weight = 12;
        greatSword.hitrate = 65;
        greatSword.critrate = 3;
        greatSword.critchance = 1;
        greatSword.name = "Great Sword";
        //-----------------Charger-------------------
        greatSword.unlocks = "Hammer and Nail";
        greatSword.moreUnlocks.Add("Helm Cleaver");
        greatSword.moreUnlocks.Add("Ring the Bell");
        greatSword.rank = 3;
        greatSword.range = 1;
        greatSword.type = "HeavyBlade";
        greatSword.physical = true;
        if (sw == greatSword.name) u.details = greatSword;

        UnitWeaponDetails executionersSword = new UnitWeaponDetails();
        executionersSword.might = 15;
        executionersSword.weight = 11;
        executionersSword.hitrate = 65;
        executionersSword.critrate = 3;
        executionersSword.critchance = 1;
        executionersSword.name = "Executioners Sword";
        //executionersSword.unlocks = "Blitz";
        executionersSword.rank = 3;
        executionersSword.range = 1;
        executionersSword.type = "HeavyBlade";
        executionersSword.magic = true;
        executionersSword.effects.metalDamage = true;
        if (sw == executionersSword.name) u.details = executionersSword;

        UnitWeaponDetails endEdge = new UnitWeaponDetails();
        endEdge.might = 14;
        endEdge.weight = 10;
        endEdge.hitrate = 65;
        endEdge.critrate = 3;
        endEdge.critchance = 1;
        endEdge.name = "End Edge";
        //-----------------Demon Rider-----------
        endEdge.unlocks = "Invidious";
        endEdge.moreUnlocks.Add("Black Sword");
        endEdge.moreUnlocks.Add("Dark Protection");
        endEdge.rank = 3;
        endEdge.range = 1;
        endEdge.type = "HeavyBlade";
        endEdge.magic = true;
        endEdge.effects.darkDamage = true;
        if (sw == endEdge.name) u.details = endEdge;

        UnitWeaponDetails runeBlade = new UnitWeaponDetails();
        runeBlade.might = 17;
        runeBlade.weight = 13;
        runeBlade.hitrate = 65;
        runeBlade.critrate = 3;
        runeBlade.critchance = 1;
        runeBlade.name = "Rune Blade";
        //runeBlade.unlocks = "Blitz";
        runeBlade.rank = 3;
        runeBlade.range = 1;
        runeBlade.type = "HeavyBlade";
        runeBlade.magic = true;
        runeBlade.effects.earthDamage = true;
        if (sw == runeBlade.name) u.details = runeBlade;



        //--------------------------------------------Light Blades--------------------------------------------
        UnitWeaponDetails estoc = new UnitWeaponDetails();
        estoc.might = 12;
        estoc.weight = 8;
        estoc.hitrate = 65;
        estoc.critrate = 3;
        estoc.critchance = 1;
        estoc.effects.poison = true;
        estoc.name = "Estoc";
        estoc.unlocks = "Blitz";
        estoc.rank = 2;
        estoc.range = 1;
        estoc.type = "LightBlade";
        estoc.physical = true;
        if (sw == estoc.name) u.details = estoc;

        UnitWeaponDetails sabre = new UnitWeaponDetails();
        sabre.might = 12;
        sabre.weight = 8;
        sabre.hitrate = 65;
        sabre.critrate = 3;
        sabre.critchance = 1;
        sabre.effects.poison = true;
        sabre.name = "Sabre";
        sabre.unlocks = "Blitz";
        sabre.rank = 2;
        sabre.range = 1;
        sabre.type = "LightBlade";
        sabre.physical = true;
        if (sw == sabre.name) u.details = sabre;

        UnitWeaponDetails swordCane = new UnitWeaponDetails();
        swordCane.might = 12;
        swordCane.weight = 8;
        swordCane.hitrate = 65;
        swordCane.critrate = 3;
        swordCane.critchance = 1;
        swordCane.effects.poison = true;
        swordCane.name = "Sword Cane";
        swordCane.unlocks = "Blitz";
        swordCane.rank = 2;
        swordCane.range = 1;
        swordCane.type = "LightBlade";
        swordCane.physical = true;
        if (sw == swordCane.name) u.details = swordCane;

        UnitWeaponDetails scimitar = new UnitWeaponDetails();
        scimitar.might = 12;
        scimitar.weight = 8;
        scimitar.hitrate = 65;
        scimitar.critrate = 3;
        scimitar.critchance = 1;
        scimitar.effects.poison = true;
        scimitar.name = "Scimitar";
        scimitar.unlocks = "Blitz";
        scimitar.rank = 2;
        scimitar.range = 1;
        scimitar.type = "LightBlade";
        scimitar.physical = true;
        if (sw == scimitar.name) u.details = scimitar;

        UnitWeaponDetails spiralBalde = new UnitWeaponDetails();
        spiralBalde.might = 12;
        spiralBalde.weight = 8;
        spiralBalde.hitrate = 65;
        spiralBalde.critrate = 3;
        spiralBalde.critchance = 1;
        spiralBalde.effects.poison = true;
        spiralBalde.name = "Spiral Balde";
        spiralBalde.unlocks = "Blitz";
        spiralBalde.rank = 2;
        spiralBalde.range = 1;
        spiralBalde.type = "LightBlade";
        spiralBalde.physical = true;
        if (sw == spiralBalde.name) u.details = spiralBalde;

        UnitWeaponDetails razorWhip = new UnitWeaponDetails();
        razorWhip.might = 12;
        razorWhip.weight = 8;
        razorWhip.hitrate = 65;
        razorWhip.critrate = 3;
        razorWhip.critchance = 1;
        razorWhip.effects.poison = true;
        razorWhip.name = "Razor Whip";
        razorWhip.unlocks = "Blitz";
        razorWhip.rank = 2;
        razorWhip.range = 1;
        razorWhip.type = "LightBlade";
        razorWhip.physical = true;
        if (sw == razorWhip.name) u.details = razorWhip;

        UnitWeaponDetails katana = new UnitWeaponDetails();
        katana.might = 12;
        katana.weight = 8;
        katana.hitrate = 65;
        katana.critrate = 3;
        katana.critchance = 1;
        katana.effects.poison = true;
        katana.name = "Katana";
        katana.unlocks = "Blitz";
        katana.rank = 2;
        katana.range = 1;
        katana.type = "LightBlade";
        katana.physical = true;
        if (sw == katana.name) u.details = katana;

        UnitWeaponDetails piercer = new UnitWeaponDetails();
        piercer.might = 12;
        piercer.weight = 8;
        piercer.hitrate = 65;
        piercer.critrate = 3;
        piercer.critchance = 1;
        piercer.effects.poison = true;
        piercer.name = "Piercer";
        piercer.unlocks = "Blitz";
        piercer.rank = 2;
        piercer.range = 1;
        piercer.type = "LightBlade";
        piercer.physical = true;
        if (sw == piercer.name) u.details = piercer;


        //--------------------------------------------Spears--------------------------------------------
        UnitWeaponDetails shortspear = new UnitWeaponDetails();
        shortspear.might = 12;
        shortspear.weight = 8;
        shortspear.hitrate = 65;
        shortspear.critrate = 3;
        shortspear.critchance = 1;
        shortspear.effects.poison = true;
        shortspear.name = "Shortspear";
        shortspear.unlocks = "Blitz";
        shortspear.rank = 2;
        shortspear.range = 1;
        shortspear.type = "Spear";
        shortspear.physical = true;
        if (sw == shortspear.name) u.details = shortspear;

        UnitWeaponDetails longspear = new UnitWeaponDetails();
        longspear.might = 12;
        longspear.weight = 8;
        longspear.hitrate = 65;
        longspear.critrate = 3;
        longspear.critchance = 1;
        longspear.effects.poison = true;
        longspear.name = "Longspear";
        longspear.unlocks = "Blitz";
        longspear.rank = 2;
        longspear.range = 1;
        longspear.type = "Spear";
        longspear.physical = true;
        if (sw == longspear.name) u.details = longspear;

        UnitWeaponDetails broadspear = new UnitWeaponDetails();
        broadspear.might = 12;
        broadspear.weight = 8;
        broadspear.hitrate = 65;
        broadspear.critrate = 3;
        broadspear.critchance = 1;
        broadspear.effects.poison = true;
        broadspear.name = "Broadspear";
        broadspear.unlocks = "Blitz";
        broadspear.rank = 2;
        broadspear.range = 1;
        broadspear.type = "Spear";
        broadspear.physical = true;
        if (sw == broadspear.name) u.details = broadspear;

        UnitWeaponDetails glaive = new UnitWeaponDetails();
        glaive.might = 12;
        glaive.weight = 8;
        glaive.hitrate = 65;
        glaive.critrate = 3;
        glaive.critchance = 1;
        glaive.effects.poison = true;
        glaive.name = "Glaive";
        glaive.unlocks = "Blitz";
        glaive.rank = 2;
        glaive.range = 1;
        glaive.type = "Spear";
        glaive.physical = true;
        if (sw == glaive.name) u.details = glaive;

        UnitWeaponDetails halberd = new UnitWeaponDetails();
        halberd.might = 12;
        halberd.weight = 8;
        halberd.hitrate = 65;
        halberd.critrate = 3;
        halberd.critchance = 1;
        halberd.effects.poison = true;
        halberd.name = "Halberd";
        halberd.unlocks = "Blitz";
        halberd.rank = 2;
        halberd.range = 1;
        halberd.type = "Spear";
        halberd.physical = true;
        if (sw == halberd.name) u.details = halberd;

        UnitWeaponDetails scythe = new UnitWeaponDetails();
        scythe.might = 12;
        scythe.weight = 8;
        scythe.hitrate = 65;
        scythe.critrate = 3;
        scythe.critchance = 1;
        scythe.effects.poison = true;
        scythe.name = "Scythe";
        scythe.unlocks = "Blitz";
        scythe.rank = 2;
        scythe.range = 1;
        scythe.type = "Spear";
        scythe.physical = true;
        if (sw == scythe.name) u.details = scythe;

        UnitWeaponDetails bardiche = new UnitWeaponDetails();
        bardiche.might = 12;
        bardiche.weight = 8;
        bardiche.hitrate = 65;
        bardiche.critrate = 3;
        bardiche.critchance = 1;
        bardiche.effects.poison = true;
        bardiche.name = "Bardiche";
        bardiche.unlocks = "Blitz";
        bardiche.rank = 2;
        bardiche.range = 1;
        bardiche.type = "Spear";
        bardiche.physical = true;
        if (sw == bardiche.name) u.details = bardiche;

        UnitWeaponDetails romphia = new UnitWeaponDetails();
        romphia.might = 12;
        romphia.weight = 8;
        romphia.hitrate = 65;
        romphia.critrate = 3;
        romphia.critchance = 1;
        romphia.effects.poison = true;
        romphia.name = "Romphia";
        romphia.unlocks = "Blitz";
        romphia.rank = 2;
        romphia.range = 1;
        romphia.type = "Spear";
        romphia.physical = true;
        if (sw == romphia.name) u.details = romphia;



        //--------------------------------------------Close--------------------------------------------
        UnitWeaponDetails kukri = new UnitWeaponDetails();
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

        UnitWeaponDetails machete = new UnitWeaponDetails();
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

        UnitWeaponDetails swordBreaker = new UnitWeaponDetails();
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

        UnitWeaponDetails dagger = new UnitWeaponDetails();
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

        UnitWeaponDetails warRazor = new UnitWeaponDetails();
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

        UnitWeaponDetails mainGauche = new UnitWeaponDetails();
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

        UnitWeaponDetails misericorde = new UnitWeaponDetails();
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

        UnitWeaponDetails starblade = new UnitWeaponDetails();
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
        UnitWeaponDetails voidCodex = new UnitWeaponDetails();
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

        UnitWeaponDetails sihedron = new UnitWeaponDetails();
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

        UnitWeaponDetails manualArcanum = new UnitWeaponDetails();
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

        UnitWeaponDetails acolytesWorkbook = new UnitWeaponDetails();
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

        UnitWeaponDetails wizardsTome = new UnitWeaponDetails();
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

        UnitWeaponDetails bookOfHours = new UnitWeaponDetails();
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

        UnitWeaponDetails initiatesNotes = new UnitWeaponDetails();
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

        UnitWeaponDetails mastersPages = new UnitWeaponDetails();
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




        //--------------------------------------------Athames--------------------------------------------
        UnitWeaponDetails sickle = new UnitWeaponDetails();
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

        UnitWeaponDetails pactblade = new UnitWeaponDetails();
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

        UnitWeaponDetails reaper = new UnitWeaponDetails();
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

        UnitWeaponDetails bloodAthame = new UnitWeaponDetails();
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

        UnitWeaponDetails blackMercy = new UnitWeaponDetails();
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

        UnitWeaponDetails eternityShard = new UnitWeaponDetails();
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

        UnitWeaponDetails shatteredDream = new UnitWeaponDetails();
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

        UnitWeaponDetails entropysGrasp = new UnitWeaponDetails();
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
