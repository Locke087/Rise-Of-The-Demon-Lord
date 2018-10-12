using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rout : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Win()
    {
        GameObject.FindObjectOfType<Success>().Win();
    }
}
