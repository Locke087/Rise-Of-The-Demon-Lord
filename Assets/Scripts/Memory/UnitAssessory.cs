using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitAssessory {

    public string idx;
    public string name;
    public bool inSlot;
    public bool equipped;
    public UnitAssessoryDetails details;

    public UnitAssessory()
    {
        idx = "";
        name = "";
        inSlot = false;
        equipped = false;
        details = new UnitAssessoryDetails();
    }
}
