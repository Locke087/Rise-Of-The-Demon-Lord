using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveler : MonoBehaviour {

    // Use this for initialization
    public int levels = 5;
	void Start () {
		for (int i = 0; i < levels; i++)
        {
            Warrior.LevelUp();
            Cavalier.LevelUp();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
