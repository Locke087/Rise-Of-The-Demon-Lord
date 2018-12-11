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
        kukri.might = 12;
        kukri.weight = 8;
        kukri.hitrate = 65;
        kukri.critrate = 3;
        kukri.critchance = 1;
        kukri.name = "Kukri";
        kukri.unlocks = "Blitz";
        kukri.rank = 2;
        kukri.range = 1;
        kukri.type = "Close";
        kukri.physical = true;
        if (sw == kukri.name) u.details = kukri;

        UnitWeaponDetails machete = new UnitWeaponDetails();
        machete.might = 12;
        machete.weight = 8;
        machete.hitrate = 65;
        machete.critrate = 3;
        machete.critchance = 1;
        machete.name = "Machete";
        machete.unlocks = "Blitz";
        machete.rank = 2;
        machete.range = 1;
        machete.type = "Close";
        machete.physical = true;
        if (sw == machete.name) u.details = machete;

        UnitWeaponDetails swordBreaker = new UnitWeaponDetails();
        swordBreaker.might = 12;
        swordBreaker.weight = 8;
        swordBreaker.hitrate = 65;
        swordBreaker.critrate = 3;
        swordBreaker.critchance = 1;
        swordBreaker.name = "Sword Breaker";
        swordBreaker.unlocks = "Blitz";
        swordBreaker.rank = 2;
        swordBreaker.range = 1;
        swordBreaker.type = "Close";
        swordBreaker.physical = true;
        if (sw == swordBreaker.name) u.details = swordBreaker;

        UnitWeaponDetails dagger = new UnitWeaponDetails();
        dagger.might = 12;
        dagger.weight = 8;
        dagger.hitrate = 65;
        dagger.critrate = 3;
        dagger.critchance = 1;
        dagger.name = "Dagger";
        dagger.unlocks = "Blitz";
        dagger.rank = 2;
        dagger.range = 1;
        dagger.type = "Close";
        dagger.physical = true;
        if (sw == dagger.name) u.details = dagger;

        UnitWeaponDetails warRazor = new UnitWeaponDetails();
        warRazor.might = 12;
        warRazor.weight = 8;
        warRazor.hitrate = 65;
        warRazor.critrate = 3;
        warRazor.critchance = 1;
        warRazor.name = "War Razor";
        warRazor.unlocks = "Blitz";
        warRazor.rank = 2;
        warRazor.range = 1;
        warRazor.type = "Close";
        warRazor.physical = true;
        if (sw == warRazor.name) u.details = warRazor;

        UnitWeaponDetails mainGauche = new UnitWeaponDetails();
        mainGauche.might = 12;
        mainGauche.weight = 8;
        mainGauche.hitrate = 65;
        mainGauche.critrate = 3;
        mainGauche.critchance = 1;
        mainGauche.name = "Main Gauche";
        mainGauche.unlocks = "Blitz";
        mainGauche.rank = 2;
        mainGauche.range = 1;
        mainGauche.type = "Close";
        mainGauche.physical = true;
        if (sw == mainGauche.name) u.details = mainGauche;

        UnitWeaponDetails misericorde = new UnitWeaponDetails();
        misericorde.might = 12;
        misericorde.weight = 8;
        misericorde.hitrate = 65;
        misericorde.critrate = 3;
        misericorde.critchance = 1;
        misericorde.name = "Misericorde";
        misericorde.unlocks = "Blitz";
        misericorde.rank = 2;
        misericorde.range = 1;
        misericorde.type = "LightBlade";
        misericorde.physical = true;
        if (sw == misericorde.name) u.details = misericorde;

        UnitWeaponDetails starblade = new UnitWeaponDetails();
        starblade.might = 12;
        starblade.weight = 8;
        starblade.hitrate = 65;
        starblade.critrate = 3;
        starblade.critchance = 1;
        starblade.name = "Starblade";
        starblade.unlocks = "Blitz";
        starblade.rank = 2;
        starblade.range = 1;
        starblade.type = "Close";
        starblade.physical = true;
        if (sw == starblade.name) u.details = starblade;



        //--------------------------------------------Staves--------------------------------------------
        UnitWeaponDetails cudgel = new UnitWeaponDetails();
        cudgel.might = 12;
        cudgel.weight = 8;
        cudgel.hitrate = 65;
        cudgel.critrate = 3;
        cudgel.critchance = 1;
        cudgel.name = "Cudgel";
        cudgel.unlocks = "Dark Blast";
        cudgel.unlocks = "";
        cudgel.rank = 2;
        cudgel.range = 1;
        cudgel.type = "Staves";
        cudgel.physical = true;
        if (sw == cudgel.name) u.details = cudgel;


        UnitWeaponDetails mace = new UnitWeaponDetails();
        mace.might = 10;
        mace.weight = 7;
        mace.hitrate = 60;
        mace.critrate = 3;
        mace.critchance = 1;
        mace.name = "Mace";
        mace.unlocks = "Darkbolt";
        mace.unlocks = "Pray";
        mace.rank = 3;
        mace.range = 2;
        mace.type = "Staves";
        mace.physical = true;
        if (sw == mace.name) u.details = mace;

        UnitWeaponDetails ironBar = new UnitWeaponDetails();
        ironBar.might = 12;
        ironBar.weight = 8;
        ironBar.hitrate = 65;
        ironBar.critrate = 3;
        ironBar.critchance = 1;
        ironBar.name = "Iron Bar";
        ironBar.unlocks = "Fear";
        ironBar.rank = 2;
        ironBar.range = 1;
        ironBar.type = "Staves";
        ironBar.physical = true;
        if (sw == ironBar.name) u.details = ironBar;

        UnitWeaponDetails caudice = new UnitWeaponDetails();
        caudice.might = 12;
        caudice.weight = 8;
        caudice.hitrate = 65;
        caudice.critrate = 3;
        caudice.critchance = 1;
        caudice.name = "Caudice";
        caudice.unlocks = "Shade Pulse";
        caudice.unlocks = "Purify";
        caudice.rank = 2;
        caudice.range = 1;
        caudice.type = "Staves";
        caudice.physical = true;
        if (sw == caudice.name) u.details = caudice;

        UnitWeaponDetails heavensWrath = new UnitWeaponDetails();
        heavensWrath.might = 12;
        heavensWrath.weight = 8;
        heavensWrath.hitrate = 65;
        heavensWrath.critrate = 3;
        heavensWrath.critchance = 1;
        heavensWrath.name = "Heaven's Wrath";
        heavensWrath.unlocks = "Blitz";
        heavensWrath.rank = 3;
        heavensWrath.range = 1;
        heavensWrath.type = "Staves";
        heavensWrath.magic = true;
        heavensWrath.effects.natureDamage = true;
        if (sw == heavensWrath.name) u.details = heavensWrath;

        UnitWeaponDetails goldenRule = new UnitWeaponDetails();
        goldenRule.might = 12;
        goldenRule.weight = 8;
        goldenRule.hitrate = 65;
        goldenRule.critrate = 3;
        goldenRule.critchance = 1;
        goldenRule.name = "Golden Rule";
        goldenRule.unlocks = "Breath of Life";
        goldenRule.rank = 3;
        goldenRule.range = 1;
        goldenRule.type = "Staves";
        goldenRule.magic = true;
        goldenRule.effects.metalDamage = true;
        if (sw == goldenRule.name) u.details = goldenRule;

        UnitWeaponDetails holyRod = new UnitWeaponDetails();
        holyRod.might = 12;
        holyRod.weight = 8;
        holyRod.hitrate = 65;
        holyRod.critrate = 3;
        holyRod.critchance = 1;
        holyRod.name = "Holy Rod";
        holyRod.unlocks = "Healing Light";
        holyRod.rank = 3;
        holyRod.range = 1;
        holyRod.type = "Staves";
        holyRod.magic= true;
        holyRod.effects.fireDamage = true;
        if (sw == holyRod.name) u.details = holyRod;

        UnitWeaponDetails luminary = new UnitWeaponDetails();
        luminary.might = 16;
        luminary.weight = 8;
        luminary.hitrate = 65;
        luminary.critrate = 3;
        luminary.critchance = 1;
        luminary.name = "Luminary";
        luminary.unlocks = "Divine Mastery";
        luminary.rank = 3;
        luminary.range = 1;
        luminary.type = "Staves";
        luminary.physical = true;
        if (sw == luminary.name) u.details = luminary;



        //--------------------------------------------Tomes--------------------------------------------
        UnitWeaponDetails voidCodex = new UnitWeaponDetails();
        voidCodex.might = 15;
        voidCodex.weight = 8;
        voidCodex.hitrate = 65;
        voidCodex.critrate = 3;
        voidCodex.critchance = 1;
        voidCodex.name = "Void Codex";
        voidCodex.unlocks = "Blitz";
        voidCodex.rank = 2;
        voidCodex.range = 4;
        voidCodex.type = "Tome";
        voidCodex.magic = true;
        voidCodex.effects.darkDamage = true;
        if (sw == voidCodex.name) u.details = voidCodex;

        UnitWeaponDetails sihedron = new UnitWeaponDetails();
        sihedron.might = 12;
        sihedron.weight = 8;
        sihedron.hitrate = 65;
        sihedron.critrate = 3;
        sihedron.critchance = 1;
        sihedron.name = "Sihedron";
        sihedron.unlocks = "Blitz";
        sihedron.rank = 2;
        sihedron.range = 3;
        sihedron.type = "Tomes";
        sihedron.magic = true;
        sihedron.effects.earthDamage = true;
        if (sw == sihedron.name) u.details = sihedron;

        UnitWeaponDetails manualArcanum = new UnitWeaponDetails();
        manualArcanum.might = 12;
        manualArcanum.weight = 8;
        manualArcanum.hitrate = 65;
        manualArcanum.critrate = 3;
        manualArcanum.critchance = 1;
        manualArcanum.name = "Manual Arcanum";
        manualArcanum.unlocks = "Blitz";
        manualArcanum.rank = 2;
        manualArcanum.range = 4;
        manualArcanum.type = "Tomes";
        manualArcanum.magic = true;
        manualArcanum.effects.metalDamage = true;
        if (sw == manualArcanum.name) u.details = manualArcanum;

        UnitWeaponDetails acolytesWorkbook = new UnitWeaponDetails();
        acolytesWorkbook.might = 12;
        acolytesWorkbook.weight = 8;
        acolytesWorkbook.hitrate = 65;
        acolytesWorkbook.critrate = 3;
        acolytesWorkbook.critchance = 1;
        acolytesWorkbook.name = "Acolyte's Workbook";
        acolytesWorkbook.unlocks = "Blitz";
        acolytesWorkbook.rank = 2;
        acolytesWorkbook.range = 4;
        acolytesWorkbook.type = "Tomes";
        acolytesWorkbook.magic = true;
        acolytesWorkbook.effects.fireDamage = true;
        if (sw == acolytesWorkbook.name) u.details = acolytesWorkbook;

        UnitWeaponDetails wizardsTome = new UnitWeaponDetails();
        wizardsTome.might = 12;
        wizardsTome.weight = 8;
        wizardsTome.hitrate = 65;
        wizardsTome.critrate = 3;
        wizardsTome.critchance = 1;
        wizardsTome.name = "Wizards Tome";
        wizardsTome.unlocks = "Blitz";
        wizardsTome.rank = 2;
        wizardsTome.range = 4;
        wizardsTome.type = "Tomes";
        wizardsTome.physical = true;
        if (sw == wizardsTome.name) u.details = wizardsTome;

        UnitWeaponDetails bookOfHours = new UnitWeaponDetails();
        bookOfHours.might = 12;
        bookOfHours.weight = 8;
        bookOfHours.hitrate = 65;
        bookOfHours.critrate = 3;
        bookOfHours.critchance = 1;
        bookOfHours.name = "Book of Hours";
        bookOfHours.unlocks = "Blitz";
        bookOfHours.rank = 2;
        bookOfHours.range = 4;
        bookOfHours.type = "Tomes";
        bookOfHours.magic = true;
        bookOfHours.effects.natureDamage = true;
        if (sw == bookOfHours.name) u.details = bookOfHours;

        UnitWeaponDetails initiatesNotes = new UnitWeaponDetails();
        initiatesNotes.might = 12;
        initiatesNotes.weight = 8;
        initiatesNotes.hitrate = 65;
        initiatesNotes.critrate = 3;
        initiatesNotes.critchance = 1;
        initiatesNotes.name = "Initiates Notes";
        initiatesNotes.unlocks = "Blitz";
        initiatesNotes.rank = 2;
        initiatesNotes.range = 4;
        initiatesNotes.type = "Tomes";
        initiatesNotes.magic = true;
        initiatesNotes.effects.darkDamage = true;
        if (sw == initiatesNotes.name) u.details = initiatesNotes;

        UnitWeaponDetails mastersPages = new UnitWeaponDetails();
        mastersPages.might = 12;
        mastersPages.weight = 8;
        mastersPages.hitrate = 65;
        mastersPages.critrate = 3;
        mastersPages.critchance = 1;
        mastersPages.name = "Masters Pages";
        mastersPages.unlocks = "Blitz";
        mastersPages.rank = 2;
        mastersPages.range = 4;
        mastersPages.type = "Tomes";
        mastersPages.magic = true;
        mastersPages.effects.waterDamage = true;
        if (sw == mastersPages.name) u.details = mastersPages;




        //--------------------------------------------Athames--------------------------------------------
        UnitWeaponDetails sickle = new UnitWeaponDetails();
        sickle.might = 12;
        sickle.weight = 8;
        sickle.hitrate = 65;
        sickle.critrate = 3;
        sickle.critchance = 1;
        sickle.name = "Sickle";
        sickle.unlocks = "Blitz";
        sickle.rank = 2;
        sickle.range = 1;
        sickle.type = "Athames";
        sickle.physical = true;
        if (sw == sickle.name) u.details = sickle;

        UnitWeaponDetails pactblade = new UnitWeaponDetails();
        pactblade.might = 12;
        pactblade.weight = 8;
        pactblade.hitrate = 65;
        pactblade.critrate = 3;
        pactblade.critchance = 1;
        pactblade.name = "Pactblade";
        pactblade.unlocks = "Blitz";
        pactblade.rank = 2;
        pactblade.range = 1;
        pactblade.type = "Athames";
        pactblade.magic = true;
        pactblade.effects.metalDamage = true;
        if (sw == pactblade.name) u.details = pactblade;

        UnitWeaponDetails reaper = new UnitWeaponDetails();
        reaper.might = 12;
        reaper.weight = 8;
        reaper.hitrate = 65;
        reaper.critrate = 3;
        reaper.critchance = 1;
        reaper.name = "Reaper";
        reaper.unlocks = "Blitz";
        reaper.rank = 2;
        reaper.range = 1;
        reaper.type = "Athames";
        reaper.magic = true;
        reaper.effects.darkDamage = true;
        if (sw == reaper.name) u.details = reaper;

        UnitWeaponDetails bloodAthame = new UnitWeaponDetails();
        bloodAthame.might = 12;
        bloodAthame.weight = 8;
        bloodAthame.hitrate = 65;
        bloodAthame.critrate = 3;
        bloodAthame.critchance = 1;
        bloodAthame.effects.poison = true;
        bloodAthame.name = "Bloody Blade";
        bloodAthame.unlocks = "Blitz";
        bloodAthame.rank = 2;
        bloodAthame.range = 1;
        bloodAthame.type = "Athames";
        bloodAthame.physical = true;
        if (sw == bloodAthame.name) u.details = bloodAthame;

        UnitWeaponDetails blackMercy = new UnitWeaponDetails();
        blackMercy.might = 12;
        blackMercy.weight = 8;
        blackMercy.hitrate = 65;
        blackMercy.critrate = 3;
        blackMercy.critchance = 1;
        blackMercy.name = "Black Mercy";
        blackMercy.effects.sleep = true;
        blackMercy.unlocks = "Blitz";
        blackMercy.rank = 2;
        blackMercy.range = 1;
        blackMercy.type = "Athames";
        blackMercy.magic = true;
        blackMercy.effects.darkDamage = true;
        if (sw == blackMercy.name) u.details = blackMercy;

        UnitWeaponDetails eternityShard = new UnitWeaponDetails();
        eternityShard.might = 12;
        eternityShard.weight = 8;
        eternityShard.hitrate = 65;
        eternityShard.critrate = 3;
        eternityShard.critchance = 1;
        eternityShard.name = "Shard of Eternity";
        eternityShard.unlocks = "Blitz";
        eternityShard.rank = 2;
        eternityShard.range = 1;
        eternityShard.type = "Athames";
        eternityShard.magic = true;
        eternityShard.effects.metalDamage = true;
        if (sw == eternityShard.name) u.details = eternityShard;

        UnitWeaponDetails shatteredDream = new UnitWeaponDetails();
        shatteredDream.might = 12;
        shatteredDream.weight = 8;
        shatteredDream.hitrate = 65;
        shatteredDream.critrate = 3;
        shatteredDream.critchance = 1;
        shatteredDream.name = "Shattered Dream";
        shatteredDream.unlocks = "Blitz";
        shatteredDream.rank = 2;
        shatteredDream.range = 1;
        shatteredDream.type = "Athames";
        shatteredDream.magic = true;
        shatteredDream.effects.natureDamage = true;
        if (sw == vshatteredDream.name) u.details = shatteredDream;

        UnitWeaponDetails entropysGrasp = new UnitWeaponDetails();
        entropysGrasp.might = 12;
        entropysGrasp.weight = 8;
        entropysGrasp.hitrate = 65;
        entropysGrasp.critrate = 3;
        entropysGrasp.critchance = 1;
        entropysGrasp.name = "Entropy's Grasp";
        entropysGrasp.unlocks = "Blitz";
        entropysGrasp.rank = 2;
        entropysGrasp.range = 1;
        entropysGrasp.type = "Athames";
        entropysGrasp.magic = true;
        entropysGrasp.effects.poison = true;
        entropysGrasp.effects.darkDamage = true;
        if (sw == entropysGrasp.name) u.details = entropysGrasp;

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
