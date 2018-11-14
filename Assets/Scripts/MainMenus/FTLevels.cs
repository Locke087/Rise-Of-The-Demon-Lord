using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FTLevels {

    public List<CurrentLevel> currentLevels;
    public FTLevels()
    {
        currentLevels = new List<CurrentLevel>(); 
    }
}
