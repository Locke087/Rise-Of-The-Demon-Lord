using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSets : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> CurrentTileSetClean;
    public List<GameObject> CurrentTileSetGap;
    public List<GameObject> CurrentTileSetWall;
    public List<GameObject> CurrentTileSetReward;
    public ForestTileSet forestTileSet;
    public string forestSet = "forest";
    void Start () {
        CurrentTileSetClean = new List<GameObject>();
        CurrentTileSetGap = new List<GameObject>();
        CurrentTileSetWall = new List<GameObject>();
        CurrentTileSetReward = new List<GameObject>();
        forestTileSet = gameObject.GetComponent<ForestTileSet>();
	}
	/// <summary>
    /// Tile Allotments: Objective: 2, Gap: 1, Reward: 3, Clean: 6, Wall: 3, 15 total areas
    /// </summary>
	// Update is called once per frame
	void Update () {
		
	}

    public void WhichTileSet(string set)
    {
        if (set == forestSet) LoadForestSet();
    }

    public void LoadForestSet()
    {
        CurrentTileSetClean = forestTileSet.cleanTiles;
        CurrentTileSetGap = forestTileSet.gapTiles;
        CurrentTileSetWall = forestTileSet.wallTiles;
        CurrentTileSetReward = forestTileSet.rewardTiles;
    }
}
