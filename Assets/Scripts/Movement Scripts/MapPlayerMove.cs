using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayerMove : GridMovement {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AssignMe()
    {
        MapManager manager = GameObject.FindObjectOfType<MapManager>();
        manager.UserSet(gameObject);
    }

    public void RemoveMe()
    {
        MapManager manager = GameObject.FindObjectOfType<MapManager>();
        manager.UserRemove();
    }

    public void ShowMove()
    {
        AssignMe();
        FindSelectableTiles();
    }

    public void HideMove()
    {
        RemoveMe();
        RemoveSelectableTiles();
    }
     
    public void go(GridTiles tile)
    {
        HideMove();
        MoveToTile(tile);
    }
}
