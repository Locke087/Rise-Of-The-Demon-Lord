﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnitMenu : MonoBehaviour {

    // Use this for initialization
    GameObject unitfFor;
    GameObject unitMenu;
    Button move;
    Button attack;
    Button endTurn;
    public bool menuActive = false;

    void Start () {
        unitMenu = GameObject.Find("UnitMenu1");
        move = GameObject.Find("Move").GetComponent<Button>();
        attack = GameObject.Find("Attack").GetComponent<Button>();
        endTurn = GameObject.Find("End Turn").GetComponent<Button>();
        move.onClick.AddListener(Move);
        attack.onClick.AddListener(Attack);
        endTurn.onClick.AddListener(EndTurn);
        DeactiveMenu();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AssignUnit(GameObject unit)
    {
        unitfFor = unit;
    }

    public void RemoveUnit()
    {
        unitfFor = null;
    }

    public void ActiveMenu()
    {
        menuActive = true;
        unitMenu.SetActive(true);
        move = GameObject.Find("Move").GetComponent<Button>();
        attack = GameObject.Find("Attack").GetComponent<Button>();
        endTurn = GameObject.Find("End Turn").GetComponent<Button>();
        move.onClick.AddListener(Move);
        attack.onClick.AddListener(Attack);
        endTurn.onClick.AddListener(EndTurn);
    }

    public void DeactiveMenu()
    {
        menuActive = false;
        unitMenu.SetActive(false);
    }

    void Move()
    {
        if (unitfFor != null) unitfFor.GetComponent<MapPlayerMove>().ShowMove();
    }

    void Attack()
    {
        if (unitfFor != null) unitfFor.GetComponent<MapPlayerAttack>().ShowAttack();
    }

    void EndTurn()
    {
        DeactiveMenu();
        //Other Things When Turn Are Done
    }
}