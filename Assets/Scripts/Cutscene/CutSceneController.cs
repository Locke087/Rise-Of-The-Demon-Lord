using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneController : MonoBehaviour {

    // Use this for initialization
    List<ActorPlacementGroup> actors;
    public List<string> names;
    public List<CurrentSceneInfo> sceneInfos;
    public int allDone;

    public void StartUp()
    {
        actors = new List<ActorPlacementGroup>();
        sceneInfos = new List<CurrentSceneInfo>();
        allDone = 0;
        actors.AddRange(GetComponentsInChildren<ActorPlacementGroup>());
        foreach (ActorPlacementGroup a in actors)
        {
            names.Add(a.realname);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator StartScene()
    {

        foreach (CurrentSceneInfo currentScene in sceneInfos)
        {        
            foreach (CurrentSceneActorInfo actorInfo in currentScene.actors)
            {
                ActorPlacementGroup actor = actors.Find(x => x.realname == actorInfo.groupName);
                actor.SwitchPostion(actorInfo.location, actorInfo.name);
                yield return new WaitForSeconds(0.01f);
                actor.CurrentPostion().NewMe(actorInfo.name);
                actorInfo.actor = actor;
            }

            foreach (string word in currentScene.order)
            {

                ActorPlacementGroup actor = actors.Find(x => x.realname == word);
                CurrentSceneActorInfo actorInfo = currentScene.actors.Find(x => x.actor == actor);
                yield return new WaitForSeconds(0.01f);
                actor.CurrentPostion().NewText(actorInfo.words);
                Debug.Log("heloo uthg");
                yield return new WaitUntil(() => actor.CurrentPostion().done == true);
                actor.CurrentPostion().done = false;
                allDone++;
            }
            yield return new WaitUntil(() => allDone >= currentScene.order.Count);
            allDone = 0;
        }
    }

   

  
}
