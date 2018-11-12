using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OGRoutLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        RiptoMapFromMemory();
        GenerateMap();
        PlaceUIOveraly();

        GameObject.Find("Template36x40test").SetActive(false);
        StartCoroutine(setUpMap());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator setUpMap()
    {
        GameObject map = GameObject.Find("TheMap");
        yield return new WaitForSeconds(0.01f);
        map.GetComponent<MapSetup>().SetUp();
    }

    public void RiptoMapFromMemory()
    {

        // GameObject memory = GameObject.Find("I Reme");

        GameObject map = GameObject.Find("Template36x40test");
        GroupingOrganizer organizer = map.GetComponent<GroupingOrganizer>();
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        List<GridTiles> everyTile = new List<GridTiles>();
        bool complete = false;
        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                everyTile.Add(tile);
            }


        }

        List<AreaDirector> list = new List<AreaDirector>();
        list = CurrentGame.game.overGrown.rout.allAreas.areaDirectors;
        organizer.StartUp();
        do
        {
            organizer.taken.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                complete = true;
                if (organizer.redo)
                {
                    Debug.Log("DoOver");
                    organizer.redo = false;
                    i = 0;
                }
                bool done = false;

                do
                {

                    int numk = Random.Range(0, list[i].areas.Count);

                    if (organizer.IsItTaken(list[i].areas[numk].indent))
                    {
                        organizer.taken.Add(list[i].areas[numk].indent);
                        if (organizer.Checklist(list[i].areas[numk].id))
                        {
                            organizer.resetAInRows = 0;
                            done = true;
                            foreach (RowHolder otherRow in list[i].areas[numk].rows)
                            {
                                foreach (TileHolder tiler in otherRow.tiles)
                                {
                                    foreach (GridTiles tile in everyTile)
                                    {
                                        if (tile.name == tiler.id) tile.ReflectMe(tiler);
                                    }
                                }

                            }
                        }
                    }

                    if (organizer.redo)
                    {
                        organizer.taken.Clear();
                        foreach (GridTiles tile in everyTile)
                        {

                            tile.Clean();
                        }
                    }


                } while (!done && !organizer.stop && !organizer.redo);
                if (organizer.stop) Debug.Log("deleted");


            }
            foreach (GridTiles tile in everyTile)
            {
                if (tile.tag == "Tile") complete = false;
            }
        } while (!complete);

        List<GridTiles> everyTile2 = new List<GridTiles>();

        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                everyTile2.Add(tile);
            }


        }

        List<AreaDirector> pAreas = new List<AreaDirector>();
        List<AreaDirector> eAreas = new List<AreaDirector>();
        // List<AreaDirector> list = new List<AreaDirector>();

        foreach (AreaDirector group in list)
        {
            if (group.spawn == "PlayerSpawn")
            {
                pAreas.Add(group);
            }
            else if (group.spawn == "EnemySpawn")
            {
                eAreas.Add(group);
            }
        }




        int numb = Random.Range(0, pAreas.Count);
        foreach (AreaHolder map1 in pAreas[numb].areas)
        {
            foreach (RowHolder otherRow in map1.rows)
            {
                foreach (TileHolder tiler in otherRow.tiles)
                {
                    foreach (GridTiles tile in everyTile2)
                    {
                        if (tile.name == tiler.id)
                        {
                            tile.CheckSpawnType(tiler.spawn);
                        }

                    }
                }
            }
        }

        int nump = Random.Range(0, pAreas.Count);
        do
        {
            nump = Random.Range(0, pAreas.Count);
        } while (nump == numb);

        foreach (AreaHolder map1 in pAreas[nump].areas)
        {
            foreach (RowHolder otherRow in map1.rows)
            {
                foreach (TileHolder tiler in otherRow.tiles)
                {
                    foreach (GridTiles tile in everyTile)
                    {
                        if (tile.name == tiler.id) tile.CheckSpawnType(tiler.spawn);
                    }
                }
            }
        }

        int num1 = Random.Range(0, eAreas.Count);
        foreach (AreaHolder map1 in eAreas[num1].areas)
        {
            foreach (RowHolder otherRow in map1.rows)
            {
                foreach (TileHolder tiler in otherRow.tiles)
                {
                    foreach (GridTiles tile in everyTile)
                    {
                        if (tile.name == tiler.id) tile.CheckSpawnType(tiler.spawn);
                    }
                }
            }
        }

        int num2 = Random.Range(0, eAreas.Count);
        do
        {
            num2 = Random.Range(0, eAreas.Count);
        } while (num2 == num1);

        foreach (AreaHolder map1 in eAreas[num2].areas)
        {
            foreach (RowHolder otherRow in map1.rows)
            {
                foreach (TileHolder tiler in otherRow.tiles)
                {
                    foreach (GridTiles tile in everyTile)
                    {
                        if (tile.name == tiler.id) tile.CheckSpawnType(tiler.spawn);
                    }
                }
            }
        }

        int num3 = Random.Range(0, eAreas.Count);
        do
        {
            num3 = Random.Range(0, eAreas.Count);
        } while (num3 == num1 && num3 == num2);

        foreach (AreaHolder map1 in eAreas[num3].areas)
        {
            foreach (RowHolder otherRow in map1.rows)
            {
                foreach (TileHolder tiler in otherRow.tiles)
                {
                    foreach (GridTiles tile in everyTile)
                    {
                        if (tile.name == tiler.id) tile.CheckSpawnType(tiler.spawn);
                    }
                }
            }
        }


        int num4 = Random.Range(0, eAreas.Count);
        do
        {
            num4 = Random.Range(0, eAreas.Count);
        } while (num4 == num1 && num4 == num2 && num4 == num3);

        foreach (AreaHolder map1 in eAreas[num4].areas)
        {
            foreach (RowHolder otherRow in map1.rows)
            {
                foreach (TileHolder tiler in otherRow.tiles)
                {
                    foreach (GridTiles tile in everyTile)
                    {
                        if (tile.name == tiler.id) tile.CheckSpawnType(tiler.spawn);
                    }
                }
            }
        }

    }


    public void GenerateMap()
    {
        GameObject maps = GameObject.Find("Template36x40test");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        int i = 0;
        GameObject map = new GameObject();
        map.AddComponent<MapLocation>();
        map.AddComponent<MapManager>();
        map.AddComponent<SpeedCenterTurns>();
        map.GetComponent<SpeedCenterTurns>().cam = GameObject.Find("TheCamera");

        map.AddComponent<EventDriver>();
        map.AddComponent<Rout>();
        map.AddComponent<Success>();
        map.AddComponent<GameOver>();
        map.AddComponent<MoveSwitch>();
        map.AddComponent<EnemySpawnZone>();
        map.AddComponent<PlayerSpawnZone>();
        map.AddComponent<MapSetup>();

        map.transform.position = maps.transform.position;
        map.transform.parent = GameObject.Find("Map Overlay").transform;
        map.name = "TheMap";
        int r = 0;
        int f = 0;
        foreach (Rows row in allRows)
        {
            int j = 0;

            GameObject newRow = new GameObject();
            newRow.transform.parent = map.transform;
            newRow.AddComponent<Rows>();
            newRow.transform.localPosition = new Vector3(0, 0, i);
            newRow.name = "og" + r;


            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {


                //Higher Ground Could Be by Checking the Y axis 1 for High Ground .5 for ramp

                if (tile.tag == "Rivers")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, tile.transform.localPosition.y, 0);
                        // tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;

                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, 0, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                if (tile.tag == "RiverH")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {

                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }

                //
                //  __  ___
                // |90  180|
                //   WaterCorner Directions
                // |0   270|
                //  --  ---  
                else if (tile.tag == "RiverC")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("WaterCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("WaterCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                    }
                }

                else if (tile.tag == "LakeC")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "LakeS")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeSide")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LakeSide")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "LakeM")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("MidLake")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("MidLake")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                if (tile.tag == "Rivers")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, tile.transform.localPosition.y, 0);
                        // tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;

                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, 0, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                if (tile.tag == "RiverH")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {

                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("River piece")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }

                if (tile.tag == "LavaR")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverLine")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, tile.transform.localPosition.y, 0);
                        // tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("Dirt");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.position.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;

                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverLine")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.transform.localPosition = new Vector3(j - 0.25f, 0, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                if (tile.tag == "LavaH")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {

                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverLine")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;


                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("LavaGround");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverLine")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0.25f);
                        tiles.transform.localRotation *= Quaternion.Euler(0, 90f, 0);
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }

                //
                //  __  ___
                // |90  180|
                //   WaterCorner Directions
                // |0   270|
                //  --  ---  

                else if (tile.tag == "LavaRC")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("LavaGround");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }

                else if (tile.tag == "LavaLC")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("LavaGround");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaCorner")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "LavaLS")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaSide")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("LavaGround");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaSide")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "LavaLM")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaMid")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>("LavaGround");
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaMid")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "River";
                        tiles.AddComponent<GridTiles>();
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                }
                else if (tile.tag == "DoorC")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LockedDoor")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.GetComponentInChildren<GridTiles>().TransferColor(tile.TileColor());
                        tiles.tag = "Door";
                        // tiles.AddComponent<GridTiles>();
                        // tiles.GetComponent<GridTiles>().walkable = false;
                        tiles.GetComponentInChildren<GridTiles>().walkable = false;
                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LockedDoor")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "Door";
                        tiles.GetComponentInChildren<GridTiles>().TransferColor(tile.TileColor());
                        tiles.GetComponentInChildren<GridTiles>().walkable = false;
                        // tiles.AddComponent<GridTiles>();
                        // tiles.GetComponent<GridTiles>().walkable = false;

                    }
                }
                else if (tile.tag == "ChestC")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Chest")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y + 0.75f, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.GetComponentInChildren<GridTiles>().TransferColor(tile.TileColor());

                        tiles.tag = "Chest";

                        tiles.GetComponentInChildren<GridTiles>().walkable = false;

                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                    else
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("Chest")) as GameObject;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0.75f, 0);
                        tiles.transform.localRotation = tile.transform.localRotation;
                        tiles.tag = "Chest";
                        tiles.GetComponentInChildren<GridTiles>().TransferColor(tile.TileColor());
                        tiles.GetComponentInChildren<GridTiles>().walkable = false;


                    }
                }

                // Ramp Directions Y
                //       A
                //      90
                //<- 0     180-> (Lip)
                //      270
                //       V
                else if (tile.tag == "Normal")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {

                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        if (!tile.hazard)
                        {
                            tiles.GetComponent<GridTiles>().walkable = true;
                            tiles.GetComponent<GridTiles>().distance = 5;
                        }
                        else
                        {
                            tiles.GetComponent<GridTiles>().walkable = false;
                            tiles.GetComponent<GridTiles>().distance = 5;
                        }
                        tiles.transform.localScale = new Vector3(1, (tile.transform.localPosition.y + 1), 1);
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y / 2, 0);
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        if (!tile.hazard)
                        {
                            tiles.GetComponent<GridTiles>().walkable = true;
                            tiles.GetComponent<GridTiles>().distance = 5;
                        }
                        else
                        {
                            tiles.GetComponent<GridTiles>().walkable = false;
                            tiles.GetComponent<GridTiles>().distance = 5;
                        }
                    }
                }
                else if (tile.tag == "RampE")
                {
                    GameObject tiles = GameObject.Instantiate(Resources.Load("Ramp")) as GameObject;
                    tiles.transform.parent = newRow.transform;
                    tiles.name = "og" + f + "r" + r;
                    f++;
                    tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                    tiles.transform.localRotation = tile.transform.localRotation;
                    Material material = Resources.Load<Material>(tile.TileColor());
                    tiles.GetComponent<Renderer>().material = material;
                    tiles.tag = "Ramp";
                    tiles.AddComponent<GridTiles>();

                    if (!tile.hazard)
                    {
                        tiles.GetComponent<GridTiles>().walkable = true;
                        tiles.GetComponent<GridTiles>().distance = 5;
                    }
                    else
                    {
                        tiles.GetComponent<GridTiles>().walkable = false;
                        tiles.GetComponent<GridTiles>().distance = 5;
                    }

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tilesn = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        tilesn.transform.parent = newRow.transform;
                        tilesn.GetComponent<Renderer>().material = material;
                        tilesn.transform.localPosition = new Vector3(j, 1, 0);
                        tilesn.transform.localScale = new Vector3(1, (tile.transform.localPosition.y), 1);
                        tilesn.transform.localPosition += new Vector3(0, 0.5f * (tile.transform.localPosition.y + 1), 0);
                        tilesn.transform.localPosition += Vector3.down + Vector3.down;
                        tilesn.transform.parent = tiles.transform;
                    }
                }

                else if (tile.tag == "Gap")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = new GameObject();
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tile.GetComponent<GridTiles>().walkable = false;
                        tiles.AddComponent<BoxCollider>();
                        tiles.GetComponent<BoxCollider>().transform.localScale += new Vector3(0, 10, 0);
                    }
                    else
                    {
                        GameObject tiles = new GameObject();
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tile.GetComponent<GridTiles>().walkable = false;
                        tiles.AddComponent<BoxCollider>();
                        tiles.GetComponent<BoxCollider>().transform.localScale += new Vector3(0, 10, 0);
                    }
                }
                else if (tile.tag == "Walls")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, 3 + tile.transform.localPosition.y, 1);
                        tiles.transform.position += Vector3.up;
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.parent = newRow.transform;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, 3, 1);
                        tiles.transform.position += Vector3.up;
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }



                }
                else if (tile.tag == "LongWall")
                {

                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, tile.transform.localPosition.y, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, (tile.transform.localPosition.y + 2), 1);
                        tiles.transform.localPosition = new Vector3(j, (tile.transform.localPosition.y / 2) + 0.5f, 0);
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }
                    else
                    {
                        GameObject tiles = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        Material material = Resources.Load<Material>(tile.TileColor());
                        tiles.GetComponent<Renderer>().material = material;
                        tiles.transform.parent = newRow.transform;
                        tiles.name = "og" + f + "r" + r;
                        f++;
                        tiles.transform.localPosition = new Vector3(j, 0, 0);
                        tiles.tag = "Tile";
                        tiles.AddComponent<GridTiles>();
                        tiles.transform.localScale = new Vector3(1, 3, 1);
                        tiles.transform.position += Vector3.up;
                        tiles.GetComponent<GridTiles>().walkable = false;
                    }

                }
                /*else
                {
                    GameObject tiles = new GameObject();
                    tiles.AddComponent<GridTiles>();
                    tiles.transform.parent = newRow.transform;
                    tiles.name = "rr" + f + "r" + r;
                }*/
                j++;
            }
            i++;
            r++;
            f = 0;
        }
    }


    public void PlaceUIOveraly()
    {
        GameObject map = GameObject.Find("TheMap");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //

            foreach (GridTiles tile in allTiles)
            {

                GameObject uiOveraly = GameObject.Instantiate(Resources.Load("UIoverlay")) as GameObject;
                uiOveraly.transform.parent = tile.transform;
                uiOveraly.transform.localPosition = new Vector3(0, 0.53f, 0);

            }
            r++;
        }
       
    }
    
}
