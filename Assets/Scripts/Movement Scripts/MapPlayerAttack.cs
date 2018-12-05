using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapPlayerAttack : ShowAttackRange {

    // Use this for initialization
    public bool inUse = false;
    public bool attacked = false;
    public string shape;
    public UnitSkillDetail currentAttack;
    MapPlayerMove playerMove;
    void Start()
    {
        shape = "";
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
        Debug.Log("okay why");
        if (!playerMove.busy)
        {
            inUse = true;
            AssignMe();
            FindSelectableTiles();
            
        }
    }

   

    public void UniqueAttack()
    {
        Debug.Log("okay now");
        if (!playerMove.busy)
        {
            attackArea = currentAttack.range;
            inUse = true;
            AssignMe();
            FindSelectableTiles();

        }
    }


    public void HideAttack()
    {
        inUse = false;
        RemoveMe();
        RemoveSelectableTiles();
    }

    public void attack()
    {
        GameObject.FindObjectOfType<PlayerUnitMenu>().attackDoubleClick = false;
        HideAttack();
    }


}
