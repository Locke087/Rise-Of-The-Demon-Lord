using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentLevel {

    public bool complete;
    public string level;
    public CurrentLevel()
    {
        complete = false;
        level = "";
    }
}
