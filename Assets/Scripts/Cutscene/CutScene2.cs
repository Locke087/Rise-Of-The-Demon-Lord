using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CutScene2 : CutSceneController
{

    void Start()
    {
        StartUp();

        List<CurrentSceneActorInfo> sceneActors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene1Tutor";
        string folder = "cutscene2";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place1", "ActTutorHappy", temp, "ActTutorHappy");
        sceneActors.Add(scene1a1);

        string[] actingOrder = { "ActTutorHappy" };
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(sceneActors, order);
        sceneInfos.Add(scene1);
        Scene2();

    }

    public Unit FindMyself(string unitID)
    {
        Unit me = new Unit();
        foreach (Unit u in CurrentGame.game.storeroom.units)
        {
            if (unitID == u.unitID) return u;
        }
        return me;
    }

    void Scene2()
    {
        List<CurrentSceneActorInfo> scene1Actors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene2TutorS";
        string folder = "cutscene2";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place12", "ActTutorSer", temp, "ActTutorSer");
        scene1Actors.Add(scene1a1);

        file = "scene2Tutor";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a2 = new CurrentSceneActorInfo("place5", "ActTutor", temp, "ActTutor");
        scene1Actors.Add(scene1a2);
        string[] actingOrder = { "ActTutorSer", "ActTutor" };
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(scene1Actors, order);
        sceneInfos.Add(scene1);

        StartCoroutine(StartScene());
    }

    void Scene3()
    {
        List<CurrentSceneActorInfo> sceneActors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene3Tutor";
        string folder = "cutscene2";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + folder + "/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place30", "ActTutorHappy", temp, "ActTutorHappy");
        sceneActors.Add(scene1a1);

        string[] actingOrder = { "ActTutorHappy" };
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(sceneActors, order);
        sceneInfos.Add(scene1);
    }

}
