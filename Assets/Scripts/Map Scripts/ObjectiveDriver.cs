using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveDriver : MonoBehaviour {

    // Use this for initialization
    public string whichOne;
	void Start () {
        GameTypeAdd();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GameTypeAdd()
    {
        if (whichOne == "rout")
        {
            gameObject.AddComponent<Rout>();
        }
    }

    private void OnApplicationQuit()
    {
        if (whichOne == "rout")
        {
            Destroy(gameObject.GetComponent<Rout>());
        }
    }
}
