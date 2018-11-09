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
    public GrowlingDeepsTileSet growlingDeeps;
    public FrozenTundraTileSet frozenTundra;
    public ScorchingWastesTileSet scorchingWastes;
    public MemoryGeneralGame memoryGeneral;
    public CurrentGame()
    {
        fileName = new Character();
        storeroom = new UnitStoreroom();
        overGrown = new OverGrownLabyrinthTileSet();
        growlingDeeps = new GrowlingDeepsTileSet();
        frozenTundra = new FrozenTundraTileSet();
        scorchingWastes = new ScorchingWastesTileSet();
        memoryGeneral = new MemoryGeneralGame();

    }
}
