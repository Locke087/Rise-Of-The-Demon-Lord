using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CutScene1 : CutSceneController {

	// Use this for initialization
	void Start () {
        StartUp();
        List<CurrentSceneActorInfo> sceneActors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene1Melvin";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place1", "ActMelvin", temp);
        sceneActors.Add(scene1a1);

        string[] actingOrder = { "ActMelvin" };
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(sceneActors, order);
        sceneInfos.Add(scene1);
        Scene2();
      
	}
	
	
    void Scene2()
    {
        List<CurrentSceneActorInfo> scene1Actors = new List<CurrentSceneActorInfo>();
        List<string> order = new List<string>();
        string book = "";
        string file = "scene2Melvin";
        string temp = "";
        book = File.ReadAllText("Assets/TextFiles/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a1 = new CurrentSceneActorInfo("place10", "ActMelvin", temp);
        scene1Actors.Add(scene1a1);

        file = "scene2Jane";
        book = File.ReadAllText("Assets/TextFiles/" + file + ".txt");
        temp = book;
        CurrentSceneActorInfo scene1a2 = new CurrentSceneActorInfo("place5", "ActJane", temp);
        scene1Actors.Add(scene1a2);
        string[] actingOrder = { "ActJane", "ActMelvin" };
        order.AddRange(actingOrder);
        CurrentSceneInfo scene1 = new CurrentSceneInfo(scene1Actors, order);
        sceneInfos.Add(scene1);

        StartCoroutine(StartScene());
    }

 
}
