using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UnitClassDetail {

    public int level;
    public UnitClassSkill pickSkill;
    public UnitClassDetail()
    {
        level = 0;
        pickSkill = new UnitClassSkill();
    }
}
