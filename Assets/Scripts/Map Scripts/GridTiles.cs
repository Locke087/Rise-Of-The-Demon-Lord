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

    public bool highlighted = false;
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
 
    }

    public void TransferColor(string color)
    {
        Material material = Resources.Load<Material>(color);
        gameObject.GetComponent<Renderer>().material = material;
    }

    public void CheckWithText(string color)
    {
        if ("Street" == color) street = true;
        else if ("Dirt" == color) dirt = true;
        else if ("HouseTile" == color) houseTile = true;
        else if ("DungeonTile" == color) dungeonTile = true;
        else if ("ColoredHouseTile" == color) coloredHT = true;
        else if ("Cobblestone" == color) cobbleStone = true;
        else if ("Bridge" == color) brigde = true;
        else if ("Forest" == color) forest = true;
        else if ("Mountain" == color) mountain = true;
        else if ("StonePathway" == color) stonePathway = true;
        else if ("Vine" == color) vine = true;
        else if ("Grass" == color) grass = true;
        else if ("LavaGround" == color) lavaGround = true;
        else if ("Bricks" == color) brick = true;
        else if ("StoneWall" == color) stoneWall = true;
        else if ("GraniteWall" == color) graniteWall = true;
        else if ("OverGrownWall" == color) overGrownWall = true;
        else if ("Lava" == color) lava = true;
        else if ("Rivers" == color) water = true;
        else if ("Carpet" == color) carpet = true;
        else if ("Snow" == color) snow = true;
        else if ("SnowyWall" == color) snowyWall = true;
        else if ("SnowyRock" == color) snowyRock = true;
        else if ("SnowyMountain" == color) snowyMountain = true;
        else if ("Ice" == color) ice = true;
        else if ("Sand" == color) sand = true;
        else if ("SandyGrass" == color) sandyGrass = true;
        else if ("SandStone" == color) sandstone = true;
        else if ("SandStoneWall" == color) sandstoneWall = true;
        else if ("roughRoad" == color) roughRoad = true;
        else if ("Roof" == color) roof = true;
        else if ("MossyRock" == color) mossyRock = true;
        else if ("Limestone" == color) limestone = true;
        else if ("Quartz" == color) quartz = true;
        else if ("Obsidian" == color) obsidian = true;
        else if ("OtherCarpet" == color) otherCarpet = true;

        Material material = Resources.Load<Material>(color);
        gameObject.GetComponent<Renderer>().material = material;
     
    }

    public void UnCheckWithText(string type)
    {
        if ("Street" == type) street = false;
        else if ("Dirt" == type) dirt = false;
        else if ("HouseTile" == type) houseTile = false;
        else if ("DungeonTile" == type) dungeonTile = false;
        else if ("ColoredHouseTile" == type) coloredHT = false;
        else if ("Cobblestone" == type) cobbleStone = false;
        else if ("Bridge" == type) brigde = false;
        else if ("Forest" == type) forest = false;
        else if ("Mountain" == type) mountain = false;
        else if ("StonePathway" == type) stonePathway = false;
        else if ("Vine" == type) vine = false;
        else if ("Grass" == type) grass = false;
        else if ("LavaGround" == type) lavaGround = false;
        else if ("Bricks" == type) brick = false;
        else if ("StoneWall" == type) stoneWall = false;
        else if ("GraniteWall" == type) graniteWall = false;
        else if ("OverGrownWall" == type) overGrownWall = false;
        else if ("Lava" == type) lava = false;
        else if ("Rivers" == type) water = false;
        else if ("Carpet" == type) carpet = false;
        else if ("Snow" == type) snow = false;
        else if ("SnowyWall" == type) snowyWall = false;
        else if ("SnowyRock" == type) snowyRock = false;
        else if ("SnowyMountain" == type) snowyMountain = false;
        else if ("Ice" == type) ice = false;
        else if ("Sand" == type) sand = false;
        else if ("SandyGrass" == type) sandyGrass = false;
        else if ("SandStone" == type) sandstone = false;
        else if ("SandStoneWall" == type) sandstoneWall = false;
        else if ("roughRoad" == type) roughRoad = false;
        else if ("Roof" == type) roof = false;
        else if ("MossyRock" == type) mossyRock = false;
        else if ("Limestone" == type) limestone = false;
        else if ("Quartz" == type) quartz = false;
        else if ("Obsidian" == type) obsidian = false;
        else if ("OtherCarpet" == type) otherCarpet = false;
        else if ("N" == type) NEorN = false;
        else if ("E" == type) NWorE = false;
        else if ("S" == type) SEorS = false;
        else if ("W" == type) SWorW = false;
        else if ("NE" == type) NEorN = false;
        else if ("NW" == type) NWorE = false;
        else if ("SE" == type) SEorS = false;
        else if ("SW" == type) SWorW = false;
        else if ("Hazard" == type) hazard = false;

    }

    public void CheckSpecialorTurnText(string type)
    {
  
        if ("NEorN" == type) NEorN = true;
        else if ("NWorE" == type) NWorE = true;
        else if ("SEorS" == type) SEorS = true;
        else if ("SWorW" == type) SWorW = true;
        else if ("Hazard" == type) hazard = true;
    }

    public void Clean ()
    {
        street = false;
        dirt = false;
        houseTile = false;
        dungeonTile = false;
        coloredHT = false;
        cobbleStone = false;
        brigde = false;
        forest = false;
        mountain = false;
        stonePathway = false;
        vine = false;
        grass = false;
        lavaGround = false;
        brick = false;
        stoneWall = false;
        graniteWall = false;
        overGrownWall = false;
        lava = false;
        water = false;
        carpet = false;
        snow = false;
        snowyWall = false;
        snowyRock = false;
        snowyMountain = false;
        ice = false;
        sand = false;
        sandyGrass = false;
        sandstone = false;
        sandstoneWall = false;
        roughRoad = false;
        roof = false;
        mossyRock = false;
        limestone = false;
        quartz = false;
        obsidian = false;
        otherCarpet = false;
        NEorN = false;
        NWorE = false;
        SEorS = false;
        SWorW = false;
        hazard = false;
        highlighted = false;
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, 0, gameObject.transform.localPosition.z);
        Material material = Resources.Load<Material>("Tile");
        gameObject.GetComponent<Renderer>().material = material;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
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
