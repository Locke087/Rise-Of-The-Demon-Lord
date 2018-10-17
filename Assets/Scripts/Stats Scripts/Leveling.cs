using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveling : MonoBehaviour {

    public int count;
    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < count; i++)
        {
            Warrior.LevelUp();
            Cavalier.LevelUp();
        }
    }
	
	
}
