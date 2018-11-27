using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentSceneActorInfo
{
    public string name;
    public string location;
    public string words;
    public ActorPlacementGroup actor;
    // Use this for initialization
    public CurrentSceneActorInfo(string loc, string n, string w)
    {
        location = loc;
        name = n;
        words = w;
        actor = new ActorPlacementGroup();
    }
}
