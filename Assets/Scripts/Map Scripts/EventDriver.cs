using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDriver : MonoBehaviour
{


    public MapLocation FindMap()
    {
        MapLocation mapLocation = null;
        MapLocation[] allMaps = GameObject.FindObjectsOfType<MapLocation>();

        foreach (MapLocation map in allMaps)
        {
            if (map.inMap == true) mapLocation = map;
        }

        return mapLocation;
    }


    public string FindParty()
    {
        MapLocation map = FindMap();

        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.unit != null)
                {
                    if (tile.unit.GetComponent<UnitParty>() != null && tile.unit.GetComponent<EnemyMove>() != null)
                    {
                        return tile.unit.name;
                    }
                }
            }
        }
        return "none";
    }

    public GridTiles FindPartyLocaton()
    {
        MapLocation map = FindMap();
        GridTiles tiles = null;

        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.unit != null)
                {
                    if (tile.unit.GetComponent<UnitParty>() != null && tile.unit.GetComponent<EnemyMove>() != null)
                    {
                        return tile;
                    }
                }
            }
        }
        return tiles;
    }

    public GridTiles FindPlayerLocaton()
    {
        MapLocation map = FindMap();
        GridTiles tiles = null;
        
        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.unit != null)
                {
                    if (tile.unit.GetComponent<UnitParty>() != null && tile.unit.GetComponent<MCMove>() != null)
                    {
                        return tile;
                    }
                }
            }
        }
        return tiles;
    }


    public List<GridTiles> FindPlayerSpawns()
    {
        MapLocation map = GameObject.FindObjectOfType<MapLocation>();
        List<GridTiles> tiles = new List<GridTiles>();
        bool valid = false;
        Debug.Log(map.name);
        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.playerSpawn && tile.walkable)
                {
                    Debug.Log("got it");
                    if (tiles.Count > 0)
                    {
                        valid = true;
                        foreach (GridTiles newTile in tiles)
                        {
                            float toClose = Vector3.Distance(tile.transform.position, newTile.transform.position);
                            if (toClose <= 1) valid = false;

                        }
                        if (valid)
                        {
                            Debug.Log("got inp");
                            tiles.Add(tile);
                        }
                    }
                    else
                    {
                        Debug.Log("got binp");
                        tiles.Add(tile);
                    }
                }
            }
        }
        return tiles;
    }

    public List<GridTiles> FindEnemySpawns()
    {
        MapLocation map = GameObject.FindObjectOfType<MapLocation>();
        List<GridTiles> tiles = new List<GridTiles>();
        bool valid = false;
        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.enemySpawn && tile.walkable)
                {
                    Debug.Log("got inj");
                    if (tiles.Count > 0)
                    {
                        valid = true;
                        foreach (GridTiles newTile in tiles)
                        {
                            float toClose = Vector3.Distance(tile.transform.position, newTile.transform.position);
                            if (toClose <= 1) valid = false;

                        }
                        if (valid)
                        {
                           
                            tiles.Add(tile);
                        }
                    }
                    else
                    {
                        Debug.Log("got bine");
                        tiles.Add(tile);
                    }
                }

            }
        }
        return tiles;
    }

    public List<GridTiles> FindReinforcementSpawns()
    {
        MapLocation map = GameObject.FindObjectOfType<MapLocation>();
        List<GridTiles> tiles = new List<GridTiles>();
        bool valid = false;
        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.reinforcementSpawn && tile.walkable)
                {
                    if (tiles.Count > 0)
                    {
                        valid = true;
                        foreach (GridTiles newTile in tiles)
                        {
                            float toClose = Vector3.Distance(tile.transform.position, newTile.transform.position);
                            if (toClose <= 1) valid = false;

                        }
                        if (valid) tiles.Add(tile);


                    }
                    else tiles.Add(tile);
                }
            }
        }
        return tiles;
    }

    public List<GridTiles> FindBossSpawns()
    {
        MapLocation map = GameObject.FindObjectOfType<MapLocation>();
        List<GridTiles> tiles = new List<GridTiles>();
    
        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.bossSpawn && tile.walkable)
                {
                    tiles.Add(tile);
                }
            }
        }
        return tiles;
    }

    public List<GridTiles> FindRecruitSpawns()
    {
        MapLocation map = GameObject.FindObjectOfType<MapLocation>();
        List<GridTiles> tiles = new List<GridTiles>();
     
        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.recuitSpawn && tile.walkable)
                {
                   tiles.Add(tile);                  
                }

            }
        }
        return tiles;
    }

}
