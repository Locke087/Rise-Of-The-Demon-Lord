using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitUniqueAssessoryXp  {

    public int xp;
    public string idx;
    public bool done;
    public UnitUniqueAssessoryXp(string id)
    {
        xp = 0;
        idx = id;
        done = false;
    }
}
