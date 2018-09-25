using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathwayTile : MonoBehaviour {
  
    /// <summary>
    /// Tile to complete see if a door is needed for wall prefabs 
    /// and or path connection acrossed things like rivers.  
    /// </summary>
    // Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Connections(bool path, string type, string open, string close)
    {
        if (path) gameObject.tag = open;
        else gameObject.tag = close;
    }
}
