﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlayerAttack : ShowAttackRange {

    // Use this for initialization
    public bool inUse = false;
    MapPlayerMove playerMove;
    void Start()
    {
        playerMove = gameObject.GetComponent<MapPlayerMove>();
    }

    // Update is called once per frame
 

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


    public void ShowAttack()
    {
        if (!playerMove.busy)
        {
            inUse = true;
            AssignMe();
            FindAttackTiles();
            
        }
    }

    public void HideAttack()
    {
        inUse = false;
        RemoveMe();
        RemoveSelectableTiles();
    }

    public void attack(GridTiles tile)
    {
        HideAttack();
    }
}