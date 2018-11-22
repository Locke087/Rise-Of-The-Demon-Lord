using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitUniqueWeaponXp  {

    public int xp;
    public string idx;
    public bool done;
    public UnitUniqueWeaponXp(string id)
    {
        xp = 0;
        idx = id;
        done = false;
    }
}
