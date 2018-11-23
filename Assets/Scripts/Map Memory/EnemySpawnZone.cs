using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnZone : MonoBehaviour {

    
    public List<NewSpawnPoint> spawnPoints;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    public void SpawnEnemies()
    {
        Debug.Log("letsANOOOOOO");
        EventDriver eventDrivers = GameObject.FindObjectOfType<EventDriver>();
        List<GridTiles> locations = new List<GridTiles>();
        locations.AddRange(eventDrivers.FindEnemySpawns());
        string tileId = "";
        spawnPoints = new List<NewSpawnPoint>();
        foreach (Unit play in CurrentGame.game.memoryGeneral.enemiesInMaps.units)
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
            GameObject temp = Resources.Load("EnemyCopy") as GameObject;
            temp.GetComponent<Stats>().unitID = newSpawn.enemyID.unitID;
            temp.name = newSpawn.enemyID.unitID;
            Instantiate(temp, GameObject.Find(newSpawn.tileID).transform.position + new Vector3(0, (1.4f + GameObject.Find(newSpawn.tileID).transform.position.y), 0), setQuaterRotation(0, 0, 0));
           
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
        public Unit enemyID;
        public string tileID;
        public NewSpawnPoint(Unit pID, string tID)
        {
            enemyID = pID;
            tileID = tID;
        }
    }

}
