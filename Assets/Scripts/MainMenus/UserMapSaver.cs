using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserMapSaver : MonoBehaviour {

    // Use this for initialization
    public Button save;
    public Button exit;
    public Button overgrown;
    public Button frozen;
    public Button scorching;
    public Button growling;
    public Button areaMenu;
    public Button areaExit;
    public Button area1;
    public Button area2;
    public Button area3;
    public Button area4;
    public Button area5;
    public Button area6;
    public Button area7;
    public Button area8;
    public Button area9;
    public Button area10;
    public Button area11;
    public Button area12;
    public Button area13;
    public Button area14;
    public Button area15;
    public Button gap;
    public Button clean;
    public Button wall;
    public Button reward;
   
    public MiddleMapSave mapSave;
    public int areaNumber;
    public string mapName;
    public string tileType;
    public GameObject saveMenus;
    public GameObject pickArea;

	void Start () {
        //   overgrown.onClick.AddListener()

        save.onClick.AddListener(SaveMap);
        exit.onClick.AddListener(ReturnToTown);
        areaMenu.onClick.AddListener(AreaMenu);
        areaExit.onClick.AddListener(AreaExit);
        gap.onClick.AddListener(Gap);
        clean.onClick.AddListener(Clean);
        wall.onClick.AddListener(Wall);
        reward.onClick.AddListener(Reward);
        overgrown.onClick.AddListener(OverGrowth);
        frozen.onClick.AddListener(Frozen);
        scorching.onClick.AddListener(Scorching);
        growling.onClick.AddListener(Growling);
        area1.onClick.AddListener(Area1);
        area2.onClick.AddListener(Area2);
        area3.onClick.AddListener(Area3);
        area4.onClick.AddListener(Area4);
        area5.onClick.AddListener(Area5);
        area6.onClick.AddListener(Area6);
        area7.onClick.AddListener(Area7);
        area8.onClick.AddListener(Area8);
        area9.onClick.AddListener(Area9);
        area10.onClick.AddListener(Area10);
        area11.onClick.AddListener(Area11);
        area12.onClick.AddListener(Area12);
        area13.onClick.AddListener(Area13);
        area14.onClick.AddListener(Area14);
        area15.onClick.AddListener(Area15);
        saveMenus.SetActive(false);
        pickArea.SetActive(false);
        //  CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas.Add();
    }

    public void AreaMenu()
    {
        pickArea.SetActive(true);
    }

    public void AreaExit()
    {
        pickArea.SetActive(false);
    }

    public void CancelMenu()
    {
        saveMenus.SetActive(false);
    }
    // Update is called once per frame
    void SaveMap()
    {
        saveMenus.SetActive(true);
    }

    void Frozen()
    {
        mapName = "frozen";
        mapSave.AssignMap("ft", mapName);
    }

    void Scorching()
    {
        mapName = "scorching";
        mapSave.AssignMap("sw", mapName);
    }

    void Growling()
    {
        mapName = "growling";
        mapSave.AssignMap("gd", mapName);
    }

    void OverGrowth()
    {
        mapName = "overgrown";
        mapSave.AssignMap("og", mapName);
    }

  
   
    void renameMap()
    {

        GameObject wholeMap = GameObject.Find("AreaPrim");
        TempGrouper map = wholeMap.GetComponent<TempGrouper>();

        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;

        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
 
            row.name = "!!" + r;
            foreach (GridTiles tile in allTiles)
            {
                tile.name = "!!" + (f + map.tileMod) + "r" + (r + map.rowMod);
                f++;
            
            }
            r++;
        }


    }

    void renameMapAgain()
    {

        GameObject wholeMap = GameObject.Find("AreaPrim");
        TempGrouper map = wholeMap.GetComponent<TempGrouper>();

        Rows[] allRows = map.GetComponentsInChildren<Rows>();
        int r = 0;

        foreach (Rows row in allRows)
        {
            int f = 0;
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();

            //
            row.name = "!!" + r;
            foreach (GridTiles tile in allTiles)
            {

                tile.name = "!!" + (f + map.tileMod) + "r" + (r + map.rowMod);
                f++;
     
            }
            r++;
 
        }

    }


    public void OG()
    {
        renameMap();
        GameObject group = GameObject.Find("AreaPrim");
        TempGrouper maps = group.GetComponent<TempGrouper>();
        int c = CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].areas.Count;
        int i = 0;
        Rows[] allRows = maps.gameObject.GetComponentsInChildren<Rows>();
        //"Area" + u;

        CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].spawn = maps.GetComponent<AreaInfo>().spawnType;
        CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].areas.Add(new AreaHolder());
        CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].areas[c].id = maps.GetComponent<AreaInfo>().tileType;
        CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].areas[c].indent = maps.GetComponent<AreaInfo>().tileName;
        Debug.Log("DoTheThinhg");
        foreach (Rows row in allRows)
        {
            int j = 0;
            //row new Vector3(0, 0, i);
            CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].areas[c].rows.Add(new RowHolder(row.name));
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                CurrentGame.game.overGrown.rout.allAreas.areaDirectors[areaNumber].areas[c].rows[i].tiles.Add(new TileHolder(tile.tag, tile.FindSpecOrTT(maps.gameObject), tile.TileColor(), (int)tile.gameObject.transform.localPosition.y, tile.name, maps.GetComponent<AreaInfo>().spawnType));
                //tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                j++;
            }
            i++;
        }
        renameMapAgain();
    }

    void ReturnToTown()
    {
        SceneManager.LoadScene("Town");
    }

    public void GD()
    {
        renameMap();
        GameObject group = GameObject.Find("AreaPrim");
        TempGrouper maps = group.GetComponent<TempGrouper>();;
        int c = CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].areas.Count;
        int i = 0;
        Rows[] allRows = maps.gameObject.GetComponentsInChildren<Rows>();
        //"Area" + u;

        CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].spawn = maps.GetComponent<AreaInfo>().spawnType;
        CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].areas.Add(new AreaHolder());
        CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].areas[c].id = maps.GetComponent<AreaInfo>().tileType;
        CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].areas[c].indent = maps.GetComponent<AreaInfo>().tileName;
        Debug.Log("DoTheThinhg");
        foreach (Rows row in allRows)
        {
            int j = 0;
            //row new Vector3(0, 0, i);
            CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].areas[c].rows.Add(new RowHolder(row.name));
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                CurrentGame.game.growlingDeeps.rout.allAreas.areaDirectors[areaNumber].areas[c].rows[i].tiles.Add(new TileHolder(tile.tag, tile.FindSpecOrTT(maps.gameObject), tile.TileColor(), (int)tile.gameObject.transform.localPosition.y, tile.name, maps.GetComponent<AreaInfo>().spawnType));
                //tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                j++;
            }
            i++;
        }
        
        renameMapAgain();
    }

    public void FT()
    {
        renameMap();
        GameObject group = GameObject.Find("AreaPrim");
        TempGrouper maps = group.GetComponent<TempGrouper>();
        int c = CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas.Count;
        int i = 0;
        Rows[] allRows = maps.gameObject.GetComponentsInChildren<Rows>();
        //"Area" + u;

        CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].spawn = maps.GetComponent<AreaInfo>().spawnType;
        CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas.Add(new AreaHolder());
        CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas[c].id = maps.GetComponent<AreaInfo>().tileType;
        CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas[c].indent = maps.GetComponent<AreaInfo>().tileName;
        Debug.Log("DoTheThinhg");
        foreach (Rows row in allRows)
        {
            int j = 0;
            //row new Vector3(0, 0, i);
            CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas[c].rows.Add(new RowHolder(row.name));
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                CurrentGame.game.frozenTundra.rout.allAreas.areaDirectors[areaNumber].areas[c].rows[i].tiles.Add(new TileHolder(tile.tag, tile.FindSpecOrTT(maps.gameObject), tile.TileColor(), (int)tile.gameObject.transform.localPosition.y, tile.name, maps.GetComponent<AreaInfo>().spawnType));
                //tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                j++;
            }
            i++;
        }
        renameMapAgain();

    }

  
    public void SW()
    {
        renameMap();
        GameObject group = GameObject.Find("AreaPrim");
        TempGrouper maps = group.GetComponent<TempGrouper>();

        int c = CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].areas.Count;
        int i = 0;
        Rows[] allRows = maps.gameObject.GetComponentsInChildren<Rows>();
        //"Area" + u;

        CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].spawn = maps.GetComponent<AreaInfo>().spawnType;
        CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].areas.Add(new AreaHolder());
        CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].areas[c].id = maps.GetComponent<AreaInfo>().tileType;
        CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].areas[c].indent = maps.GetComponent<AreaInfo>().tileName;

        foreach (Rows row in allRows)
        {
            int j = 0;
            //row new Vector3(0, 0, i);
            CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].areas[c].rows.Add(new RowHolder(row.name));
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                CurrentGame.game.scorchingWastes.rout.allAreas.areaDirectors[areaNumber].areas[c].rows[i].tiles.Add(new TileHolder(tile.tag, tile.FindSpecOrTT(maps.gameObject), tile.TileColor(), (int)tile.gameObject.transform.localPosition.y, tile.name, maps.GetComponent<AreaInfo>().spawnType));
                //tiles.transform.localPosition = new Vector3(j, tile.transform.position.y, 0);
                j++;
            }
            i++;
        }
        renameMapAgain();

    }

    void Wall()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().tileType = "Wall";     
        maps.GetComponent<AreaInfo>().tileName = "map" + Random.Range(0, 100).ToString() + Random.Range(0, 100).ToString() + Time.realtimeSinceStartup + System.DateTime.UtcNow.ToLongDateString() + System.DateTime.UtcNow.ToLongTimeString();
        mapSave.AssignType(maps.GetComponent<AreaInfo>().tileType, maps.GetComponent<AreaInfo>().tileType);
    }

    void Clean()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().tileType = "Clean";      
        maps.GetComponent<AreaInfo>().tileName = "map" + Random.Range(0, 100).ToString() + Random.Range(0, 100).ToString() + Time.realtimeSinceStartup + System.DateTime.UtcNow.ToLongDateString() + System.DateTime.UtcNow.ToLongTimeString();
        mapSave.AssignType(maps.GetComponent<AreaInfo>().tileType, maps.GetComponent<AreaInfo>().tileType);
    }

    void Reward()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().tileType = "Reward"; 
        maps.GetComponent<AreaInfo>().tileName = "map" + Random.Range(0, 100).ToString() + Random.Range(0, 100).ToString() + Time.realtimeSinceStartup + System.DateTime.UtcNow.ToLongDateString() + System.DateTime.UtcNow.ToLongTimeString();
        mapSave.AssignType(maps.GetComponent<AreaInfo>().tileType, maps.GetComponent<AreaInfo>().tileType);
    }

    void Gap()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().tileType = "Gap"; 
        maps.GetComponent<AreaInfo>().tileName = "map" + Random.Range(0, 100).ToString() + Random.Range(0, 100).ToString() + Time.realtimeSinceStartup + System.DateTime.UtcNow.ToLongDateString() + System.DateTime.UtcNow.ToLongTimeString();
        mapSave.AssignType(maps.GetComponent<AreaInfo>().tileType, maps.GetComponent<AreaInfo>().tileType);
    }

   
    void Area1()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "PlayerSpawn";
        maps.GetComponent<TempGrouper>().rowMod = 0;
        maps.GetComponent<TempGrouper>().tileMod = 0;
        areaNumber = 0;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area2()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "PlayerSpawn";
        maps.GetComponent<TempGrouper>().rowMod = 0;
        maps.GetComponent<TempGrouper>().tileMod = 8;
        areaNumber = 1;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area3()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "PlayerSpawn";
        maps.GetComponent<TempGrouper>().rowMod = 0;
        maps.GetComponent<TempGrouper>().tileMod = 16;
        areaNumber = 2;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area4()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 0;
        maps.GetComponent<TempGrouper>().tileMod = 24;
        areaNumber = 3;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area5()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 0;
        maps.GetComponent<TempGrouper>().tileMod = 32;
        areaNumber = 4;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area6()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "PlayerSpawn";
        maps.GetComponent<TempGrouper>().rowMod = 12;
        maps.GetComponent<TempGrouper>().tileMod = 0;
        areaNumber = 5;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area7()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "PlayerSpawn";
        maps.GetComponent<TempGrouper>().rowMod = 12;
        maps.GetComponent<TempGrouper>().tileMod = 8;
        areaNumber = 6;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area8()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<TempGrouper>().rowMod = 12;
        maps.GetComponent<TempGrouper>().tileMod = 16;
        areaNumber = 7;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area9()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 12;
        maps.GetComponent<TempGrouper>().tileMod = 24;
        areaNumber = 8;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area10()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 12;
        maps.GetComponent<TempGrouper>().tileMod = 32;
        areaNumber = 9;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area11()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "PlayerSpawn";
        maps.GetComponent<TempGrouper>().rowMod = 24;
        maps.GetComponent<TempGrouper>().tileMod = 0;
        areaNumber = 10;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area12()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<TempGrouper>().rowMod = 24;
        maps.GetComponent<TempGrouper>().tileMod = 8;
        areaNumber = 11;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area13()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 24;
        maps.GetComponent<TempGrouper>().tileMod = 16;
        areaNumber = 12;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area14()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 24;
        maps.GetComponent<TempGrouper>().tileMod = 24;
        areaNumber = 13;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }

    void Area15()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        maps.GetComponent<AreaInfo>().spawnType = "EnemySpawn";
        maps.GetComponent<TempGrouper>().rowMod = 24;
        maps.GetComponent<TempGrouper>().tileMod = 32;
        areaNumber = 14;
        mapSave.AssignArea("area" + (areaNumber + 1).ToString(), "area" + (areaNumber + 1).ToString());
        saveMenus.SetActive(true);
        pickArea.SetActive(false);
    }
}
