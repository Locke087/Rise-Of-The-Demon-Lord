using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Unit {

    public UnitInventory inventory;
    public UnitItems items;
    public UnitInfo unitInfo;
    public UnitClass unitClass;
    public UnitStatus status;
    public UnitActor unitActor;
    public string idx;
    public string unitID;
	public Unit()
    {
        inventory = new UnitInventory();
        items = new UnitItems();
        unitInfo = new UnitInfo();
        unitClass = new UnitClass();
        status = new UnitStatus();
        unitActor = new UnitActor();
        idx = "";
        unitID = "";
    }
}
