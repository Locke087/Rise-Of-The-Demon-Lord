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

    public UnitHumanClass()
    {
        warrior = new UnitClassDetail();
        archer = new UnitClassDetail();
        rogue = new UnitClassDetail();
        cavalier = new UnitClassDetail();
        mage = new UnitClassDetail();
        priest = new UnitClassDetail();
        bard = new UnitClassDetail();
    }
}
