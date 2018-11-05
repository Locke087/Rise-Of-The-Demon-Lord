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
        MapLocation map = FindMap();
        List<GridTiles> tiles = new List<GridTiles>();

        foreach (Rows row in map.allRows)
        {
            map.allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in map.allTiles)
            {
                if (tile.playerSpawn && tile.walkable) tiles.Add(tile);
            }
        }
        return tiles;
    }

}
