using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCenterTurns : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> allUnits;
    public List<GameObject> unitOrder;
    public int upNext = 0;
	void Start () {
        allUnits = new List<GameObject>();
        unitOrder = new List<GameObject>();
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Ordering()
    {
        allUnits.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        allUnits.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        GameObject highest;
        int highestNum = 0;
        int highestUnitIndex = 0;
        do
        {
            for (int i = 0; i < allUnits.Count; i++)
            {
                if (!allUnits[i].GetComponent<Stats>().skip)
                {
                    if (allUnits[i].GetComponent<Stats>().spd > highestNum)
                    {
                        highest = allUnits[i];
                        highestUnitIndex = i;
                        highestNum = allUnits[i].GetComponent<Stats>().spd;
                    }
                    else if (allUnits[i].GetComponent<Stats>().spd == highestNum && allUnits[i].tag == "Player")
                    {
                        highest = allUnits[i];
                        highestUnitIndex = i;
                        highestNum = allUnits[i].GetComponent<Stats>().spd;
                    }
                }
            }

            highestNum = 0;
            allUnits[highestUnitIndex].GetComponent<Stats>().skip = true;
            unitOrder.Add(allUnits[highestUnitIndex]);
        } while (allUnits.Count != unitOrder.Count); 
        
        foreach(GameObject unit in allUnits)
        {
            unit.GetComponent<Stats>().skip = false;
        }

        StartTurn();
        
    }

    public void StartTurn()
    {
        Debug.Log(unitOrder[upNext].name);
        if (unitOrder[upNext].tag == "Player")
        {
            Debug.Log("KILHBBBV");
            unitOrder[upNext].GetComponent<UnitSelect>().isTurn = true;
            StartCoroutine(unitOrder[upNext].GetComponent<UnitSelect>().Menu());

        }
        else if (unitOrder[upNext].tag == "Enemy")
        {
            StartCoroutine(unitOrder[upNext].GetComponent<MapEnemyMove>().GoTime());
        }
    }

    public void AdvanceTurn()
    {
        if (unitOrder[upNext].tag == "Player")
        {
            unitOrder[upNext].GetComponent<UnitSelect>().isTurn = false;
        }
        int check = upNext + 1;
        if (check < unitOrder.Count)
        {
            upNext++;
        }
        else upNext = 0;

        if (unitOrder[upNext].tag == "Player")
        {
            unitOrder[upNext].GetComponent<UnitSelect>().isTurn = true;
        }

        StartTurn();
    }


   
}
