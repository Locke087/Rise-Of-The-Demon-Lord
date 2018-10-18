using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class UnitStoreroom {

    public static List<Unit> units = new List<Unit>();

	public static void AddUnit(Unit u)
    {
        units.Add(u);
    }

    public static Unit findUnit(string id)
    {
        int i = 0;

        foreach (Unit u in units) {
            if (u.unitID == id) return u;
            i++;
        }

        return units[i];
    }
}
