using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public UnitInventory inventory;
    public UnitItems items;
    public UnitInfo unitInfo;
    public UnitProgress progress;
    public UnitClass unitClass;
    public UnitStatus status;
    public string unitID;
	public Unit()
    {
        inventory = new UnitInventory();
        items = new UnitItems();
        unitInfo = new UnitInfo();
        progress = new UnitProgress();
        unitClass = new UnitClass();
        status = new UnitStatus();
        unitID = "";
    }
}
