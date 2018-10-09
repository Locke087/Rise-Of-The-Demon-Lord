using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLocation : MonoBehaviour
{

    public GameObject Map;

    public Vector3 offset;
    public PhaseSwitcher phaseSwitcher;
    public GameObject tactCamera;
    public MoveSwitch moveSwitch;
    public Rows[] allRows;
    public GridTiles[] allTiles;
    public bool inMap = false;
    public int rightPush;
    public int upPush;
    public int forwardPush;
    public int downPush;
    bool present;
    // Use this for initialization
    void Start()
    {
        Map = gameObject;
        moveSwitch = moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
        present = false;
        offset = (Vector3.right * rightPush) + (Vector3.up * upPush) + (Vector3.forward * forwardPush) + (Vector3.down * downPush);
        allRows = Map.GetComponentsInChildren<Rows>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        checkBoard();
        /*if (moveSwitch.gridOn == true && inMap == true)
        {
            tactCamera.transform.position = Map.transform.position + offset;
        }*/
        //else if (moveSwitch.gridOn == false) setDownBoard();
    }


    void checkBoard()
    {

        foreach (Rows row in allRows)
        {
            allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                if (tile.onTile == true)
                {
                    inMap = true;
                    present = true;
                }
            }
        }
        if (present == false) inMap = false;
        else present = false;
    }


    public void PausePlayers()
    {
        foreach (Rows row in allRows)
        {
            allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                if (tile.unit != null) tile.unit.GetComponent<GridMovement>().pause = true;
            }
        }
    }

    public void UnPausePlayers()
    {
        foreach (Rows row in allRows)
        {
            allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                if (tile.unit != null) tile.unit.GetComponent<GridMovement>().pause = false;
            }
        }
    }

    public void assignBoardPieces()
    {
        foreach (Rows row in allRows)
        {
            allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                if (tile.unit != null)
                {
                    if (tile.unit.GetComponent<MCMove>() != null)
                    {
                        tile.unit.GetComponent<MCMove>().Init();
                        phaseSwitcher.AddPlayer(tile.unit.GetComponent<GridMovement>());
                    }
                    else if (tile.unit.GetComponent<PlayerUnit>() != null)
                    {
                        tile.unit.GetComponent<PlayerUnit>().Init();
                        phaseSwitcher.AddPlayer(tile.unit.GetComponent<GridMovement>());
                    }
                    else if (tile.unit.GetComponent<EnemyMove>() != null)
                    {
                        tile.unit.GetComponent<EnemyMove>().Init();
                        phaseSwitcher.AddEnemy(tile.unit.GetComponent<GridMovement>());
                    }

                }
            }
        }
        setTurnsUp();
    }


    public void setTurnsUp()
    {
        if (!phaseSwitcher.startUp)
        {
            if (phaseSwitcher.playerPhase == false)
            {
                phaseSwitcher.playerPhase = true;
                phaseSwitcher.StartPlayerPhase();
                phaseSwitcher.startUp = true;
            }
        }
    }

    public void setDownBoard()
    {
        phaseSwitcher.BoardReset();
    }
}

