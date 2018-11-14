using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedCenterTurns : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> allUnits;
    public List<GameObject> unitOrder;
    public List<GameObject> playerUnits;
    public List<GameObject> enemyUnits;
    public GameObject cam;
    public int upNext = 0;
    public bool enemyRouted = false;
    public bool stopped = false;
    public GameObject activeUnit;
    public GameObject nextUnit;
	void Start () {
        allUnits = new List<GameObject>();
        unitOrder = new List<GameObject>();
        playerUnits = new List<GameObject>();
        enemyUnits = new List<GameObject>();
	}
	
	
   /* public void UpdateList()
    {
        allUnits.Clear();
        playerUnits.Clear();
        enemyUnits.Clear();
        upNext = 0;
        if (GameObject.FindGameObjectsWithTag("Player") != null)
        {

            allUnits.AddRange(GameObject.FindGameObjectsWithTag("Player"));
            playerUnits.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        }
        else
        {
            stopped = true;
            FindObjectOfType<GameOver>().GameEnd();

        }

        if (GameObject.FindGameObjectsWithTag("Enemy") != null)
        {
            allUnits.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
            enemyUnits.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        }
        else
        {
            if (GameObject.FindObjectOfType<Rout>() != null) GameObject.FindObjectOfType<Rout>().Win();
        }

        if (!stopped)
        {
            GameObject highest;
            int highestNum = 0;
            int highestUnitIndex = 0;
            bool fail = false;
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
                            allUnits[i].GetComponent<ChoosenAlready>().picked = true;

                        }                   
                        else if (allUnits[i].GetComponent<Stats>().spd == highestNum)
                        {
                            highest = allUnits[i];
                            highestUnitIndex = i;
                            highestNum = allUnits[i].GetComponent<Stats>().spd;
                            allUnits[i].GetComponent<ChoosenAlready>().picked = true;
                        }
                    }
                }

                highestNum = 0;
                allUnits[highestUnitIndex].GetComponent<Stats>().skip = true;
                unitOrder.Add(allUnits[highestUnitIndex]);
            } while (allUnits.Count != unitOrder.Count);

            foreach (GameObject unit in allUnits)
            {
                unit.GetComponent<Stats>().skip = false;
            }

            ResumeTurns();
        }
    }

    void ResumeTurns()
    {
      /* if (activeUnit != null)
       {
            do
            {
                upNext++;
            } while (activeUnit != unitOrder[upNext]);
       }
       else if (nextUnit != null)
       {
            do
            {
                upNext++;
            } while (nextUnit != unitOrder[upNext]);
            StartTurn();
       }
        else
        {
            upNext = 0;
            StartTurn();
        }
         upNext = 0;
         StartTurn();
    }*/



    public void Ordering()
    {

        allUnits.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        playerUnits.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        allUnits.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        enemyUnits.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
        
        GameObject highest;
        int highestNum = 0;
        int highestUnitIndex = 0;
        bool gotone = false;
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
                        gotone = true;
                    }
                    
                }
            }
            if (!gotone)
            {
                for (int i = 0; i < allUnits.Count; i++)
                {
                    if (!allUnits[i].GetComponent<Stats>().skip)
                    {
                        if (allUnits[i].GetComponent<Stats>().spd == highestNum)
                        {
                            highest = allUnits[i];
                            highestUnitIndex = i;
                            highestNum = allUnits[i].GetComponent<Stats>().spd;
                        }
                    }

                }
              
            }
            gotone = false;
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
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            Debug.Log("You Lose");
            GameObject.FindObjectOfType<GameOver>().GameEnd();
        }

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Debug.Log("You Win");
            if (GameObject.FindObjectOfType<Rout>() != null) GameObject.FindObjectOfType<Rout>().Win();
        }
       
        if (!stopped)
        {
            unitOrder[upNext].gameObject.GetComponent<Renderer>().material.color = Color.green;
            cam.transform.position = new Vector3(unitOrder[upNext].transform.position.x, cam.transform.position.y, unitOrder[upNext].transform.position.z);
            activeUnit = unitOrder[upNext];
            int temp = upNext;
            Debug.Log(unitOrder[upNext].name);
            if (unitOrder[upNext].tag == "Player")
            {
                GameObject.Find("TheTurnOf").GetComponent<Text>().text = unitOrder[upNext].name;
                if (temp + 1 >= unitOrder.Count)
                {
                    GameObject.Find("UpNext").GetComponent<Text>().text = unitOrder[0].name;
                    nextUnit = unitOrder[0];
                }
                else
                {
                    int temp1 = upNext;
                    GameObject.Find("UpNext").GetComponent<Text>().text = unitOrder[temp1 + 1].name;
                    nextUnit = unitOrder[temp1 + 1];
                }
                unitOrder[upNext].GetComponent<UnitSelect>().isTurn = true;
                StartCoroutine(unitOrder[upNext].GetComponent<UnitSelect>().Menu());

            }
            else if (unitOrder[upNext].tag == "Enemy")
            {
                GameObject.Find("TheTurnOf").GetComponent<Text>().text = unitOrder[upNext].name;
                if (temp + 1 >= unitOrder.Count)
                {
                    GameObject.Find("UpNext").GetComponent<Text>().text = unitOrder[0].name;
                    nextUnit = unitOrder[0];
                }
                else
                {
                    int temp1 = upNext;
                    GameObject.Find("UpNext").GetComponent<Text>().text = unitOrder[temp1 + 1].name;
                    nextUnit = unitOrder[0];
                }
                StartCoroutine(unitOrder[upNext].GetComponent<MapEnemyMove>().GoTime());
            }
        }
        StartCoroutine(ClearUp());
    }
    public IEnumerator ClearUp()
    {
        yield return new WaitForSeconds(2f);
        GameObject.FindObjectOfType<Stats>().CleanTextBoxs();
    }
    public void AdvanceTurn()
    {
      

        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            Debug.Log("You Lose");
            GameObject.FindObjectOfType<GameOver>().GameEnd();
        }

        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            Debug.Log("You Win");
            if (GameObject.FindObjectOfType<Rout>() != null) GameObject.FindObjectOfType<Rout>().Win();
        }

        if (!stopped)
        {
            cam.transform.position = new Vector3(cam.GetComponent<CameraMover>().startX, cam.transform.position.y, cam.GetComponent<CameraMover>().startZ);

            if (unitOrder[upNext].tag == "Player")
            {
                unitOrder[upNext].gameObject.GetComponent<Renderer>().material.color = Color.blue;
                unitOrder[upNext].GetComponent<UnitSelect>().isTurn = false;
            }
            else
            {
                unitOrder[upNext].gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            int check = upNext + 1;
            if (check < unitOrder.Count)
            {
                upNext++;
            }
            else upNext = 0;

            for (int i = 0; i < unitOrder.Count; i++)
            {
                if (unitOrder[upNext].tag == "Dead")
                {
                    int what = upNext + 1;
                    if (what < unitOrder.Count)
                    {
                        upNext++;
                    }
                    else upNext = 0;
                }
                else if (unitOrder[upNext].tag == "Player")
                {
                    i = unitOrder.Count;
                }
                else if (unitOrder[upNext].tag == "Enemy")
                {
                    i = unitOrder.Count;
                }

            }
          
            if (unitOrder[upNext].tag == "Player")
            {
                unitOrder[upNext].GetComponent<UnitSelect>().isTurn = true;
            }

            activeUnit = unitOrder[upNext];

            StartTurn();
        }
    }


   
}
