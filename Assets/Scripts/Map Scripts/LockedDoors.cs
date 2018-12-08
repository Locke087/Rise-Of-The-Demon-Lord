using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoors : MonoBehaviour {

    public GameObject door;
    public GameObject lockp;
    public GridTiles tiles;
	public void OpenTheWay()
    {
        StartCoroutine(Opening());
    }

    IEnumerator Opening()
    {
        lockp.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        door.SetActive(false);
        tiles.walkable = true;  
        tiles.tag = "Tile";
        // gameObject.tag = "Tile";
        // gameObject.GetComponent<GridTiles>().walkable = true;
    }
}
