using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitImpClass {

    public UnitClassDetail swashbulkler;
    public UnitClassDetail fusilier;
    public UnitClassDetail shrike;
    public UnitClassDetail shadow;
    public UnitClassDetail dread;
    public UnitClassDetail duelist;
    public UnitClassDetail cannoneer;
    public UnitClassDetail demonrider;
    public UnitClassDetail nightblade;
    public UnitClassDetail darkknight;

    public UnitImpClass()
    {
        swashbulkler = new UnitClassDetail();
        fusilier = new UnitClassDetail();
        shrike = new UnitClassDetail();
        shadow = new UnitClassDetail();
        dread = new UnitClassDetail();
        duelist = new UnitClassDetail();

    }
}
