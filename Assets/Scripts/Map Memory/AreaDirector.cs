using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AreaDirector {



    public List<AreaHolder> areas;
    public bool clean;
    public bool gap;
    public bool wall;
    public bool reward;
    public bool objective;
    public string pick;
    public int idx;
    //public int idx;
    public AreaDirector()
    {
        areas = new List<AreaHolder>();
        clean = false;
        gap = false;
        wall = false;
        reward = false;
        objective = false;
        pick = "";
        idx = 0;
       // idx = num;
    }
}
