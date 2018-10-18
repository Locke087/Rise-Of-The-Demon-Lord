using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UnitClass {

    public UnitMainClass main;
    public UnitSubClass sub;
    
    public UnitClass()
    {
        main = new UnitMainClass();
        sub = new UnitSubClass();

    }
}
