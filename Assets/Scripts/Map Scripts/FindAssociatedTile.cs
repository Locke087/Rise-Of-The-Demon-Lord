using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindAssociatedTile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public static GridTiles FindMyTile(Vector3 loc, GameObject group)
    {
        List<GameObject> allTiles = new List<GameObject>();
        allTiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));

        foreach (GameObject t in allTiles)
        {           
            if (t.transform.localPosition.x == (group.transform.localPosition.x + loc.x) && t.transform.parent.transform.localPosition.z == (group.transform.localPosition.z + loc.y))
            {
                return t.GetComponent<GridTiles>();
            }
        }
        return null;
    }
}
