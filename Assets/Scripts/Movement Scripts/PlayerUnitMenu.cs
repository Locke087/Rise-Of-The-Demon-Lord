using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnitMenu : MonoBehaviour {

    // Use this for initialization
    GameObject unitfFor;
    public GameObject unitMenu;
    public Button move;
    public Button attack;
    public Button endTurn;
    public bool menuActive = false;
    public bool attackFinished = false;
    public bool movedFinished = false;
    public bool attackDoubleClick = false;
    public bool moveDoubleClick = false;
   
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
        if (!menuActive)
        {
            Debug.Log("why");
            menuActive = true;
            unitMenu.SetActive(true);
        }
        
     
    }

    public void DeactiveMenu()
    {
        if (menuActive)
        {
            menuActive = false;
            unitMenu.SetActive(false);
        }
        
    }

    void Move()
    {
        if (moveDoubleClick)
        {
            moveDoubleClick = false;
            unitfFor.GetComponent<MapPlayerMove>().HideMove();
        }
        else if (attackDoubleClick)
        {
            attackDoubleClick = false;
            unitfFor.GetComponent<MapPlayerAttack>().HideAttack();
            if (!movedFinished)
            {
                moveDoubleClick = true;
                Debug.Log("in move");
                if (unitfFor != null) unitfFor.GetComponent<MapPlayerMove>().ShowMove();
            }
        }
        else if (!movedFinished)
        {
            moveDoubleClick = true;
            Debug.Log("in move");
            if (unitfFor != null) unitfFor.GetComponent<MapPlayerMove>().ShowMove();
        }
    }

    void Attack()
    {
        if (attackDoubleClick)
        {
            attackDoubleClick = false;
            unitfFor.GetComponent<MapPlayerAttack>().HideAttack();
        }
        else if (moveDoubleClick)
        {
            moveDoubleClick = false;
            unitfFor.GetComponent<MapPlayerMove>().HideMove();
            if (!attackFinished)
            {
                Debug.Log("in attack");
                if (unitfFor != null) unitfFor.GetComponent<MapPlayerAttack>().ShowAttack();
                attackDoubleClick = true;
            }
        }
        else if (!attackFinished)
        {
            attackDoubleClick = true;
            Debug.Log("in attack");
            if (unitfFor != null) unitfFor.GetComponent<MapPlayerAttack>().ShowAttack();
        
        }
        
    }

    void EndTurn()
    {
        if (!attackDoubleClick && !moveDoubleClick)
        {
            attackFinished = false;
            movedFinished = false;
            move.gameObject.GetComponent<Image>().color = Color.white;
            attack.gameObject.GetComponent<Image>().color = Color.white;
            GameObject.FindObjectOfType<SpeedCenterTurns>().AdvanceTurn();
            DeactiveMenu();
        }
        //Other Things When Turn Are Done
    }
}
