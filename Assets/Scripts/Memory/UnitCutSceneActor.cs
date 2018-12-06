using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitCutSceneActor {

    public UnitActorDirection left;
    public UnitActorDirection right;
	public UnitCutSceneActor()
    {
        left = new UnitActorDirection();
        right = new UnitActorDirection();
    }
}
