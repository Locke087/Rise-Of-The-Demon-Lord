using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SWLevels {

    public List<CurrentLevel> currentLevels;
    public SWLevels()
    {
        currentLevels = new List<CurrentLevel>();
    }
}
