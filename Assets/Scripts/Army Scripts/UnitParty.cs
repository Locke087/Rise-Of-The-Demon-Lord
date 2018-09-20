using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitParty : MonoBehaviour
{


    GameObject mainParty;
    public List<GameObject> friendlyUnits = new List<GameObject>();
    public List<GameObject> enemyUnits = new List<GameObject>();
    public List<GameObject> partyList = new List<GameObject>();
    bool friendly = false;
    bool goodToGo = false;
    public int levelUP = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (goodToGo)
        {
            if (friendly) CreatePlayerList();
            else if (!friendly) CreateEnemyList();
        }
    }

    public void CurrentParty(List<GameObject> list)
    {
        partyList = list;
        goodToGo = true;
    }

    public void FriendOrFoe(bool friend)
    {
        if (friend) friendly = true;
        else if (!friend) friendly = false;
    }

    public void CreatePlayerList()
    {
        foreach (GameObject player in partyList)
        {
            if (player.GetComponent<PlayerUnit>() != null) friendlyUnits.Add(player);
        }
        goodToGo = false;
    }

    public void EnemyLevel(int level)
    {
        levelUP = level;
    }

    public void CreateEnemyList()
    {
        foreach (GameObject player in partyList)
        {
            if (player.GetComponent<UnitParty>() == null)
            {
                enemyUnits.Add(player);

            }
        }
        goodToGo = false;
    }
}
