﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayerMove : GridMovement {

    // Use this for initialization
    public bool busy = false;
    MapPlayerAttack playerAttack;
	void Start () {
      playerAttack = gameObject.GetComponent<MapPlayerAttack>();
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
        if (!playerAttack.inUse)
        {
            busy = true;
            AssignMe();
            FindSelectableTiles();
        }
    }

   
    public void HideMove()
    {
        busy = false;
        RemoveMe();
        RemoveSelectableTiles();
    }

   

    public void GoMove(GridTiles tile)
    {
        HideMove();
        MoveToTile(tile);
    }

}