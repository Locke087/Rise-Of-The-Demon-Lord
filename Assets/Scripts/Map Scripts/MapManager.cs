using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    // Use this for initialization

    public GameObject currentUser;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UserSet(GameObject user)
    {
        currentUser = user;
    }

    public void UserRemove()
    {
        currentUser = null;
    }

    public void PlayerMove(GameObject tile)
    {
        if (currentUser != null)
        {
            if (tile.GetComponent<GridTiles>().selectable)
            {

              
                currentUser.GetComponent<MapPlayerMove>().
            }
            else if (tile.GetComponent<GridTiles>().attack)
        }
    }
}
