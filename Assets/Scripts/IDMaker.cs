using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDMaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public static string NewID()
    {
        string rand = Random.Range(0, 100).ToString() + Random.Range(0, 100).ToString() + Time.realtimeSinceStartup + System.DateTime.UtcNow.ToLongDateString() + System.DateTime.UtcNow.ToLongTimeString();
        return rand;
    }
}
