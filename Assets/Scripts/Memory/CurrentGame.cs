using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CurrentGame 
{

    public static CurrentGame game;
    public UnitStoreroom storeroom;
    public Character fileName;
    public OverGrownLabyrinthTileSet overGrown;
    public MemoryGeneralGame memoryGeneral;
    public CurrentGame()
    {
        fileName = new Character();
        storeroom = new UnitStoreroom();
        overGrown = new OverGrownLabyrinthTileSet();
        memoryGeneral = new MemoryGeneralGame();

    }
}
