using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : TileSets {

    // Use this for initialization
    public GameObject Area1Section;
    public GameObject Area2Section;
    public GameObject Area3Section;
    public GameObject Area4Section;
    public GameObject Area5Section;
    public GameObject Area6Section;
    public GameObject Area7Section;
    public GameObject Area8Section;
    public GameObject Area9Section;
    public GameObject Area10Section;
    public GameObject Area11section;
    public GameObject Area12Section;
    public GameObject Area13Section;
    public GameObject Area14Section;
    public GameObject Area15Section;

    /// <summary>
    /// Tile Allotments: Objective: 2, Gap: 1, Reward: 3, Clean: 6, Wall: 3, 15 total areas
    /// </summary>

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
    //Calculation for Area Boarder equal greatest section X (right) quad * 2 & greatest section Z (top) quad * 2 

    //Generate By First Checking Tile Set then Gametype then decide a code mold/shape map based on that 
    //then go Area by Area though the differant code molds or shape maps, all the way storing the results in a list label by area.
    //then with thoughs lists in tow go back though and generate it from the mold

    public void DonutShapeMap()
    {
        GameObject Map = new GameObject();

        GameObject Area1 = new GameObject();
        Area1.transform.parent = Map.transform;
        Area1.transform.localPosition = new Vector3(0, 0, 0);
        int[] x = { 0, 4, 0, 4 };
        int[] z = { 1, 1, -3, -3};
     
        GameObject Area2 = new GameObject();
        Area2.transform.parent = Map.transform;
        Area2.transform.localPosition = new Vector3(8, 0, 0);
    
        
        GameObject Area3 = new GameObject();
        Area3.transform.parent = Map.transform;
        Area3.transform.localPosition = new Vector3(16, 0, 0);
      

        GameObject Area4 = new GameObject();
        Area4.transform.parent = Map.transform;
        Area4.transform.localPosition = new Vector3(0, 0, 8);
      
      
        GameObject Area5 = new GameObject();
        Area5.transform.parent = Map.transform;
        Area5.transform.localPosition = new Vector3(8, 0, 8);
       

        GameObject Area6 = new GameObject();
        Area6.transform.parent = Map.transform;
        Area6.transform.localPosition = new Vector3(16, 0, 8);
      

        GameObject Area7 = new GameObject();
        Area7.transform.parent = Map.transform;
        Area7.transform.localPosition = new Vector3(0, 0, 16);

      

        GameObject Area8 = new GameObject();
        Area8.transform.parent = Map.transform;
        Area8.transform.localPosition = new Vector3(8, 0, 16);
       

        GameObject Area9 = new GameObject();
        Area9.transform.parent = Map.transform;
        Area9.transform.localPosition = new Vector3(16, 0, 16);

        /*foreach (GameObject sect in Area9Sections)
        {
            sect.transform.parent = Area9.transform;
            sect.transform.localPosition = new Vector3(x[i], 0, z[i]);
            i++;
        }*/


    }
}
