using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemiesInMap {

    public List<Unit> units;
    public List<Unit> reinforcements;
    public Unit boss;

    public EnemiesInMap()
    {
        units = new List<Unit>();
        reinforcements = new List<Unit>();
        boss = new Unit();
    }
}
