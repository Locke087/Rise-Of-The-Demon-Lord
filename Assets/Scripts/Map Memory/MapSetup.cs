using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSetup : MonoBehaviour {

    // Use this for initialization
    PlayerSpawnZone playerSpawnZone;
    EnemySpawnZone enemySpawnZone;

    public void SetUp()
    {
        playerSpawnZone = gameObject.GetComponent<PlayerSpawnZone>();
        enemySpawnZone = gameObject.GetComponent<EnemySpawnZone>();
        StartCoroutine(AssignUnits());     
        StartCoroutine(AssignTurns());
    }

    IEnumerator AssignTurns()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.GetComponent<SpeedCenterTurns>().Ordering();
    }

    IEnumerator AssignUnits()
    {
        Debug.Log("my Name Is Bob");
        playerSpawnZone.SpawnPlayers();
        yield return new WaitForSeconds(0.02f);
        enemySpawnZone.SpawnEnemies();
    }






}
