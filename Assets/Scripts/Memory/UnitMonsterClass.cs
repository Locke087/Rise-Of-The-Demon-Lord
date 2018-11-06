using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitMonsterClass {

    // Use this for initialization
    public UnitClassDetail goblinCharger;
    public UnitClassDetail goblinArcher;
    public UnitClassDetail goblinMage;
    public UnitMonsterClass()
    {
        goblinCharger = new UnitClassDetail();
        goblinArcher = new UnitClassDetail();
        goblinMage = new UnitClassDetail();
    }
}
