using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnZone : MonoBehaviour {


    public List<string> allPlayers;
    // Use this for initialization
    void Start()
    {
        allPlayers = new List<string>();
    }

    // Update is called once per frame

    public void SpawnPlayers()
    {
        EventDriver eventDrivers = GameObject.FindObjectOfType<EventDriver>();
        List<GridTiles> locations = new List<GridTiles>();
        locations.AddRange(eventDrivers.FindPlayerSpawns());
        string tileId = "";
        string playerId = "";
        List<NewSpawnPoint> spawnPoints = new List<NewSpawnPoint>();
        foreach (string play in allPlayers)
        {
            do
            {
                int num = Random.Range(0, locations.Count);
                if (!locations[num].taken) tileId = locations[num].name;

             } while (tileId == "");

            spawnPoints.Add(new NewSpawnPoint(play, tileId));
            tileId = "";

        }
    }


    IEnumerator mapPlacer()
    {
        EventDriver eventDrivers = GameObject.FindObjectOfType<EventDriver>();
        //  enemyLeader = eventDrivers.FindParty();

        MCMove mcMove = GameObject.FindObjectOfType<MCMove>();
        // enemyUnitParty = GameObject.Find(enemyLeader).gameObject.GetComponent<UnitParty>();
        UnitParty playerUnitParty = mcMove.gameObject.GetComponent<UnitParty>();
        ////   List<string> newEnemyLocations = CalcQuadEnemy();
        //   List<string> newPlayerLocations = CalcQuadPlayer();


        for (int i = 0; i < playerUnitParty.friendlyUnits.Count; i++)
        {
            //     Instantiate(playerUnitParty.friendlyUnits[i], GameObject.Find(newPlayerLocations[i]).transform.position + new Vector3(0, 1.4f, 0), setQuaterRotation(0, 0, 0));
        }
        //  goodGo = false;
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<SpeedCenterTurns>().Ordering();
    }

    [System.Serializable]
    public class NewSpawnPoint
    {
        public string playerID;
        public string tileID;
        public NewSpawnPoint(string pID, string tID)
        {
            playerID = pID;
            tileID = tID;
        }
    }


}
