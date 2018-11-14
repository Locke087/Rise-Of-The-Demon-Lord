using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class LevelHolder  {

    public GDLevels gdLevels;
    public OGLevels ogLevels;
    public SWLevels swLevels;
    public FTLevels ftLevels;

    public LevelHolder()
    {
        gdLevels = new GDLevels();
        ogLevels = new OGLevels();
        swLevels = new SWLevels();
        ftLevels = new FTLevels();
    }
}
