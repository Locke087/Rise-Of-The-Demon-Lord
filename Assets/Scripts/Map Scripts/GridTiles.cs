using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridTiles : MonoBehaviour {

    public bool walkable;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;
    public bool attack = false;
    public bool overTile = false;
    public bool hit = false;
    public bool onTile = false;
    public MapLocation mapLocation;
    public Rows rows;
    public PhaseSwitcher phaseSwitcher;


    public bool houseTile = false;
    public bool grass = false;
    public bool vine = false;
    public bool lavaGround = false;
    public bool forest = false;
    public bool brigde = false;
    public bool cobbleStone = false;
    public bool mountain = false;
    public bool overGrownWall = false;
    public bool stoneWall = false;
    public bool graniteWall = false;
    public bool stonePathway = false;
    public bool street = false;
    public bool dirt = false;
    public bool coloredHT = false;
    public bool dungeonTile = false;
    public bool brick = false;
    public bool carpet = false;
    public bool lava = false;
    public bool water = false;
    public bool snow = false;
    public bool snowyWall = false;
    public bool snowyRock = false;
    public bool snowyMountain = false;
    public bool ice = false;
    public bool sand = false;
    public bool sandyGrass = false;
    public bool sandstone = false;
    public bool sandstoneWall = false;
    public bool roughRoad = false;
    public bool roof = false;
    public bool mossyRock = false;
    public bool limestone = false;
    public bool quartz = false;
    public bool obsidian = false;
    public bool otherCarpet = false;

    public bool NEorN = false;
    public bool NWorE = false;
    public bool SEorS = false;
    public bool SWorW = false;

    public bool hazard = false;

    /// <summary>
    /// from a Iso view is the Z axis is North
    /// </summary>

    public List<GameObject> marked = new List<GameObject>();
    public int counter = 0;
    public List<GridTiles> adjacencyList = new List<GridTiles>();
    public List<GridTiles> attackList = new List<GridTiles>();

    //Needed BFS (breadth first search)
    public bool visited = false;
    public GridTiles parent = null;
    public int distance = 0;
    public GameObject unit = null;
    public Vector3 myRotate;
    public float myZ;
    //For A*
    public float f = 0;
    public float g = 0;
    public float h = 0;

    // Use this for initialization
    void Start()
    {
        myZ = gameObject.transform.position.z;
        rows = gameObject.GetComponentInParent<Rows>();
        mapLocation = rows.GetComponentInParent<MapLocation>();
        phaseSwitcher = mapLocation.GetComponent<PhaseSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {

        if (current)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.magenta;
        }
        else if (target)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.green;
        }
        else if (overTile)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.cyan;
        }
        else if (selectable)
        {
            if (gameObject.tag == "Ramp") selectable = false;
            else if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (attack)
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().material.color = Color.white;
        }

    }
  

    public string TileColor()
    {
        string name = "Tile";
        if (street) return name = "Street";
        else if (dirt) return name = "Dirt";
        else if (houseTile) return name = "HouseTile";
        else if (dungeonTile) return name = "DungeonTile";
        else if (coloredHT) return name = "ColoredHouseTile";
        else if (cobbleStone) return name = "Cobblestone";
        else if (brigde) return name = "Bridge";
        else if (forest) return name = "Forest";
        else if (mountain) return name = "Mountain";
        else if (stonePathway) return name = "StonePathway";
        else if (vine) return name = "Vine";
        else if (grass) return name = "Grass";
        else if (lavaGround) return name = "LavaGround";
        else if (brick) return name = "Bricks";
        else if (overGrownWall) return name = "OverGrownWall";
        else if (stoneWall) return name = "StoneWall";
        else if (graniteWall) return name = "GraniteWall";
        else if (water) return name = "Rivers";
        else if (lava) return name = "Lava";
        else if (carpet) return name = "Carpet";
        else if (snow) return name = "Snow";
        else if (snowyWall) return name = "SnowyWall";
        else if (snowyRock) return name = "SnowyRock";
        else if (snowyMountain) return name = "SnowyMountain";
        else if (ice) return name = "Ice";
        else if (sand) return name = "Sand";
        else if (sandyGrass) return name = "SandyGrass";
        else if (sandstone) return name = "SandStone";
        else if (sandstoneWall) return name = "SandStoneWall";
        else if (roughRoad) return name = "roughRoad";
        else if (roof) return name = "Roof";
        else if (mossyRock) return name = "MossyRock";
        else if (limestone) return name = "Limestone";
        else if (quartz) return name = "Quartz";
        else if (obsidian) return name = "Obsidian";
        else if (otherCarpet) return name = "OtherCarpet";

        return name;
   /* 
   snow
   snowyWall 
   snowyRock 
   snowyMountain
   ice 
   sand 
   sandyGrass 
   sandstone 
   sandstoneWal
   roughRoad
   roof 
   mossyRock
   limestone
   quartz
   obsidian
   otherCarpet */
    }

    public void SearchColor(string color)
    {
        string name = "Tile";
        if ("Street" == color) name = "Street";
        else if ("Dirt" == color) name = "Dirt";
        else if ("HouseTile" == color) name = "HouseTile";
        else if ("DungeonTile" == color) name = "DungeonTile";
        else if ("ColoredHouseTile" == color) name = "ColoredHouseTile";
        else if ("Cobblestone" == color) name = "Cobblestone";
        else if ("Bridge" == color) name = "Bridge";
        else if ("Forest" == color) name = "Forest";
        else if ("Mountain" == color) name = "Mountain";
        else if ("StonePathway" == color) name = "StonePathway";
        else if ("Vine" == color) name = "Vine";
        else if ("Grass" == color) name = "Grass";
        else if ("LavaGround" == color) name = "LavaGround";
        else if ("Bricks" == color) name = "Bricks";
        else if ("StoneWall" == color) name = "StoneWall";
        else if ("GraniteWall" == color) name = "GraniteWall";
        else if ("OverGrownWall" == color) name = "OverGrownWall";
        else if ("Lava" == color) name = "Lava";
        else if ("Rivers" == color) name = "Rivers";
        else if ("Carpet" == color) name = "Carpet";
        else if ("Snow" == color) name = "Snow";
        else if ("SnowyWall" == color) name = "SnowWall";
        else if ("SnowyRock" == color) name = "SnowRock";
        else if ("SnowyMountain" == color) name = "SnowMountain";
        else if ("Ice" == color) name = "Ice";
        else if ("Sand" == color) name = "Sand";
        else if ("SandyGrass" == color) name = "SandyGrass";
        else if ("SandStone" == color) name = "SandStone";
        else if ("SandStoneWall" == color) name = "SandStoneWall";
        else if ("roughRoad" == color) name = "roughRoad";
        else if ("Roof" == color) name = "Roof";
        else if ("MossyRock" == color) name = "MossyRock";
        else if ("Limestone" == color) name = "Limestone";
        else if ("Quartz" == color) name = "Quartz";
        else if ("Obsidian" == color) name = "Obsidian";
        else if ("OtherCarpet" == color) name = "OtherCarpet";

        Material material = Resources.Load<Material>(name);
        gameObject.GetComponent<Renderer>().material = material;
    }

    public void TurnSelf()
    {
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);

        if (gameObject.tag == "RampE")
        {
            if (NEorN) gameObject.transform.localRotation = Quaternion.Euler(0, -90f, 0);
            else if (NWorE) gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
            else if (SEorS) gameObject.transform.localRotation = Quaternion.Euler(0, 90f, 0);
            else if (SWorW) gameObject.transform.localRotation = Quaternion.Euler(0, 180f, 0);
        }
        else if (gameObject.tag == "RiverC" || gameObject.tag == "LavaLC" || gameObject.tag == "LakeC")
        {
            if (NEorN) gameObject.transform.localRotation = Quaternion.Euler(0, 180f, 0);
            else if (NWorE) gameObject.transform.localRotation = Quaternion.Euler(0, 90f, 0);
            else if (SEorS) gameObject.transform.localRotation = Quaternion.Euler(0, -90f, 0);
            else if (SWorW) gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (gameObject.tag == "LakeS" || gameObject.tag == "LavaLS")
        {
            if (NEorN) gameObject.transform.localRotation = Quaternion.Euler(0, 90f, 0);
            else if (NWorE) gameObject.transform.localRotation = Quaternion.Euler(0, 180f, 0);
            else if (SEorS) gameObject.transform.localRotation = Quaternion.Euler(0, -90f, 0);
            else if (SWorW) gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (gameObject.tag == "DoorC")
        {
            if (NEorN) gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
            else if (NWorE) gameObject.transform.localRotation = Quaternion.Euler(0, 90f, 0);
            else if (SEorS) gameObject.transform.localRotation = Quaternion.Euler(0, 180f, 0);
            else if (SWorW) gameObject.transform.localRotation = Quaternion.Euler(0, -90f, 0);
        }
        if (gameObject.tag == "ChestC")
        {
            if (NEorN) gameObject.transform.localRotation = Quaternion.Euler(0, -90f, 0);
            else if (NWorE) gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
            else if (SEorS) gameObject.transform.localRotation = Quaternion.Euler(0, 90f, 0);
            else if (SWorW) gameObject.transform.localRotation = Quaternion.Euler(0, 180f, 0);
        }
       

    }
    public void ColorSelf()
    {
        Material material = Resources.Load<Material>(TileColor());
        gameObject.GetComponent<Renderer>().material = material;
    }

    public void Reset()
    {
        attackList.Clear();
        adjacencyList.Clear();

        current = false;
        target = false;
        selectable = false;
        attack = false;

        visited = false;
        parent = null;
        distance = 0;

        f = g = h = 0;
        counter = 0;

    }

    public void FindNeighbors(float jumpHeight, GridTiles target)
    {
        Reset();

        CheckTile(Vector3.forward, jumpHeight, target);
        CheckTile(-Vector3.forward, jumpHeight, target);
        CheckTile(Vector3.right, jumpHeight, target);
        CheckTile(-Vector3.right, jumpHeight, target);
    }

   
    public void SendInfo()
    {
        Debug.Log("hi");
        Debug.Log(gameObject.name);
        if (selectable)
        {
            MapManager manager = GameObject.FindObjectOfType<MapManager>();
            manager.PlayerMove(gameObject);
        }
        else if (attack)
        {
            MapManager manager = GameObject.FindObjectOfType<MapManager>();
            manager.PlayerAttack(gameObject, unit);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MCMove>() != null)
            onTile = true;
        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<MCMove>() != null)
            onTile = false;

        unit = null;
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponent<MCMove>() != null)
        {

            unit = collision.gameObject;
            Rows[] allRows;
            allRows = mapLocation.GetComponentsInChildren<Rows>();
            int i = 0;
            foreach (Rows row in allRows)
            {
                GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
                foreach (GridTiles tile in allTiles)
                {
                    if (tile.unit != null)
                        if (tile.unit.GetComponent<MCMove>() != null)
                        {
                            i++;
                            if (i > 1) tile.unit = null;
                        }
                }
            }
            i = 0;
        }
        else unit = collision.gameObject;
    }




    public void CheckTile(Vector3 direction, float jumpHeight, GridTiles target)
    {
        Vector3 halfExtents = new Vector3(0.25f, jumpHeight);
        if (gameObject.tag == "Ramp")
        {
            halfExtents = new Vector3(0.25f, jumpHeight);
        }
        Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtents);
        foreach (Collider item in colliders)
        {
            GridTiles tile = null;

            if (item.GetComponent<GridTiles>() != null)
            {
               tile = item.GetComponent<GridTiles>();
            }
            else
            {
               tile = item.GetComponentInParent<GridTiles>();
            }

            if (tile != null && tile.walkable && tile.name[0] + tile.name[1] == gameObject.name[0] + gameObject.name[1])
            {
                RaycastHit hit;
                if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3) || (tile == target))
                {
                    if (gameObject.transform.position.y == tile.transform.position.y)
                    {
                        adjacencyList.Add(tile);
                        attackList.Add(tile);
                    }
                    else if (gameObject.tag == "Ramp")
                    {
                        if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                        {

                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }

                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            //Debug.Log("Im Here");
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            // Debug.Log("Im Here");
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                    }
                    else if (tile.tag == "Ramp")
                    {

                        if (tile.transform.localRotation.eulerAngles.y == 0f || tile.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 90f) // A
                        {
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                adjacencyList.Add(tile);
                                attackList.Add(tile);
                            }
                        }
                    }

                }//Attacks
                else if (Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3))
                {

                    if (gameObject.transform.position.y == tile.transform.position.y)
                    {
                        attackList.Add(tile);
                    }
                    else if (gameObject.tag == "Ramp")
                    {
                        if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                        {

                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }

                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            //Debug.Log("Im Here");
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {;
                                attackList.Add(tile);
                            }
                        }
                        else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            // Debug.Log("Im Here");
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }
                        }
                    }
                    else if (tile.tag == "Ramp")
                    {

                        if (tile.transform.localRotation.eulerAngles.y == 0f || tile.transform.localRotation.eulerAngles.y == 360f)// <--
                        {
                            if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 90f) // A
                        {
                            if (gameObject.transform.position.z > tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 180f) //-->
                        {
                            if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                            {
                                attackList.Add(tile);
                            }
                        }
                        else if (tile.transform.localRotation.eulerAngles.y == 270f) //V
                        {
                            if (gameObject.transform.position.z < tile.transform.position.z)
                            {
                                attackList.Add(tile);
                            }
                        }
                    }

                }

            }
        }
    }
}


         /* if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3) || (tile == target))
            {


            }//Attacks
            else if (Physics.Raycast(tile.transform.position, Vector3.up, out hit, 3))
            {

                if (gameObject.transform.position.y == tile.transform.position.y)
                {
                    if (phaseSwitcher.playerPhase)
                    {
                        if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                    }
                    else if (phaseSwitcher.enemyPhase)
                    {
                        if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                        else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                    }
                }
                else if (gameObject.tag == "Ramp")
                {
                    if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                    {
                        if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }


                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                    {
                        if (gameObject.transform.position.z < tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                    {
                        if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        };
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                    {
                        if (gameObject.transform.position.z > tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                }
                else if (tile.tag == "Ramp")
                {
                    if (gameObject.transform.localRotation.eulerAngles.y == 0f || gameObject.transform.localRotation.eulerAngles.y == 360f)// <--
                    {
                        if (gameObject.transform.localPosition.x < tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 90f) // A
                    {
                        if (gameObject.transform.position.z > tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 180f) //-->
                    {
                        if (gameObject.transform.localPosition.x > tile.transform.localPosition.x)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                    else if (gameObject.transform.localRotation.eulerAngles.y == 270f) //V
                    {
                        if (gameObject.transform.position.z < tile.transform.position.z)
                        {
                            if (phaseSwitcher.playerPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<EnemyMove>() != null) attackList.Add(tile);
                            }
                            else if (phaseSwitcher.enemyPhase)
                            {
                                if (hit.collider.gameObject.GetComponent<MCMove>() != null) attackList.Add(tile);
                                else if (hit.collider.gameObject.GetComponent<PlayerUnit>() != null) attackList.Add(tile);
                            }
                        }
                    }
                }

            }*/
