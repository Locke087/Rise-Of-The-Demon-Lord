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
    public int goldReward;
    public string unitReward;
    public string itemReward;
    public string weaponReward;
    public string assessoryReward;
    public int xpReward;
    public EnemiesInMap enemiesInMap;
    public ChestPool chestPool;
    public CurrentLevel()
    {
        enemiesInMap = new EnemiesInMap();
        chestPool = new ChestPool();
        complete = false;
        name = "";
        sceneName = "";
        idx = "";
        powerRanking = 0;
        deployLimit = 0;
        goldReward = 0;
        xpReward = 0;
        unitReward = "";
        itemReward = "";
        weaponReward = "";
        assessoryReward = "";
    }
}
