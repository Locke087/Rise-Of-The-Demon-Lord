using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitInfo {

    public string nature;
    public List<int> bases;
    public UnitClassDetail main;
    public UnitClassDetail sub;
    public UnitInfo()
    {
        bases = new List<int>();
        main = new UnitClassDetail();
        sub = new UnitClassDetail();
        nature = "random";
    }
}
