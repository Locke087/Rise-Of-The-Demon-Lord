using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupingOrganizer : MonoBehaviour {

    // Use this for initialization
    public int rewardCount;
    public int wallCount;
    public int objectiveCount;
    public int gapCount;
    public int cleanCount;
    public int reseter;
    public int resetAInRows;
    public int breakPoint;
    public int totalBreak;
    public bool redo = false;
    public bool stop = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //public void

    public bool Checklist(string type)
    {
        if(type == "Clean")
        {
            if (CheckClean()) return true;
        }
        else if (type == "Wall")
        {
            if (CheckWall()) return true;
        }
        else if (type == "Reward")
        {
            if (CheckReward()) return true;
        }
        else if (type == "Gap")
        {
            if (CheckGap()) return true;
        }
        else if (type == "Objective")
        {
            if (CheckObjective()) return true;
        }

        return false;
    }

    public void reload()
    {
        redo = true;
        rewardCount = 3;
        objectiveCount = 2;
        cleanCount = 6;
        gapCount = 1;
        wallCount = 3;
        resetAInRows++;
        if (resetAInRows > totalBreak) stop = true;
    }

    public bool CheckReward()
    {
        if (rewardCount > 0)
        {
            reseter = 0;
            rewardCount--;
            return true;
            
        }
        else reseter++;
        if (reseter > breakPoint) reload();
      
        return false;
        
    }


    public bool CheckWall()
    {
        if (wallCount > 0)
        {
            reseter = 0;
            wallCount--;
            return true;
        }
        else reseter++;
        if (reseter > breakPoint) reload();
        return false;
    }


    public bool CheckGap()
    {
        if (gapCount > 0)
        {
            reseter = 0;
            gapCount--;
            return true;
        }
        else reseter++;
        if (reseter > breakPoint) reload();
        return false;
    }


    public bool CheckClean()
    {
        if (cleanCount > 0)
        {
            reseter = 0;
            cleanCount--;
            return true;
        }
        else reseter++;
        if (reseter > breakPoint) reload();
        return false;
    }


    public bool CheckObjective()
    {
        if (objectiveCount > 0)
        {
            reseter = 0;
            objectiveCount--;
            return true;
        }
        else reseter++;
        if (reseter > breakPoint) reload();
        return false;
    }
}
