using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnZone : MonoBehaviour {


    public List<NewSpawnPoint> spawnPoints;
    public List<GridTiles> locations;
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame

    public void SpawnPlayers()
    {
        Debug.Log("letsAGO");
        EventDriver eventDrivers = GameObject.FindObjectOfType<EventDriver>();
        locations = new List<GridTiles>();
        locations.AddRange(eventDrivers.FindPlayerSpawns());
        string tileId = "";
        spawnPoints = new List<NewSpawnPoint>();
        foreach (Unit play in CurrentGame.game.memoryGeneral.unitsInParty)
        {
              do
              {
                int num = Random.Range(0, locations.Count);
                if (!locations[num].taken)
                {
                    locations[num].taken = true;
                    tileId = locations[num].name;
                }


               } while (tileId == "");

            spawnPoints.Add(new NewSpawnPoint(play, tileId));
            tileId = "";
            
        }
        mapPlacer();
    }


    void mapPlacer()
    {
       
        foreach (NewSpawnPoint newSpawn in spawnPoints)
        {

            GameObject temp = Resources.Load("PlayerCopy") as GameObject;
            temp.GetComponent<Stats>().unitID = newSpawn.playerID.unitID;
            temp.name = newSpawn.playerID.unitID;
            Instantiate(temp, GameObject.Find(newSpawn.tileID).transform.position + new Vector3(0, 0, 0), setQuaterRotation(0, 0, 0));
       
           // temp.
        }

    }

    private static Quaternion setQuaterRotation(float x, float y, float z)
    {
        Quaternion newQuaternion = new Quaternion();
        newQuaternion.Set(x, y, z, 1);
        return newQuaternion;
    }

    [System.Serializable]
    public class NewSpawnPoint
    {
        public Unit playerID;
        public string tileID;
        public NewSpawnPoint(Unit pID, string tID)
        {
            playerID = pID;
            tileID = tID;
        }
    }


}
