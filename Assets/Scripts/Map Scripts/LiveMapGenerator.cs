using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveMapGenerator : MonoBehaviour {

    public int what = 0;

    public string enemyGL = "";
    public string playerGL = "";
    public string eRows = "";
    public string eCollums = "";
    public string pRows = "";
    public string pCollums = "";
    public string newEnemyTag = "";
    public string newPlayerTag = "";
    
    public string nametag;
    //public string newEnemyTag;
    //public string newPlayerTag;
    public int pcNum = 0;
    public int prNum = 0;
    public int ecNum = 0;
    public int erNum = 0;
    public int rowPlayerStart = 0;
    public int collumPlayerEnd = 0;
    public int rowEnemyStart = 0;
    public int collumEnemyEnd = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


   /*public void Remove(int area)
    {
        GameObject maps = GameObject.Find("AreaPrim");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        GameObject mapsin = GameObject.Find("Area" + area.ToString());
        Rows[] allRowsin = mapsin.GetComponentsInChildren<Rows>();
        int r = 0;
        int c = 0;
        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            GridTiles[] allTilesin = allRowsin[r].GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
              
                if (tile.GetComponentInChildren<UIEditorExtention>().taken && tile.GetComponentInChildren<UIEditorExtention>().removeMe)
                {
                    Debug.Log(c);
                    if (c < allTilesin.Length)
                    {
                        GameObject tiles = new GameObject();
                        tiles.transform.parent = allRowsin[r].transform;
                        tiles.AddComponent<GridTiles>();
                        tiles.name = "rr" + c + "r" + r;
                        tile.transform.localPosition = allTilesin[c].transform.localPosition;
                        Debug.Log(c + " get in here " + allTilesin[c].name);
                        tile.GetComponentInChildren<UIEditorExtention>().removeMe = false;
                        tile.GetComponentInChildren<UIEditorExtention>().taken = false;     
                        Destroy(allTilesin[c].gameObject);
                        allTilesin[c] = tiles.GetComponent<GridTiles>();
                    }
                }
                c++;
            }
            r++;
            c = 0;
        }

       

       

    }*/

    /*public void RemoveStandins(int area)
    {
        GameObject maps = GameObject.Find("Area" + area.ToString());
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
      
        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            foreach (GridTiles tile in allTiles)
            {
              
                string checking = "";
                char[] theName = tile.name.ToCharArray();
                for (int i = 0; i < theName.Length; i++)
                {
                    if ( i < 2)
                    {
                        checking += theName[i];
                    }
                }

                if (checking != "og") Destroy(tile);
            }
        }
    }*/

    public void Generate(int area)
    {
        Debug.Log("what are you doing?");
      
        GameObject maps = GameObject.Find("AreaPrim");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        GameObject map = new GameObject();
        int i = 0;
        if (GameObject.Find("Area" + area.ToString()) == null) {
          
            map.name = "Area" + area.ToString();
            map.transform.parent = GameObject.Find("Map Overlay").transform;
            map.transform.localPosition = new Vector3(-214.2468f, -269.6518f, -77.9f);
            map.AddComponent<MapLocation>();
        }
        else
        {
            Debug.Log("Log");
            GameObject.Destroy(map);
            map = GameObject.Find("Area" + area.ToString());
        }
       
        int r = 0;
        int f = 0;
        foreach (Rows row in allRows)
        {
            int j = 0;

            GameObject newRow = new GameObject();
           
            if (GameObject.Find("og" + r) == null)
            {
                newRow.transform.parent = map.transform;
                newRow.AddComponent<Rows>();
                newRow.transform.localPosition = new Vector3(0, 0, i);
                newRow.name = "og" + r;
            }
            else
            {
                Debug.Log("Log");
                GameObject.Destroy(newRow);
                Rows[] newRows = map.GetComponentsInChildren<Rows>();
                newRow = newRows[r].gameObject;              
            }

            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
              

                //Higher Ground Could Be by Checking the Y axis 1 for High Ground .5 for ramp

                if (tile.tag == "Rivers") { 
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

