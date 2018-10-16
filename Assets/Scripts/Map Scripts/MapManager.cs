using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if (currentUser != null)
        {
            GameObject.FindObjectOfType<PlayerUnitMenu>().movedFinished = true;
            GameObject.FindObjectOfType<PlayerUnitMenu>().move.gameObject.GetComponent<Image>().color = Color.gray;
            StartCoroutine(currentUser.GetComponent<MapPlayerMove>().GoMove(tile.GetComponent<GridTiles>()));
        }
    }

    public void PlayerAttack(GameObject tile, GameObject enemy)
    {
        if (currentUser != null)
        {
            enemy.GetComponent<Stats>().attacked(currentUser.GetComponent<Stats>());
            GameObject.FindObjectOfType<PlayerUnitMenu>().attackFinished = true;
            GameObject.FindObjectOfType<PlayerUnitMenu>().attack.gameObject.GetComponent<Image>().color = Color.gray;
            currentUser.GetComponent<MapPlayerAttack>().attack();

        }

    }

   /* public void PlayerAttackTrue()
    {
        if (currentUser != null)
        {
            GameObject.FindObjectOfType<PlayerUnitMenu>().attackFinished = true;
            GameObject.FindObjectOfType<PlayerUnitMenu>().attack.gameObject.GetComponent<Image>().color = Color.gray;
            currentUser.GetComponent<MapPlayerAttack>().attack();

        }

    }

    public void AttackFalse()
    {
        currentUser.GetComponent<MapPlayerAttack>().attack();
    }*/
}
