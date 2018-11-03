using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameTypeDirector {

    // Use this for initialization

    public AreaGroupHolder allAreas;
    public GameTypeDirector()
    {
        allAreas = new AreaGroupHolder();
    }

}
