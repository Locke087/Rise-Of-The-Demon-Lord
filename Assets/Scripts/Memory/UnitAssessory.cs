using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitAssessory {

    public string idx;
    public string name;
    public int cost;
    public bool inSlot;
    public bool equipped;
    public UnitAssessoryDetails details;

    public UnitAssessory()
    {
        idx = "";
        name = "";
        inSlot = false;
        equipped = false;
        cost = 0;
        details = new UnitAssessoryDetails();
    }
}
