using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class MenuScript
{

    //my tools

    [MenuItem("Tools/Assign Custom Material")]
    public static void AssignCustomMaterial()
    {
        GameObject something = GameObject.Find("StartMenuInField");

        Material material = Resources.Load<Material>("InFieldSkin");
        something.GetComponent<Renderer>().material = material;

        something = GameObject.Find("StartMenuInBattle");

        material = Resources.Load<Material>("InBattleSkin");
        something.GetComponent<Renderer>().material = material;


        something = GameObject.Find("Battle UI");

        material = Resources.Load<Material>("SeeThough");
        something.GetComponent<Renderer>().material = material;
    }

    [MenuItem("Tools/Color Tiles")]
    public static void ColorIT()
    {

        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Normal");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().ColorSelf();
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Rivers");
        Material material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("RiverC");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("RiverH");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {

                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LakeC");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("LakeM");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LavaR");
        material = Resources.Load<Material>("Lava");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("LavaH");
        material = Resources.Load<Material>("Lava");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
              
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("LavaRC");
        material = Resources.Load<Material>("Lava");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
               
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LavaLC");
        material = Resources.Load<Material>("Lava");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }
        tiles = GameObject.FindGameObjectsWithTag("LavaLM");
        material = Resources.Load<Material>("Lava");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }


        tiles = GameObject.FindGameObjectsWithTag("LavaLS");
        material = Resources.Load<Material>("Lava");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }


        tiles = GameObject.FindGameObjectsWithTag("ChestC");
        material = Resources.Load<Material>("Treasure");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("DoorC");
        material = Resources.Load<Material>("Door");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("DoorC");
        material = Resources.Load<Material>("Door");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LakeS");
        material = Resources.Load<Material>("Rivers");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<Renderer>().material = material;

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("RampE");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().TurnSelf();
                t.GetComponent<GridTiles>().ColorSelf();

            }
        }

        tiles = GameObject.FindGameObjectsWithTag("Walls");
     
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().ColorSelf();
            }
        }

        tiles = GameObject.FindGameObjectsWithTag("LongWall");
  
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<GridTiles>().ColorSelf();
            }
        }

      
        tiles = GameObject.FindGameObjectsWithTag("Gap");
        material = Resources.Load<Material>("Gap");
        if (tiles != null)
        {
            foreach (GameObject t in tiles)
            {
                t.GetComponent<Renderer>().material = material;
            }
        }


    }


    [MenuItem("Tools/CreateTileNames")]
    public static void CreateTileNames()
    {

        GameObject map = GameObject.Find("NewMap");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //
            row.name = "og" + r;
            foreach (GridTiles tile in allTiles)
            {
                tile.name = "og" + f + "r" + r;
                f++;
            }
            r++;
        }


    }

    [MenuItem("Tools/CreatUIOverlay")]
    public static void CreateUIOverlay()
    {

        GameObject map = GameObject.Find("NewMap");
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

    [MenuItem("Tools/RemoveUIOverlay")]
    public static void RemoveUIOverlay()
    {

        GameObject map = GameObject.Find("NewMap");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //

            foreach (GridTiles tile in allTiles)
            {
                GameObject.DestroyImmediate(tile.GetComponentInChildren<UIExtention>().gameObject);

            }
            r++;
        }


    }

    [MenuItem("Tools/CreatEditOverlay")]
    public static void CreateEditOverlay()
    {

        GameObject map = GameObject.Find("AreaPrim");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //

            foreach (GridTiles tile in allTiles)
            {
                GameObject uiOveraly = GameObject.Instantiate(Resources.Load("SeethoughUI")) as GameObject;
                uiOveraly.transform.parent = tile.transform;
                uiOveraly.transform.localPosition = new Vector3(0, .9f, 16.5f);


            }
            r++;
        }


    }

    [MenuItem("Tools/RemoveEditOverlay")]
    public static void RemoveEditOverlay()
    {

        GameObject map = GameObject.Find("AreaPrim");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //

            foreach (GridTiles tile in allTiles)
            {
                GameObject.DestroyImmediate(tile.GetComponentInChildren<UIEditorExtention>().gameObject);

            }
            r++;
        }


    }

    [MenuItem("Tools/CraveOutTileSizes")]
    public static void CraveOutTileSizes()
    {

        GameObject map = GameObject.Find("Template36x40");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            int f = 0;
            int maxR = 35;
            int maxf = 39;
            if (r > maxR) GameObject.DestroyImmediate(GameObject.Find(row.name));
            else
            {
                GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
                foreach (GridTiles tile in allTiles)
                {
                    if (f > maxf) GameObject.DestroyImmediate(GameObject.Find(tile.name));
                    f++;
                }
                r++;
            }
        }


    }


    [MenuItem("Tools/GenerateNewMap")]
    public static void SetNewTile()
    {
        GameObject maps = GameObject.Find("Template36x40test");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        int i = 0;
        GameObject map = new GameObject();
        map.AddComponent<MapLocation>();
        map.AddComponent<PhaseSwitcher>();
        map.transform.position = new Vector3(34.22f, 0, -83.5f);
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


                if (tile.tag == "LavaR")
                {
                    if (tile.transform.localPosition.y > 0.9f)
                    {
                        GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverLine")) as GameObject;
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
                        tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
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
        }

    }
    [MenuItem("Tools/GenerateNewAreaMap")]
    public static void SetAreaTiles()
    {
        GameObject wholeMap = GameObject.Find("WholeMap 36x40");
        MapLocation[] Areas = wholeMap.GetComponentsInChildren<MapLocation>();
        GameObject newWholeMap = new GameObject();
        newWholeMap.transform.position = new Vector3(34.22f, 0, -83.5f);
        newWholeMap.name = "WholeMap";
        int u = 1;
        foreach (MapLocation maps in Areas)
        {

            Rows[] allRows = maps.gameObject.GetComponentsInChildren<Rows>();
            int i = 0;
            GameObject map = new GameObject();
            map.AddComponent<MapLocation>();
            //  map.AddComponent<PhaseSwitcher>();
            map.transform.parent = newWholeMap.transform;
            map.transform.localPosition = maps.transform.localPosition;
            map.name = "Area" + u;
            u++;
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


                    if (tile.tag == "LavaR")
                    {
                        if (tile.transform.localPosition.y > 0.9f)
                        {
                            GameObject tiles = GameObject.Instantiate(Resources.Load("LavaRiverLine")) as GameObject;
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
                            tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
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

                            tiles.GetComponent<GridTiles>().walkable = false;

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
            }

        }
    }


    [MenuItem("Tools/RecordNewAreaMap")]
    public static void RecordAreaMap()
    {
        GameObject wholeMap = GameObject.Find("WholeMap 36x40");
        TempGrouper[] areaGroups = wholeMap.GetComponentsInChildren<TempGrouper>();
       
      
        //int m = 0;
       // GameObject TheRecord = new GameObject();
      //  TheRecord.AddComponent<TempDisplayer>();
       // TheRecord.name = "I Remember";
        OverGrownLabyrinthTileSet tileset = new OverGrownLabyrinthTileSet();

        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        tileset.rout.allAreas.areaDirectors.Add(new AreaDirector());
        int k = 0;
        foreach (TempGrouper group in areaGroups)
        {
            MapLocation[] areas = group.GetComponentsInChildren<MapLocation>();
            int c = 0;
            int u = 1;
            foreach (MapLocation maps in areas)
            {
                int i = 0;
                Rows[] allRows = maps.gameObject.GetComponentsInChildren<Rows>();
                //"Area" + u;
                Debug.Log(k);
                
                tileset.rout.allAreas.areaDirectors[k].areas.Add(new AreaHolder());
                tileset.rout.allAreas.areaDirectors[k].areas[c].id = maps.GetComponent<AreaInfo>().tileType;
                Debug.Log(tileset.rout.allAreas.areaDirectors[k].areas[c].id);
                u++;
                foreach (Rows row in allRows)
                {
                    int j = 0;
                    //row new Vector3(0, 0, i);
                    tileset.rout.allAreas.areaDirectors[k].areas[c].rows.Add(new RowHolder(row.name));
                    GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
                    foreach (GridTiles tile in allTiles)
                    {
                        tileset.rout.allAreas.areaDirectors[k].areas[c].rows[i].tiles.Add(new TileHolder(tile.tag, tile.FindSpecialorTurnText(), tile.TileColor(), (int)tile.gameObject.transform.localPosition.y, tile.name));
                        //tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                        j++;
                    }
                    i++;
                }
                c++;
            }
            k++;
        }
       // TheRecord.GetComponent<TempDisplayer>().overGrownLabyrinth = tileset;
        TempDisplayer.overGrownLabyrinthPerm = tileset;
    }

    [MenuItem("Tools/RiptoMap")]
    public static void RiptoMapFromMemory()
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
        list = TempDisplayer.overGrownLabyrinthPerm.rout.allAreas.areaDirectors;
        do
        {
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
                    int num = Random.Range(0, list[i].areas.Count);
                    if (organizer.Checklist(list[i].areas[num].id))
                    {
                        organizer.resetAInRows = 0;
                        done = true;
                        foreach (RowHolder otherRow in list[i].areas[num].rows)
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

                    if (organizer.redo)
                    {
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
        //int m = 0;
       // GameObject TheRecord = new GameObject();
        
    }

    [MenuItem("Tools/ResetMap")]
    public static void ResetMap()
    {

      
        GameObject map = GameObject.Find("Template36x40test");
        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;
        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                tile.Clean();
            }
            r++;

        }

        //int m = 0;
        GameObject TheRecord = new GameObject();

    }

    [MenuItem("Tools/RenameMap")]
    public static void RenamePrefab()
    {
        GameObject wholeMap = GameObject.Find("WholeMap 36x40");
        TempGrouper[] areaGroups = wholeMap.GetComponentsInChildren<TempGrouper>();


        foreach (TempGrouper group in areaGroups)
        {
            MapLocation[] areas = group.GetComponentsInChildren<MapLocation>();

            foreach (MapLocation map in areas)
            {
                Rows[] allRows = map.GetComponentsInChildren<Rows>();
                int r = 0;
                int cd = 11;

                foreach (Rows row in allRows)
                {
                    int f = 0;
                    int cd2 = 7;
                    GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

                    //
                    if (map.transform.localScale.z == -1)
                    {
                        row.name = "!!" + (cd + group.rowMod);

                    }
                    else row.name = "!!" + (r + group.rowMod);
                    foreach (GridTiles tile in allTiles)
                    {
                        if (map.transform.localScale.z == -1 && map.transform.localScale.x == -1)
                        {
                            Debug.Log("w " + map.name);
                            tile.name = "!!" + (cd2 + group.tileMod) + "r" + (cd + group.rowMod);
                        }
                        else if (map.transform.localScale.x == -1)
                        {
                            //  Debug.Log("ww");
                            tile.name = "!!" + (cd2 + group.tileMod) + "r" + (r + group.rowMod);
                        }
                        else if (map.transform.localScale.z == -1)
                        {
                            //   Debug.Log("www");
                            tile.name = "!!" + (f + group.tileMod) + "r" + (cd + group.rowMod);
                        }
                        else tile.name = "!!" + (f + group.tileMod) + "r" + (r + group.rowMod);
                        f++;
                        cd2--;
                    }
                    r++;
                    cd--;
                }
            }
        }
    }
}
          

