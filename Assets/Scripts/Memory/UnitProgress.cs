using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitProgress {

    public UnitStatBonus bonus;
    public UnitClass unitClass;
	public UnitProgress()
    {
        bonus = new UnitStatBonus();
        unitClass = new UnitClass();
    }
}
