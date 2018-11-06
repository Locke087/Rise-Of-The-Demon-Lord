using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MemoryGeneralGame {
    public List<Unit> unitsInRoster;
    public List<Unit> unitsInParty;
    public EquipmentOwned itemsOwned;
    public ShopWares shopWares;
    public int gold;
	public MemoryGeneralGame()
    {
        unitsInRoster = new List<Unit>();
        unitsInParty = new List<Unit>();
        itemsOwned = new EquipmentOwned();
        shopWares = new ShopWares();
        gold = 0;
    }
}
