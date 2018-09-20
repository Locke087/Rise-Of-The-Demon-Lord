using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OGMapEventDriver : MonoBehaviour
{

    public string enemyGL = "";
    public string playerGL = "";
    public string eRows = "";
    public string eCollums = "";
    public string pRows = "";
    public string pCollums = "";
    public string newEnemyTag = "";
    public string newPlayerTag = "";
    MapLocation mapLocation;
    public string nametag;
    public List<int> playerQuadList;
    public List<int> enemyQuadList;
    MoveSwitch moveSwitch;
    MapEventDriver mapEventDriver;
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
    bool finished = false;

    // Use this for initialization
    void Start()
    {
        mapEventDriver = gameObject.GetComponent<MapEventDriver>();
        nametag = "og";
        playerQuadList = new List<int>();
        enemyQuadList = new List<int>();
        moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
        mapLocation = gameObject.GetComponent<MapLocation>();
        mapEventDriver.AssignFactors(nametag, mapLocation, moveSwitch);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (moveSwitch.gridOn && mapLocation.inMap && !finished)
        {
            GetCollumAndRow();
            if (finished) mapEventDriver.Ready(true);
        }
        else if (!moveSwitch.gridOn) finished = false;


    }


    void GetQuads()
    {
        //Quad Regions Four Corners
        // c 0 - 5 r 0 - 5 
        // c 6 - 11 r 6 - 11 
        // c 0 - 5 r 6 - 11 
        // c 6 - 11 r 0 - 5 


        int[] cStart = { 0, 12, 0, 12 };
        int[] cEnd = { 11, 23, 11, 23 };

        int[] rStart = { 0, 12, 12, 0 };
        int[] rEnd = { 11, 23, 23, 11 };

        for (int i = 0; i < cStart.Length; i++)
        {
            if (InRange(pcNum, cStart[i], cEnd[i]) && InRange(prNum, rStart[i], rEnd[i]))
            {
                Debug.Log("PlayerQuad Check");
                playerQuadList.Add(cStart[i]);
                playerQuadList.Add(cEnd[i]);
                playerQuadList.Add(rStart[i]);
                playerQuadList.Add(rEnd[i]);

            }
            //string hi = ecNum.ToString() + " " + cStart[i].ToString() + " " + cEnd[i].ToString() + " " + erNum.ToString() + " " + rStart[i].ToString() + " " + rEnd[i].ToString();
            //Debug.Log(hi);

            if (InRange(ecNum, cStart[i], cEnd[i]) && InRange(erNum, rStart[i], rEnd[i]))
            {
                enemyQuadList.Add(cStart[i]);
                enemyQuadList.Add(cEnd[i]);
                enemyQuadList.Add(rStart[i]);
                enemyQuadList.Add(rEnd[i]);
            }
        }


        mapEventDriver.AssignQuads(enemyQuadList, playerQuadList);
        finished = true;

    }


    bool InRange(int num, int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (num == i) return true;
        }

        return false;
    }


    void GetCollumAndRow()
    {
        EventDriver eventDriver = GameObject.FindObjectOfType<EventDriver>();
        Debug.Log(eventDriver.FindMap());
        if (eventDriver.FindMap() != null)
        {
            if (eventDriver.FindMap() == gameObject.GetComponent<MapLocation>())
            {
                GridTiles playerLocation = eventDriver.FindPlayerLocaton();
                GridTiles enemyLocation = eventDriver.FindPartyLocaton();

                if (enemyLocation == null || playerLocation == null) return;

                newEnemyTag = enemyLocation.gameObject.name;
                newPlayerTag = playerLocation.gameObject.name;

                enemyGL = "";
                int j = 0;
                for (int i = 2; i < newEnemyTag.Length; i++)
                {
                    enemyGL += newEnemyTag[i].ToString();
                    j++;
                }

                playerGL = "";
                j = 0;
                for (int i = 2; i < newPlayerTag.Length; i++)
                {
                    playerGL += newPlayerTag[i].ToString();
                    j++;
                }


                for (int i = 0; i < enemyGL.Length; i++)
                {
                    if (enemyGL[i].ToString() == "r")
                    {
                        rowEnemyStart = i + 1;
                        collumEnemyEnd = i - 1;
                    }
                }


                for (int i = 0; i < playerGL.Length; i++)
                {
                    if (playerGL[i].ToString() == "r")
                    {
                        rowPlayerStart = i + 1;
                        collumPlayerEnd = i - 1;
                    }
                }

                eCollums = "";
                Debug.Log(collumEnemyEnd);

                if (collumEnemyEnd > 0)
                {
                    j = 0;
                    for (int i = collumEnemyEnd; i >= 0; i--)
                    {
                        eCollums += enemyGL[j].ToString();
                        j++;
                    }
                }
                else eCollums = enemyGL[0].ToString();

                eRows = "";

                for (int i = rowEnemyStart; i < enemyGL.Length; i++)
                {
                    eRows += enemyGL[i].ToString();
                    j++;
                }

                pCollums = "";
                if (collumPlayerEnd > 0)
                {

                    int playerGLength = playerGL.Length;
                    j = 0;
                    for (int i = collumPlayerEnd; i >= 0; i--)
                    {
                        pCollums += playerGL[j].ToString();
                        j++;
                    }
                }
                else pCollums = playerGL[0].ToString();

                pRows = "";
                j = 0;
                for (int i = rowPlayerStart; i < playerGL.Length; i++)
                {
                    //if (i < 0 && i <= playerGL.Length)
                    pRows += playerGL[i].ToString();
                    j++;
                }


                pcNum = int.Parse(pCollums);
                prNum = int.Parse(pRows);
                ecNum = int.Parse(eCollums);
                erNum = int.Parse(eRows);

                //enemy collum,row then player collum,row
                mapEventDriver.AssignInts(ecNum, erNum, pcNum, prNum);

                GetQuads();
            }
        }
    }
}
