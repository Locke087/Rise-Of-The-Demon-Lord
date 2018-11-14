using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OGLevels {

    public List<CurrentLevel> currentLevels;
    public OGLevels()
    {
        currentLevels = new List<CurrentLevel>();
    }
}
