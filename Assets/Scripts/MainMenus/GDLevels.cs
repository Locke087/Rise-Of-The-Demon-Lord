using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GDLevels {

    public CurrentLevel level1;
    public CurrentLevel level2;
    public CurrentLevel level3;
    public CurrentLevel level4;
    public CurrentLevel level5;
    public CurrentLevel level6;
    public CurrentLevel level7;
    public CurrentLevel level8;
    public CurrentLevel level9;
    public CurrentLevel level10;
    public CurrentLevel level11;
    public CurrentLevel level12;

    public GDLevels()
    {
        level1 = new CurrentLevel();
        level2 = new CurrentLevel();
        level3 = new CurrentLevel();
        level4 = new CurrentLevel();
        level5 = new CurrentLevel();
        level6 = new CurrentLevel();
        level7 = new CurrentLevel();
        level8 = new CurrentLevel();
        level9 = new CurrentLevel();
        level11 = new CurrentLevel();
        level12 = new CurrentLevel();
    }
}
