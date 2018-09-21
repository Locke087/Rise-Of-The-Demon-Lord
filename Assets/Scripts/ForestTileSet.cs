using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestTileSet : MonoBehaviour {


    public List<GameObject> cleanTiles;
    public List<GameObject> gapTiles;
    public List<GameObject> wallTiles;
    public List<GameObject> rewardTiles;
    public List<GameObject> defenseTiles;
    public string clean = "ForestTileClean";
    public string gap = "ForestTileGap";



    //
    //Names of Tile is Unique so it can be loaded from Resources
    //Tag of Tile is N, S, E, W
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadCleanTiles()
    {
        for (int i = 0; i < 16; i++)
        {
            GameObject tiles = GameObject.Instantiate(Resources.Load(clean + i.ToString())) as GameObject;
            cleanTiles.Add(tiles);

        }
    }

    void LoadGapTiles()
    {
        for (int i = 0; i < 16; i++)
        {
            GameObject tiles = GameObject.Instantiate(Resources.Load(gap + i.ToString())) as GameObject;
            gapTiles.Add(tiles);

        }
    }


}
