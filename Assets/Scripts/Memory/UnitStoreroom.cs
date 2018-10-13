using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitStoreroom : MonoBehaviour {

    public List<Unit> units = new List<Unit>();

	public void AddUnit(Unit u)
    {
        units.Add(u);
    }

    public Unit findUnit(string id)
    {
        int i = 0;

        foreach (Unit u in units) {
            if (u.unitID == id) return u;
            i++;
        }

        return units[i];
    }
}
