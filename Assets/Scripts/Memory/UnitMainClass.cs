using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitMainClass {

    public UnitHumanClass human;
    public UnitImpClass imp;
    public UnitViraClass vira;
    public UnitMonsterClass monster;
    public string mainClass;
    public string race;
    public UnitMainClass()
    {
        human = new UnitHumanClass();
        vira = new UnitViraClass();
        imp = new UnitImpClass();
        monster = new UnitMonsterClass();
        mainClass = "";
        race = "";
    }
}
