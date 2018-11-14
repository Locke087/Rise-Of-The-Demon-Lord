using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentLevel {

    public bool complete;
    public string level;
    public string idx;
    public EnemiesInMap enemiesInMap;
    public CurrentLevel()
    {
        enemiesInMap = new EnemiesInMap();
        complete = false;
        level = "";
        idx = "";
    }
}
