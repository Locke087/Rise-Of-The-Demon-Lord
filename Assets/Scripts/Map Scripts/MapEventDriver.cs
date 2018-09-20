using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEventDriver : MonoBehaviour
{

    public string tileNameTag = "none";
    public int playerCollum = 0;
    public int playerRow = 0;
    public int enemyCollum = 0;
    public int enemyRow = 0;
    public string leader = "";
    public string enemyLeader = "";
    public MapLocation mapLocation;
    public MCMove mcMove;
    public bool goodGo = false;
    public List<int> newPlayerQuadList;
    public List<int> newEnemyQuadList;
    public UnitParty enemyUnitParty;
    public UnitParty playerUnitParty;
    public MoveSwitch moveSwitch;
    // Use this for initialization
    void Start()
    {
        moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
        mapLocation = gameObject.GetComponent<MapLocation>();
        newPlayerQuadList = new List<int>();
        newEnemyQuadList = new List<int>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (moveSwitch.gridOn == true && mapLocation.inMap == true && goodGo == true)
        {
            StartCoroutine(mapPlacer());
        }
    }

    IEnumerator mapPlacer()
    {
        EventDriver eventDrivers = GameObject.FindObjectOfType<EventDriver>();
        enemyLeader = eventDrivers.FindParty();

        MCMove mcMove = GameObject.FindObjectOfType<MCMove>();
        enemyUnitParty = GameObject.Find(enemyLeader).gameObject.GetComponent<UnitParty>();
        playerUnitParty = mcMove.gameObject.GetComponent<UnitParty>();
        List<string> newEnemyLocations = CalcQuadEnemy();
        List<string> newPlayerLocations = CalcQuadPlayer();


        for (int j = 0; j < enemyUnitParty.enemyUnits.Count; j++)
        {

            Instantiate(enemyUnitParty.enemyUnits[j], GameObject.Find(newEnemyLocations[j]).transform.position + Vector3.up + Vector3.up, setQuaterRotation(0, 0, 0));
            enemyUnitParty.enemyUnits[j].GetComponent<Stats>().levelBoost = enemyUnitParty.levelUP;
        }

        for (int i = 0; i < playerUnitParty.friendlyUnits.Count; i++)
        {
            Instantiate(playerUnitParty.friendlyUnits[i], GameObject.Find(newPlayerLocations[i]).transform.position + Vector3.up + Vector3.up, setQuaterRotation(0, 0, 0));
        }
        goodGo = false;
        yield return new WaitUntil(() => playerUnitParty.friendlyUnits[0].activeInHierarchy == true);
        mapLocation.assignBoardPieces();
    }



    public List<string> CalcQuadEnemy()
    {
        //list[0] & [1] are start and end Collum, [2] & [3] are start and end Row
        int c = 0;
        int r = 0;
        bool used = false;
        bool valid = true;
        List<string> usedQuads = new List<string>();
        List<string> newLocations = new List<string>();
        leader = tileNameTag + "" + enemyCollum.ToString() + "r" + enemyRow.ToString();
        usedQuads.Add(leader);
        for (int i = 0; i < newEnemyQuadList.Count;)
        {
            c = Random.Range(newEnemyQuadList[0], newEnemyQuadList[1]);
            r = Random.Range(newEnemyQuadList[2], newEnemyQuadList[3]);
            for (int j = 0; j < usedQuads.Count; j++)
            {
                string validtile = tileNameTag + "" + c + "r" + r;
                if (usedQuads[j] == validtile) used = true;
                if (GameObject.Find(validtile) == null) valid = false;
                else if (!GameObject.Find(validtile).GetComponent<GridTiles>().walkable) valid = false;
                if (GameObject.Find(validtile) != null && GameObject.Find(usedQuads[j]) != null)
                {
                    float toClose = Vector3.Distance(GameObject.Find(validtile).GetComponent<GridTiles>().gameObject.transform.position, GameObject.Find(usedQuads[j]).GetComponent<GridTiles>().gameObject.transform.position);
                    if (toClose <= 1)
                    {
                        Debug.Log("tripped");
                        valid = false;
                    }

                }
            }

            if (!used && valid)
            {
                string validtile = tileNameTag + "" + c + "r" + r;
                usedQuads.Add(validtile);
                newLocations.Add(validtile);
                i++;
            }
            else
            {
                valid = true;
                used = false;
            }
        }


        return newLocations;
    }

    public List<string> CalcQuadPlayer()
    {
        //list[0] & [1] are start and end Collum, [2] & [3] are start and end Row
        int c = 0;
        int r = 0;
        bool used = false;
        bool valid = true;
        List<string> usedQuads = new List<string>();
        List<string> newLocations = new List<string>();
        string leader = tileNameTag + "" + playerCollum.ToString() + "r" + playerRow.ToString();
        usedQuads.Add(leader);
        for (int i = 0; i < newPlayerQuadList.Count;)
        {
            c = Random.Range(newPlayerQuadList[0], newPlayerQuadList[1]);
            r = Random.Range(newPlayerQuadList[2], newPlayerQuadList[3]);
            for (int j = 0; j < usedQuads.Count; j++)
            {

                string validtile = tileNameTag + "" + c + "r" + r;
                if (usedQuads[j] == validtile) used = true;
                if (GameObject.Find(validtile) == null) valid = false;
                else if (!GameObject.Find(validtile).GetComponent<GridTiles>().walkable) valid = false;
                if (GameObject.Find(validtile) != null && GameObject.Find(usedQuads[j]) != null)
                {
                    float toClose = Vector3.Distance(GameObject.Find(validtile).GetComponent<GridTiles>().gameObject.transform.position, GameObject.Find(usedQuads[j]).GetComponent<GridTiles>().gameObject.transform.position);
                    if (toClose <= 1)
                    {
                        Debug.Log("tripped");
                        valid = false;
                    }
                }
            }
            if (!used && valid)
            {
                string validtile = tileNameTag + "" + c + "r" + r;
                usedQuads.Add(validtile);
                newLocations.Add(validtile);
                i++;
            }
            else
            {
                valid = true;
                used = false;
            }



        }
        return newLocations;
    }

    private static Quaternion setQuaterRotation(float x, float y, float z)
    {
        Quaternion newQuaternion = new Quaternion();
        newQuaternion.Set(x, y, z, 1);
        return newQuaternion;
    }

    public void Ready(bool areWe)
    {
        goodGo = areWe;
    }


    public void AssignFactors(string tag, MapLocation map, MoveSwitch ms)
    {

        tileNameTag = tag;
        moveSwitch = ms;
        mapLocation = map;
    }

    public void AssignInts(int ec, int er, int pc, int pr)
    {
        playerCollum = pc;
        playerRow = pr;
        enemyCollum = ec;
        enemyRow = er;
    }

    public void AssignQuads(List<int> enemyList, List<int> playerList)
    {
        //list[0] & [1] are start and end Collum, [2] & [3] are start and end Row
        newPlayerQuadList = playerList;
        newEnemyQuadList = enemyList;
    }
}
