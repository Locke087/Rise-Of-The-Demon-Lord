using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour {

    // Use this for initialization

    public GameObject currentUser;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UserSet(GameObject user)
    {
        currentUser = user;
    }

    public void UserRemove()
    {
        currentUser = null;
    }

    public void PlayerMove(GameObject tile)
    {
        if (currentUser != null) StartCoroutine(currentUser.GetComponent<MapPlayerMove>().GoMove(tile.GetComponent<GridTiles>()));        
    }

    public void PlayerAttack(GameObject tile, GameObject enemy)
    {
        if (currentUser != null)
        {
            enemy.GetComponent<Stats>().attacked(currentUser.GetComponent<Stats>());
            currentUser.GetComponent<MapPlayerAttack>().attack(tile.GetComponent<GridTiles>());
        }
        
    }
}
