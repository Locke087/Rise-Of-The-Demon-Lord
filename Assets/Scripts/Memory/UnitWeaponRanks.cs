using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitWeaponRanks {

    public WeaponRankDetails HeavyBlade;
    public WeaponRankDetails Close;
    public WeaponRankDetails Bow;
    public WeaponRankDetails Instrument;
    public WeaponRankDetails Spear;
    public WeaponRankDetails Axe;
    public WeaponRankDetails Stave;
    public WeaponRankDetails Athames;
    public WeaponRankDetails LightBlades;
    public WeaponRankDetails Tome;

    public UnitWeaponRanks()
    {
        HeavyBlade = new WeaponRankDetails();
        Bow = new WeaponRankDetails();
        Instrument = new WeaponRankDetails();
        Spear = new WeaponRankDetails();
        Close = new WeaponRankDetails();
        Stave = new WeaponRankDetails();
        Athames = new WeaponRankDetails();
        Tome = new WeaponRankDetails();
        LightBlades = new WeaponRankDetails();
        Tome = new WeaponRankDetails();

    }
}
