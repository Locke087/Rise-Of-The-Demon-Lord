using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitActor {

    public UnitPortrait neutralPortrait;
    public UnitPortrait excitedPortrait;
    public UnitPortrait happyPortrait;
    public UnitPortrait madPortrait;
    public UnitPortrait sadPortrait;
    public UnitMapActor mapActor;
    public UnitCutSceneActor cutsceneActor;
	public UnitActor()
    {
        neutralPortrait = new UnitPortrait();
        excitedPortrait = new UnitPortrait();
        happyPortrait = new UnitPortrait();
        sadPortrait = new UnitPortrait();
        madPortrait = new UnitPortrait();
        mapActor = new UnitMapActor();
        cutsceneActor = new UnitCutSceneActor();
    }
}
