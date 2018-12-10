using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitMonsterClass {

    // Use this for initialization
    public UnitClassDetail goblinCharger;
    public UnitClassDetail goblinArcher;
    public UnitClassDetail goblinMage;
    public UnitClassDetail blueSlime;
    public UnitClassDetail greenSlime;
    public UnitClassDetail babyDevil;
    public UnitClassDetail babyGreenDragon;
    public UnitClassDetail babyRedDragon;
    public UnitClassDetail blueVineTrap;
    public UnitClassDetail redVineTrap;
    public UnitClassDetail devil;
    public UnitClassDetail efreet;
    public UnitClassDetail ghost;
    public UnitClassDetail reaper;
    public UnitClassDetail skeleton;
    public UnitClassDetail werewolf;

    public UnitMonsterClass()
    {
        goblinCharger = new UnitClassDetail();
        goblinArcher = new UnitClassDetail();
        blueSlime = new UnitClassDetail();
        greenSlime = new UnitClassDetail();
        babyDevil = new UnitClassDetail();
        babyGreenDragon = new UnitClassDetail();
        babyRedDragon = new UnitClassDetail();
        blueVineTrap = new UnitClassDetail();
        redVineTrap = new UnitClassDetail();
        devil = new UnitClassDetail();
        efreet = new UnitClassDetail();
        ghost = new UnitClassDetail();
        reaper = new UnitClassDetail();
        skeleton = new UnitClassDetail();
        werewolf = new UnitClassDetail();

    }
}
