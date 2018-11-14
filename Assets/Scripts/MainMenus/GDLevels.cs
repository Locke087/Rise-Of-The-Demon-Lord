using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GDLevels {

    public List<CurrentLevel> currentLevels;
    public GDLevels()
    {
        currentLevels = new List<CurrentLevel>();
    }
}
