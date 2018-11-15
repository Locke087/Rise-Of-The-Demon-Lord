using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentLevel {

    public bool complete;
    public string name;
    public string sceneName;
    public string idx;
    public int powerRanking;
    public int deployLimit;
    public EnemiesInMap enemiesInMap;
    public CurrentLevel()
    {
        enemiesInMap = new EnemiesInMap();
        complete = false;
        name = "";
        sceneName = "";
        idx = "";
        powerRanking = 0;
        deployLimit = 0;
    }
}
