using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitAssessory {

    public string assessory;
    public bool inSlot;
    public bool equipped;
    public UnitAssessoryDetails details;

    public UnitAssessory()
    {
        assessory = "";
        inSlot = false;
        equipped = false;
        details = new UnitAssessoryDetails();
    }
}
