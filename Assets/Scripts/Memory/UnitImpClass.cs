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
    public UnitClassDetail magus;

    public UnitImpClass()
    {
        swashbulkler = new UnitClassDetail();
        fusilier = new UnitClassDetail();
        shrike = new UnitClassDetail();
        shadow = new UnitClassDetail();
        dread = new UnitClassDetail();
        magus = new UnitClassDetail();

    }
}
