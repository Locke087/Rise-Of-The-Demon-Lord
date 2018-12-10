using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitAssessoryDetails {

    public string name;
    public float boost;
    public int weight;
    public bool boostHp;
    public bool boostSkill;
    public bool boostDef;
    public bool boostWill;
    public bool boostStr;
    public bool boostMag;
    public bool boostSpd;
    public string unlocks;
    public int rank;
    public int xp;
    public List<string> moreUnlocks;
    public List<UnitUniqueAssessoryXp> uniqueAssessoryXps;
    public UnitAssessoryDetails()
    {
        name = "";
        boost = 0;
        weight = 0;
        xp = 0;
        boostStr = false;
        boostMag = false;
        boostSkill = false;
        boostMag = false;
        boostHp = false;
        boostSpd = false;
        moreUnlocks = new List<string>();
        unlocks = "";
        rank = 0;
        uniqueAssessoryXps = new List<UnitUniqueAssessoryXp>();
    }
}
