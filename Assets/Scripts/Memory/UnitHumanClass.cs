using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitHumanClass
{
    public UnitClassDetail warrior;
    public UnitClassDetail archer;
    public UnitClassDetail rogue;
    public UnitClassDetail cavalier;
    public UnitClassDetail mage;
    public UnitClassDetail priest;
    public UnitClassDetail bard;
    public UnitClassDetail knight;
    public UnitClassDetail sniper;
    public UnitClassDetail assassin;
    public UnitClassDetail charger;
    public UnitClassDetail archmage;
    public UnitClassDetail paladin;

    public UnitHumanClass()
    {
        warrior = new UnitClassDetail();
        archer = new UnitClassDetail();
        rogue = new UnitClassDetail();
        cavalier = new UnitClassDetail();
        mage = new UnitClassDetail();
        priest = new UnitClassDetail();
        bard = new UnitClassDetail();
        knight = new UnitClassDetail();
        sniper = new UnitClassDetail();
        assassin = new UnitClassDetail();
        charger = new UnitClassDetail();
        archmage = new UnitClassDetail();
        paladin = new UnitClassDetail();
    }
}
