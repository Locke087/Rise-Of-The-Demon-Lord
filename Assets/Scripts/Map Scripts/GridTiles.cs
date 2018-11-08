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
    public bool playerSpawn = false;
    public bool enemySpawn = false;
    public bool bossSpawn = false;
    public bool reinforcementSpawn = false;
    public bool recuitSpawn = false;
    public bool objectivePoint = false;
    public bool taken = false;
    public TextureChartMaster chartMaster;

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
    public bool swamp = false;
    public bool street = false;
    public bool dirt = false;
    public bool coloredHT = false;
    public bool dungeonTile = false;
    public bool brick = false;
    public bool carpet = false;
    public bool lava = false;
    public bool water = false;
    public bool poison = false;
    public bool snow = false;
    public bool snowyWall = false;
    public bool snowyRock = false;
    public bool snowyMountain = false;
    public bool ice = false;
    public bool sand = false;
    public bool orangeRedRock = false;
    public bool darkRedRock = false;
    public bool redRock = false;
    public bool redRockWall = false;
    public bool moltenRock = false;
    public bool sandyGrass = false;
    public bool sandstone = false;
    public bool sandstoneWall = false;
    public bool rusty = false;
    public bool roughRoad = false;
    public bool roof = false;
    public bool mossyRock = false;
    public bool mossyPuddle = false;
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

    

    public void ChartMaker()
    {

        chartMaster.ogTexture.Add(new OGtextureChart("Street", "Street"));
        chartMaster.icTexture.Add(new ICtextureChart("Street", "Street"));
        chartMaster.flTexture.Add(new FLtextureChart("Street", "Street"));
        chartMaster.deTexture.Add(new DEtextureChart("Street", "Street"));

        chartMaster.ogTexture.Add(new OGtextureChart("Dirt", "Dirt"));
        chartMaster.icTexture.Add(new ICtextureChart("Dirt", "Dirt"));
        chartMaster.flTexture.Add(new FLtextureChart("Dirt", "Dirt"));
        chartMaster.deTexture.Add(new DEtextureChart("Dirt", "Dirt"));
     
        chartMaster.ogTexture.Add(new OGtextureChart("HouseTile", "HouseTile"));
        chartMaster.icTexture.Add(new ICtextureChart("HouseTile", "HouseTile"));
        chartMaster.flTexture.Add(new FLtextureChart("HouseTile", "HouseTile"));
        chartMaster.ogTexture.Add(new OGtextureChart("HouseTile", "HouseTile"));

        chartMaster.ogTexture.Add(new OGtextureChart("DungeonTile", "DungeonTile"));
        chartMaster.icTexture.Add(new ICtextureChart("DungeonTile", "DungeonTile"));
        chartMaster.flTexture.Add(new FLtextureChart("DungeonTile", "DungeonTile"));
        chartMaster.ogTexture.Add(new OGtextureChart("DungeonTile", "DungeonTile"));

        chartMaster.ogTexture.Add(new OGtextureChart("ColoredHouseTile", "ColoredHouseTile"));
        chartMaster.icTexture.Add(new ICtextureChart("ColoredHouseTile", "ColoredHouseTile"));
        chartMaster.flTexture.Add(new FLtextureChart("ColoredHouseTile", "ColoredHouseTile"));
        chartMaster.deTexture.Add(new DEtextureChart("ColoredHouseTile", "ColoredHouseTile"));

        chartMaster.ogTexture.Add(new OGtextureChart("Cobblestone", "Cobblestone"));
        chartMaster.icTexture.Add(new ICtextureChart("Cobblestone", "Cobblestone"));
        chartMaster.flTexture.Add(new FLtextureChart("Cobblestone", "Cobblestone"));
        chartMaster.deTexture.Add(new DEtextureChart("Cobblestone", "Cobblestone"));

        chartMaster.ogTexture.Add(new OGtextureChart("Bridge", "Bridge"));
        chartMaster.icTexture.Add(new ICtextureChart("Bridge", "Bridge"));
        chartMaster.flTexture.Add(new FLtextureChart("Bridge", "Bridge"));
         chartMaster.deTexture.Add(new DEtextureChart("Bridge", "Bridge"));

        chartMaster.ogTexture.Add(new OGtextureChart("Forest", "Forest"));
        chartMaster.icTexture.Add(new ICtextureChart("Forest", "Forest"));
        chartMaster.flTexture.Add(new FLtextureChart("Forest", "Forest"));
        chartMaster.deTexture.Add(new DEtextureChart("Forest", "Forest"));

        chartMaster.ogTexture.Add(new OGtextureChart("Mountain", "Mountain"));
        chartMaster.icTexture.Add(new ICtextureChart("Mountain", "Mountain"));
        chartMaster.flTexture.Add(new FLtextureChart("Mountain", "Mountain"));
        chartMaster.deTexture.Add(new DEtextureChart("Mountain", "Mountain"));

        chartMaster.ogTexture.Add(new OGtextureChart("StonePathway", "StonePathway"));
        chartMaster.icTexture.Add(new ICtextureChart("StonePathway", "StonePathway"));
        chartMaster.flTexture.Add(new FLtextureChart("StonePathway", "StonePathway"));
        chartMaster.deTexture.Add(new DEtextureChart("StonePathway", "StonePathway"));

        chartMaster.ogTexture.Add(new OGtextureChart("Vine", "Vine"));
        chartMaster.icTexture.Add(new ICtextureChart("Vine", "Vine"));
        chartMaster.flTexture.Add(new FLtextureChart("Vine", "Vine"));
        chartMaster.deTexture.Add(new DEtextureChart("Vine", "Vine"));

        chartMaster.ogTexture.Add(new OGtextureChart("Grass", "Grass"));
        chartMaster.icTexture.Add(new ICtextureChart("Grass", "Grass"));
        chartMaster.flTexture.Add(new FLtextureChart("Grass", "Grass"));
        chartMaster.deTexture.Add(new DEtextureChart("Grass", "Grass"));

        chartMaster.ogTexture.Add(new OGtextureChart("LavaGround", "LavaGround"));
        chartMaster.ogTexture.Add(new OGtextureChart("LavaGround", "LavaGround"));
        chartMaster.flTexture.Add(new FLtextureChart("LavaGround", "LavaGround"));
         chartMaster.deTexture.Add(new DEtextureChart("Grass", "Grass"));

        chartMaster.ogTexture.Add(new OGtextureChart("Bricks" , "Bricks" ));
        chartMaster.icTexture.Add(new ICtextureChart("Bricks", "Bricks"));
        chartMaster.flTexture.Add(new FLtextureChart("Bricks", "Bricks"));
         chartMaster.deTexture.Add(new DEtextureChart("Bricks", "Bricks"));

        chartMaster.ogTexture.Add(new OGtextureChart("StoneWall", "StoneWall"));
        chartMaster.icTexture.Add(new ICtextureChart("StoneWall", "StoneWall"));
        chartMaster.flTexture.Add(new FLtextureChart("StoneWall", "StoneWall"));
        chartMaster.deTexture.Add(new DEtextureChart("StoneWall", "StoneWall"));

        chartMaster.ogTexture.Add(new OGtextureChart("GraniteWall", "GraniteWall"));
        chartMaster.icTexture.Add(new ICtextureChart("GraniteWall", "GraniteWall"));
        chartMaster.flTexture.Add(new FLtextureChart("GraniteWall", "GraniteWall"));
        chartMaster.deTexture.Add(new DEtextureChart("GraniteWall", "GraniteWall"));


        chartMaster.ogTexture.Add(new OGtextureChart("Rivers", "Rivers"));
        chartMaster.icTexture.Add(new ICtextureChart("Rivers", "Rivers"));
        chartMaster.flTexture.Add(new FLtextureChart("Rivers", "Rivers"));
        chartMaster.deTexture.Add(new DEtextureChart("Rivers", "Rivers"));

        chartMaster.ogTexture.Add(new OGtextureChart("Carpet", "Carpet"));
        chartMaster.icTexture.Add(new ICtextureChart("Carpet", "Carpet"));
        chartMaster.flTexture.Add(new FLtextureChart("Carpet", "Carpet"));
        chartMaster.deTexture.Add(new DEtextureChart("Carpet", "Carpet"));

        chartMaster.ogTexture.Add(new OGtextureChart("Snow", "Snow"));
        chartMaster.icTexture.Add(new ICtextureChart("Snow", "Snow"));
        chartMaster.flTexture.Add(new FLtextureChart("Snow", "Snow"));
        chartMaster.deTexture.Add(new DEtextureChart("Snow", "Snow"));

        chartMaster.ogTexture.Add(new OGtextureChart("SnowyWall", "SnowyWall"));
        chartMaster.icTexture.Add(new ICtextureChart("SnowyWall", "SnowyWall"));
        chartMaster.flTexture.Add(new FLtextureChart("SnowyWall", "SnowyWall"));
        chartMaster.deTexture.Add(new DEtextureChart("SnowyWall", "SnowyWall"));

        chartMaster.ogTexture.Add(new OGtextureChart("SnowyRock", "SnowyRock"));
        chartMaster.icTexture.Add(new ICtextureChart("SnowyRock", "SnowyRock"));
        chartMaster.flTexture.Add(new FLtextureChart("SnowyRock", "SnowyRock"));
        chartMaster.deTexture.Add(new DEtextureChart("SnowyRock", "SnowyRock"));

        chartMaster.ogTexture.Add(new OGtextureChart("SnowyMountain", "SnowyMountain"));
        chartMaster.icTexture.Add(new ICtextureChart("SnowyMountain", "SnowyMountain"));
        chartMaster.flTexture.Add(new FLtextureChart("SnowyMountain", "SnowyMountain"));
        chartMaster.deTexture.Add(new DEtextureChart("SnowyMountain", "SnowyMountain"));

        chartMaster.ogTexture.Add(new OGtextureChart("Ice", "Ice"));
        chartMaster.icTexture.Add(new ICtextureChart("Ice", "Ice"));
        chartMaster.flTexture.Add(new FLtextureChart("Ice", "Ice"));
        chartMaster.deTexture.Add(new DEtextureChart("Ice", "Ice"));

        chartMaster.ogTexture.Add(new OGtextureChart("Sand", "Sand"));
        chartMaster.icTexture.Add(new ICtextureChart("Sand", "Sand"));
        chartMaster.flTexture.Add(new FLtextureChart("Sand", "Sand"));
        chartMaster.deTexture.Add(new DEtextureChart("Sand", "Sand"));

        chartMaster.ogTexture.Add(new OGtextureChart("SandyGrass", "SandyGrass"));
        chartMaster.icTexture.Add(new ICtextureChart("SandyGrass", "SandyGrass"));
        chartMaster.flTexture.Add(new FLtextureChart("SandyGrass", "SandyGrass"));
        chartMaster.deTexture.Add(new DEtextureChart("SandyGrass", "SandyGrass"));

        chartMaster.ogTexture.Add(new OGtextureChart("SandStone", "SandStone"));
        chartMaster.icTexture.Add(new ICtextureChart("SandStone", "SandStone"));
        chartMaster.flTexture.Add(new FLtextureChart("SandStone", "SandStone"));
        chartMaster.deTexture.Add(new DEtextureChart("SandStone", "SandStone"));

        chartMaster.ogTexture.Add(new OGtextureChart("SandStoneWall", "SandStoneWall"));
        chartMaster.icTexture.Add(new ICtextureChart("SandStoneWall", "SandStoneWall"));
        chartMaster.flTexture.Add(new FLtextureChart("SandStoneWall", "SandStoneWall"));
        chartMaster.deTexture.Add(new DEtextureChart("SandStoneWall", "SandStoneWall"));

        chartMaster.ogTexture.Add(new OGtextureChart("roughRoad", "roughRoad"));
        chartMaster.icTexture.Add(new ICtextureChart("roughRoad", "roughRoad"));
        chartMaster.flTexture.Add(new FLtextureChart("roughRoad", "roughRoad"));
        chartMaster.deTexture.Add(new DEtextureChart("roughRoad", "roughRoad"));

        chartMaster.ogTexture.Add(new OGtextureChart("Roof", "Roof"));
        chartMaster.icTexture.Add(new ICtextureChart("Roof", "Roof"));
        chartMaster.flTexture.Add(new FLtextureChart("Roof", "Roof"));
        chartMaster.deTexture.Add(new DEtextureChart("Roof", "Roof"));

        chartMaster.ogTexture.Add(new OGtextureChart("MossyRock", "MossyRock"));
        chartMaster.icTexture.Add(new ICtextureChart("MossyRock", "MossyRock"));
        chartMaster.flTexture.Add(new FLtextureChart("MossyRock", "MossyRock"));
        chartMaster.deTexture.Add(new DEtextureChart("MossyRock", "MossyRock"));

        chartMaster.ogTexture.Add(new OGtextureChart("Limestone", "Limestone"));
        chartMaster.icTexture.Add(new ICtextureChart("Limestone", "Limestone"));
        chartMaster.flTexture.Add(new FLtextureChart("Limestone", "Limestone"));
        chartMaster.deTexture.Add(new DEtextureChart("Limestone", "Limestone"));

        chartMaster.ogTexture.Add(new OGtextureChart("Quartz", "Quartz"));
        chartMaster.icTexture.Add(new ICtextureChart("Quartz", "Quartz"));
        chartMaster.flTexture.Add(new FLtextureChart("Quartz", "Quartz"));
        chartMaster.deTexture.Add(new DEtextureChart("Quartz", "Quartz"));

        chartMaster.ogTexture.Add(new OGtextureChart("Obsidian", "Obsidian"));
        chartMaster.icTexture.Add(new ICtextureChart("Obsidian", "Obsidian"));
        chartMaster.flTexture.Add(new FLtextureChart("Obsidian", "Obsidian"));
        chartMaster.deTexture.Add(new DEtextureChart("Obsidian", "Obsidian"));

        chartMaster.ogTexture.Add(new OGtextureChart("OtherCarpet", "OtherCarpet"));
        chartMaster.icTexture.Add(new ICtextureChart("OtherCarpet", "OtherCarpet"));
        chartMaster.flTexture.Add(new FLtextureChart("OtherCarpet", "OtherCarpet"));
        chartMaster.deTexture.Add(new DEtextureChart("OtherCarpet", "OtherCarpet"));

        chartMaster.ogTexture.Add(new OGtextureChart("PoisonWater", "PoisonWater"));
        chartMaster.icTexture.Add(new ICtextureChart("PoisonWater", "PoisonWater"));
        chartMaster.flTexture.Add(new FLtextureChart("PoisonWater", "PoisonWater"));
        chartMaster.deTexture.Add(new DEtextureChart("PoisonWater", "PoisonWater"));

        chartMaster.ogTexture.Add(new OGtextureChart("Swamp", "Swamp"));
        chartMaster.icTexture.Add(new ICtextureChart("Swamp", "Swamp"));
        chartMaster.flTexture.Add(new FLtextureChart("Swamp", "Swamp"));
        chartMaster.deTexture.Add(new DEtextureChart("Swamp", "Swamp"));

        chartMaster.ogTexture.Add(new OGtextureChart("RedRock", "RedRock"));
        chartMaster.icTexture.Add(new ICtextureChart("RedRock", "RedRock"));
        chartMaster.flTexture.Add(new FLtextureChart("RedRock", "RedRock"));
        chartMaster.deTexture.Add(new DEtextureChart("RedRock", "RedRock"));

        chartMaster.ogTexture.Add(new OGtextureChart("RedRockWall", "RedRockWall"));
        chartMaster.icTexture.Add(new ICtextureChart("RedRockWall", "RedRockWall"));
        chartMaster.flTexture.Add(new FLtextureChart("RedRockWall", "RedRockWall"));
        chartMaster.deTexture.Add(new DEtextureChart("RedRockWall", "RedRockWall"));

        chartMaster.ogTexture.Add(new OGtextureChart("DarkRockWall", "DarkRockWall"));
        chartMaster.icTexture.Add(new ICtextureChart("DarkRockWall", "DarkRockWall"));
        chartMaster.flTexture.Add(new FLtextureChart("DarkRockWall", "DarkRockWall"));
        chartMaster.deTexture.Add(new DEtextureChart("DarkRockWall", "DarkRockWall"));

        chartMaster.ogTexture.Add(new OGtextureChart("OrangeRedRock", "OrangeRedRock"));
        chartMaster.icTexture.Add(new ICtextureChart("OrangeRedRock", "OrangeRedRock"));
        chartMaster.flTexture.Add(new FLtextureChart("OrangeRedRock", "OrangeRedRock"));
        chartMaster.deTexture.Add(new DEtextureChart("OrangeRedRock", "OrangeRedRock"));

        chartMaster.ogTexture.Add(new OGtextureChart("MoltenRock", "MoltenRock"));
        chartMaster.icTexture.Add(new ICtextureChart("OrangeRedRock", "OrangeRedRock"));
        chartMaster.flTexture.Add(new FLtextureChart("OrangeRedRock", "OrangeRedRock"));
        chartMaster.deTexture.Add(new DEtextureChart("OrangeRedRock", "OrangeRedRock"));

        chartMaster.ogTexture.Add(new OGtextureChart("MossyPuddle", "MossyPuddle"));
        chartMaster.icTexture.Add(new ICtextureChart("MossyPuddle", "MossyPuddle"));
        chartMaster.flTexture.Add(new FLtextureChart("MossyPuddle", "MossyPuddle"));
        chartMaster.deTexture.Add(new DEtextureChart("MossyPuddle", "MossyPuddle"));

        chartMaster.ogTexture.Add(new OGtextureChart("Rusty", "Rusty"));
        chartMaster.icTexture.Add(new ICtextureChart("Rusty", "Rusty"));
        chartMaster.flTexture.Add(new FLtextureChart("Rusty", "Rusty"));
        chartMaster.deTexture.Add(new DEtextureChart("Rusty", "Rusty"));
          
        
    }

    public string ChartFindMat(string map)
    {
        if (map == "og")
        {
            foreach (OGtextureChart og in chartMaster.ogTexture)
            {
                if (TileColor() == og.input) return og.output;
            }
        }

        return "";
    }


    public void ChartCheckMat(string map, string check)
    {
        if (map == "og")
        {
            foreach (OGtextureChart og in chartMaster.ogTexture)
            {
                if (check == og.input) CheckWithText(og.output);
            }
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
        else if (poison) return name = "PoisonWater";
        else if (swamp) return name = "Swamp";
        else if (redRock) return name = "RedRock";
        else if (redRockWall) return name = "RedRockWall";
        else if (darkRedRock) return name = "DarkRockWall";
        else if (orangeRedRock) return name = "OrangeRedRock";
        else if (moltenRock) return name = "MoltenRock";
        else if (mossyPuddle) return name = "MossyPuddle";
        else if (rusty) return name = "Rusty";

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
        else if ("PoisonWater" == color) poison = true;
        else if ("Swamp" == color) swamp = true;
        else if ("RedRock" == color) redRock = true;
        else if ("RedRockWall" == color) redRockWall = true;
        else if ("DarkRockWall" == color) darkRedRock = true;
        else if ("OrangeRedRock" == color) orangeRedRock = true;
        else if ("MoltenRock" == color) moltenRock = true;
        else if ("MossyPuddle" == color) mossyPuddle = true;
        else if ("Rusty" == color) rusty = true;

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
        else if ("PoisonWater" == type) poison = false;
        else if ("Swamp" == type) swamp = false;
        else if ("RedRock" == type) redRock = false;
        else if ("RedRockWall" == type) redRockWall = false;
        else if ("DarkRockWall" == type) darkRedRock = false;
        else if ("OrangeRedRock" == type) orangeRedRock = false;
        else if ("MoltenRock" == type) moltenRock = false;
        else if ("MossyPuddle" == type) mossyPuddle = false;
        else if ("Rusty" == type) rusty = false;
        else if ("N" == type) NEorN = false;
        else if ("E" == type) NWorE = false;
        else if ("S" == type) SEorS = false;
        else if ("W" == type) SWorW = false;
        else if ("NE" == type) NEorN = false;
        else if ("NW" == type) NWorE = false;
        else if ("SE" == type) SEorS = false;
        else if ("SW" == type) SWorW = false;
        else if ("Hazard" == type) hazard = false;
        else if ("PlayerSpawn" == type) playerSpawn = false;
        else if ("EnemySpawn" == type) enemySpawn = false;
        else if ("ReinforcementSpawn" == type) reinforcementSpawn = false;
        else if ("BossSpawn" == type) bossSpawn = false;
        else if ("RecuitSpawn" == type) recuitSpawn = false;

    }

    public void CheckSpecialorTurnText(string type)
    {

        if ("NEorN" == type) NEorN = true;
        else if ("NWorE" == type) NWorE = true;
        else if ("SEorS" == type) SEorS = true;
        else if ("SWorW" == type) SWorW = true;

        else if ("Hazard" == type) hazard = true;
    }

    public void CheckSpawnType(string type)
    {
        if ("PlayerSpawn" == type) playerSpawn = true;
        else if ("EnemySpawn" == type) enemySpawn = true;
        else if ("ReinforcementSpawn" == type) reinforcementSpawn = true;
        else if ("BossSpawn" == type) bossSpawn = true;
        else if ("RecuitSpawn" == type) recuitSpawn = true;
    }

    public string FindSpawnType()
    {
        string type = "";
        if (playerSpawn == true) type = "PlayerSpawn";
        else if (enemySpawn == true) type = "EnemySpawn";
        else if (reinforcementSpawn == true) type = "ReinforcementSpawn";
        else if (bossSpawn == true) type = "BossSpawn";
        else if (recuitSpawn == true) type = "RecuitSpawn";

        return type;
    }


    public string FindSpecialorTurnText()
    {
        if (NEorN == true) return "NEorN";
        else if (NWorE == true) return "NWorE";
        else if (SEorS == true) return "SEorS";
        else if (SWorW == true) return "SWorW";
        else if (hazard == true) return "Hazard";
        return "";
    }


    public string FindSpecOrTT(GameObject map)
    {

        if (SEorS == true && map.transform.localScale.z == -1 && map.transform.localScale.x == -1 && IsACorner()) return "NWorE";
        else if (SWorW == true && map.transform.localScale.z == -1 && map.transform.localScale.x == -1) return "NEorN";
        else if (NEorN == true && map.transform.localScale.z == -1 && map.transform.localScale.x == -1 && IsACorner()) return "SWorW";
        else if (NWorE == true && map.transform.localScale.z == -1 && map.transform.localScale.x == -1) return "SEorS";

        else if (SEorS == true && map.transform.localScale.z == -1) return "NEorN";
        else if (SWorW == true && map.transform.localScale.z == -1) return "NWorE";
        else if (NEorN == true && map.transform.localScale.z == -1) return "SEorS";
        else if (NWorE == true && map.transform.localScale.z == -1) return "SWorW";

        else if (NEorN == true && map.transform.localScale.x == -1 && IsACorner()) return "NWorE";
        else if (NWorE == true && map.transform.localScale.x == -1) return "NEorN";
        else if (SEorS == true && map.transform.localScale.x == -1 && IsACorner()) return "SWorW";
        else if (SWorW == true && map.transform.localScale.x == -1) return "SEorS";

        else if (NEorN == true) return "NEorN";
        else if (NWorE == true) return "NWorE";
        else if (SEorS == true) return "SEorS";
        else if (SWorW == true) return "SWorW";
        else if (hazard == true) return "Hazard";
        return "";
    }



    public bool IsACorner()
    {
        if (gameObject.tag == "RiverC" || gameObject.tag == "LavaLC" || gameObject.tag == "LakeC")
        {
            return true;
        }
        return false;

    }

    public void ReflectMe(TileHolder tile)
    {
        gameObject.tag = tile.type;
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, tile.height, gameObject.transform.localPosition.z);
        CheckWithText(tile.material);
        CheckSpecialorTurnText(tile.turnOrSpecial);
        ColorSelf();
        TurnSelf();
        TagColor();
    }

    public void Clean()
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
        poison = false;
        swamp = false;
        redRock = false;
        redRockWall = false;
        darkRedRock = false;
        orangeRedRock = false;
        moltenRock = false;
        mossyPuddle = false;
        NEorN = false;
        NWorE = false;
        SEorS = false;
        SWorW = false;
        hazard = false;
        highlighted = false;
        playerSpawn = false;
        enemySpawn = false;
        recuitSpawn = false;
        reinforcementSpawn = false;
        bossSpawn = false;

        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, 0, gameObject.transform.localPosition.z);
        Material material = Resources.Load<Material>("Tile");
        gameObject.GetComponent<Renderer>().material = material;
        gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        gameObject.tag = "Tile";
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



    public void TagColor()
    {

        if (gameObject.tag == "RiverC" || gameObject.tag == "RiverH" || gameObject.tag == "Rivers" || gameObject.tag == "LakeC" || gameObject.tag == "LakeS" || gameObject.tag == "LakeM")
        {
            Material material = Resources.Load<Material>("Rivers");
            gameObject.GetComponent<Renderer>().material = material;
        }
        else if (gameObject.tag == "LavaLS" || gameObject.tag == "LavaLC" || gameObject.tag == "LavaLM" || gameObject.tag == "LavaR" || gameObject.tag == "LavaRC" || gameObject.tag == "LavaH")
        {
            Material material = Resources.Load<Material>("Lava");
            gameObject.GetComponent<Renderer>().material = material;
        }
        else if (gameObject.tag == "Gap")
        {
            Material material = Resources.Load<Material>("Gap");
            gameObject.GetComponent<Renderer>().material = material;
        }
        else if (gameObject.tag == "DoorC")
        {
            Material material = Resources.Load<Material>("Door");
            gameObject.GetComponent<Renderer>().material = material;
        }
        if (gameObject.tag == "ChestC")
        {
            Material material = Resources.Load<Material>("Treasure");
            gameObject.GetComponent<Renderer>().material = material;
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

   
    [System.Serializable]
    public class OGtextureChart
    {
        public string input;
        public string output;

        public OGtextureChart(string inp, string outp)
        {
            input = inp;
            output = outp;
        }


    }

    [System.Serializable]
    public class ICtextureChart
    {
        public string input;
        public string output;

        public ICtextureChart(string inp, string outp)
        {
            input = inp;
            output = outp;
        }


    }

    [System.Serializable]
    public class FLtextureChart
    {
        public string input;
        public string output;

        public FLtextureChart(string inp, string outp)
        {
            input = inp;
            output = outp;
        }

    }

    [System.Serializable]
    public class DEtextureChart
    {
        public string output;
        public string order;

        public DEtextureChart(string outp, string ord)
        {
            output = outp;
            order = ord;
        }

    }


    [System.Serializable]
    public class TextureChartMaster
    {
        public List<OGtextureChart> ogTexture;
        public List<ICtextureChart> icTexture;
        public List<DEtextureChart> deTexture;
        public List<FLtextureChart> flTexture;
        public TextureChartMaster()
        {
            ogTexture = new List<OGtextureChart>();
            icTexture = new List<ICtextureChart>();
            deTexture = new List<DEtextureChart>();
            flTexture = new List<FLtextureChart>();
            
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
