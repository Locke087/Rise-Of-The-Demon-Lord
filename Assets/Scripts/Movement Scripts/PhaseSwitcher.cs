using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseSwitcher : MonoBehaviour
{
    public List<GridMovement> PlayerTeam = new List<GridMovement>();
    public List<GridMovement> EnemyTeam = new List<GridMovement>();


    public int phaseCountEnemy = 0;
    public int phaseCountPlayer = 0;
    public bool turnOnOff = false;
    public bool oneTime = false;
    public bool presentPlayer = false;
    public bool playerQueued = true;
    public bool playerPhase = true;
    public bool enemyPhase = false;
    public bool enemyMoving = false;
    public bool phaseSwitch = false;
    public bool startUp = false;

    int endEnemy = 0;
    int endPlayer = 0;
    int freezeCount = 0;
    int enemyMovedCount = 0;

    public int test1 = 0;
    public int test2 = 0;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame

    void FixedUpdate()
    {
        if (phaseSwitch == true && !enemyPhase && !playerPhase && !oneTime)
        {
            TurnOnOff();
            if (turnOnOff == true) StartCoroutine(TheEnemySwicther());
            else if ((turnOnOff == false)) StartCoroutine(ThePlayerSwicther());
        }

        if (playerPhase && !phaseSwitch) SearchPlayer();
        else if (enemyPhase && !phaseSwitch) enemyActivate();

    }

    IEnumerator ThePlayerSwicther()
    {
        oneTime = true;
        StartPlayerPhase();
        yield return new WaitUntil(() => endPlayer == PlayerTeam.Count);
        playerPhase = true;
        oneTime = false;
        endPlayer = 0;
    }

    IEnumerator TheEnemySwicther()
    {
        oneTime = true;
        StartEnemyPhase();
        yield return new WaitUntil(() => endEnemy == EnemyTeam.Count);
        enemyPhase = true;
        oneTime = false;
        endEnemy = 0;
    }

    void TurnOnOff()
    {
        if (turnOnOff == true) turnOnOff = false;
        else if (turnOnOff == false) turnOnOff = true;
    }

    public void StartPlayerPhase()
    {
        test2 += 10;
        if (PlayerTeam.Count > 0)
        {
            foreach (GridMovement unit in PlayerTeam)
            {
                unit.isPlayerPhase = true;
                endPlayer++;
                if (endPlayer >= PlayerTeam.Count) phaseSwitch = false;

            }
        }
    }


    public void StartEnemyPhase()
    {
        test1 += 10;
        if (EnemyTeam.Count > 0)
        {
            foreach (GridMovement unit in EnemyTeam)
            {
                unit.isEnemyPhase = true;
                endEnemy++;
                if (endEnemy == EnemyTeam.Count) phaseSwitch = false;

            }
        }

    }

    public void EndingPlayerPhase()
    {
        phaseCountPlayer++;
        phaseSwitch = true;
        playerPhase = false;
        enemyPhase = false;
        foreach (GridMovement unit in PlayerTeam)
        {
            unit.freeze = false;
            unit.isPlayerPhase = false;
            if (unit.GetComponent<MCMove>() != null) unit.GetComponent<MCMove>().moved = false;
            else if (unit.GetComponent<PlayerUnit>() != null) unit.GetComponent<PlayerUnit>().moved = false;

            if (unit.GetComponent<MCMove>() != null) unit.GetComponent<MCMove>().activePlayer = false;
            else if (unit.GetComponent<PlayerUnit>() != null) unit.GetComponent<PlayerUnit>().activePlayer = false;
        }
    }

    public void EndingEnemyPhase()
    {
        phaseCountEnemy++;
        phaseSwitch = true;
        enemyPhase = false;
        playerPhase = false;

        foreach (GridMovement unit in EnemyTeam)
        {
            unit.isEnemyPhase = false;
            unit.freeze = false;
            unit.enemyIsFinished = false;
            unit.enemyAccounted = false;
            unit.GetComponent<EnemyMove>().activeEnemy = false;
            unit.GetComponent<EnemyMove>().moved = false;
        }
    }

    public void AddPlayer(GridMovement unit)
    {
        PlayerTeam.Add(unit);
    }

    public void AddEnemy(GridMovement unit)
    {
        EnemyTeam.Add(unit);
    }


    //
    //Player Team Movement 
    //

    public void SearchPlayer()
    {
        if (PlayerTeam.Count > 0)
        {
            if (!phaseSwitch)
            {
                CheckIfPlayerIsActive();
                if (playerQueued == true) FreezeOtherPlayers();
                else if (playerQueued == false) UnFreezePlayers();

                foreach (GridMovement unit in PlayerTeam)
                {
                    if (unit.freeze == true) freezeCount++;
                }
                if (freezeCount == PlayerTeam.Count)
                {
                    phaseSwitch = true;
                    EndingPlayerPhase();
                }
                freezeCount = 0;
            }
        }
    }

    public void CheckIfPlayerIsActive()
    {
        foreach (GridMovement unit in PlayerTeam)
        {
            if (unit.GetComponent<MCMove>() != null)
            {
                if (unit.GetComponent<MCMove>().activePlayer == true)
                {
                    presentPlayer = true;
                    playerQueued = true;
                }
            }
            else if (unit.GetComponent<PlayerUnit>() != null)
            {
                if (unit.GetComponent<PlayerUnit>().activePlayer == true)
                {
                    presentPlayer = true;
                    playerQueued = true;
                }
            }
        }
        if (presentPlayer == false) playerQueued = false;
        else presentPlayer = false;
    }

    public void FreezeOtherPlayers()
    {
        foreach (GridMovement unit in PlayerTeam)
        {
            if (unit.GetComponent<MCMove>() != null)
            {
                if (unit.GetComponent<MCMove>().activePlayer == false) unit.freeze = true;
            }
            else if (unit.GetComponent<PlayerUnit>() != null)
                if (unit.GetComponent<PlayerUnit>().activePlayer == false) unit.freeze = true;
        }
    }

    public void UnFreezePlayers()
    {
        foreach (GridMovement unit in PlayerTeam)
        {
            if (unit.GetComponent<MCMove>() != null) unit.freeze = false;
            else if (unit.GetComponent<PlayerUnit>() != null) unit.freeze = false;

            if (unit.GetComponent<MCMove>() != null)
            {
                if (unit.GetComponent<MCMove>().moved == true) unit.freeze = true;
            }
            else if (unit.GetComponent<PlayerUnit>() != null)
                if (unit.GetComponent<PlayerUnit>().moved == true) unit.freeze = true;
        }
    }

    //
    //Enemy Team Movement 
    //

    public void enemyActivate()
    {
        if (EnemyTeam.Count > 0)
        {
            if (!enemyMoving && !phaseSwitch && enemyMovedCount != EnemyTeam.Count)
            {
                foreach (GridMovement unit in EnemyTeam)
                {
                    if (unit.GetComponent<EnemyMove>().activeEnemy == false)
                    {
                        if (!enemyMoving && unit.GetComponent<EnemyMove>().moved == false)
                        {
                            unit.GetComponent<EnemyMove>().activeEnemy = true;
                            enemyMoving = true;
                        }
                    }
                }

            }
            else if (!phaseSwitch)
            {
                foreach (GridMovement unit in EnemyTeam)
                {
                    if (unit.enemyIsFinished && !unit.enemyAccounted)
                    {
                        unit.GetComponent<EnemyMove>().activeEnemy = false;
                        enemyMoving = false;
                        unit.enemyAccounted = true;
                        unit.freeze = true;
                        unit.isEnemyPhase = false;
                    }
                    if (unit.enemyAccounted == true) enemyMovedCount++;
                }
                if (enemyMovedCount == EnemyTeam.Count)
                {
                    enemyPhase = false;
                    enemyMoving = false;
                    EndingEnemyPhase();
                }
                enemyMovedCount = 0;
            }

        }
    }


    public void BoardReset()
    {
        for (int i = 0; i < PlayerTeam.Count; i++)
        {
            if (PlayerTeam[i].GetComponent<UnitParty>() == null)
            {

                Destroy(PlayerTeam[i].gameObject);
                PlayerTeam[i] = null;
            }
        }
        for (int i = 0; i < EnemyTeam.Count; i++)
        {
            if (EnemyTeam[i].GetComponent<UnitParty>() == null)
            {
                Destroy(EnemyTeam[i].gameObject);
                EnemyTeam[i] = null;
            }
        }
        PlayerTeam.Clear();
        EnemyTeam.Clear();
        turnOnOff = false;
        oneTime = false;
        presentPlayer = false;
        playerQueued = false;
        playerPhase = true;
        enemyPhase = false;
        enemyMoving = false;
        phaseSwitch = false;
        startUp = false;
    }

}
