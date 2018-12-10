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
    public UnitWeapon weapon;
    MapPlayerMove playerMove;
    Stats stats;
  
    void Start()
    {

        stats = gameObject.GetComponent<Stats>();
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
        if (!playerMove.busy && !stats.sleep)
        {
            inUse = true;
            AssignMe();
            FindSelectableTiles();
            
        }
        else if (stats.sleep)
        {
            MapManager manager = GameObject.FindObjectOfType<MapManager>();
            manager.DisableMove();
        }
    }

   

    public void UniqueAttack()
    {
        Debug.Log("okay now");
        if (!playerMove.busy && !stats.sleep)
        {
            attackArea = currentAttack.range;
            inUse = true;
            AssignMe();
            FindSelectableTiles();

        }
        else if (stats.sleep)
        {
            MapManager manager = GameObject.FindObjectOfType<MapManager>();
            manager.DisableMove();
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
