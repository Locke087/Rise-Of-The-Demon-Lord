using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentSceneInfo
{
    public List<CurrentSceneActorInfo> actors;
    public List<string> order;
    // Use this for initialization
    public CurrentSceneInfo(List<CurrentSceneActorInfo> a, List<string> ord)
    {
        actors = a;
        order = ord;
    }
}
