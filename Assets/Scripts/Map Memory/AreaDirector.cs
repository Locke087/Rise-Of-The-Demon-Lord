using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AreaDirector {



    public List<AreaHolder> areas;
    public string spawn;
    //public int idx;
    public AreaDirector()
    {
        areas = new List<AreaHolder>();
        spawn = "";
       // idx = num;
    }
}
