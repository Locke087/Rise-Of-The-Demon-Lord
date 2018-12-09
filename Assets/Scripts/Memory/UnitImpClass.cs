using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitImpClass {

    public UnitClassDetail swashbuckler;
    public UnitClassDetail fusilier;
    public UnitClassDetail shrike;
    public UnitClassDetail shadow;
    public UnitClassDetail dread;
    public UnitClassDetail duelist;
    public UnitClassDetail cannoneer;
    public UnitClassDetail demonRider;
    public UnitClassDetail nightblade;
    public UnitClassDetail darkknight;

    public UnitImpClass()
    {
        swashbuckler = new UnitClassDetail();
        fusilier = new UnitClassDetail();
        shrike = new UnitClassDetail();
        shadow = new UnitClassDetail();
        dread = new UnitClassDetail();
        duelist = new UnitClassDetail();
        cannoneer = new UnitClassDetail();
        demonRider = new UnitClassDetail();
        nightblade = new UnitClassDetail();
        darkknight = new UnitClassDetail();
    }
}
