using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponRankDetails {

    public int rank;
    public bool canUse;
    public string name;
	public WeaponRankDetails()
    {
        rank = 0;
        canUse = false;
        name = "";
    }
}
