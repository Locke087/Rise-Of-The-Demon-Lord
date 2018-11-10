using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelCompletion {

    // Use this for initialization
    public GDLevels gdLevels;
    public OGLevels ogLevels;
    public SWLevels swLevels;
    public FTLevels ftLevels;

    public LevelCompletion()
    {
        gdLevels = new GDLevels();
        ogLevels = new OGLevels();
        swLevels = new SWLevels();
        ftLevels = new FTLevels();
    }
}
