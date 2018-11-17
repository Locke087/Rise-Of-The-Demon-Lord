using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClassWeapons {

    public ClassWeaponDetail classWeapon1;
    public ClassWeaponDetail classWeapon2;
    public ClassWeapons()
    {
        classWeapon1 = new ClassWeaponDetail();
        classWeapon2 = new ClassWeaponDetail();
    }
}
