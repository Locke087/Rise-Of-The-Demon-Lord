using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : TileSets {

	// Use this for initialization
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TheCurrentTileSet(string set)
    {
        WhichTileSet(set);

    }

    //Area Section Spacing will be custom based on shape maps 

    //Generate By First Checking Tile Set then Gametype then decide a code mold/shape map based on that 
    //then go Area by Area though the differant code molds or shape maps, all the way storing the results in a list label by area.
    //then with thoughs lists in tow go back though and generate it from the mold

    public void GenerateTemp()
    {
        GameObject Map = new GameObject();

    }
}
