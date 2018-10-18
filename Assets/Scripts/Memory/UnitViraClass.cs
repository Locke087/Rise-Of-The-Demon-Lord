using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitViraClass {

    public UnitClassDetail wardancer;
    public UnitClassDetail geomancer;
    public UnitClassDetail kensai;
    public UnitClassDetail onmiyoji;
    public UnitClassDetail chronos;
    public UnitClassDetail alchemist;

    public UnitViraClass()
    {
        wardancer = new UnitClassDetail();
        geomancer = new UnitClassDetail();
        kensai = new UnitClassDetail();
        onmiyoji = new UnitClassDetail();
        chronos = new UnitClassDetail();
        alchemist = new UnitClassDetail();

    }
}
