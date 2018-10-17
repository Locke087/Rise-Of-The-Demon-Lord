using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingE : MonoBehaviour {

    public int count = 5;
    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < count; i++)
        {
            WarriorE.LevelUp();
            CavalierE.LevelUp();
        }
    }
	
}
