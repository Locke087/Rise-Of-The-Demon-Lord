using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutationTile : MonoBehaviour {

    /// <summary>
    /// A Mutation are tile in the prefeb that Mutate into various tile type like a forest fort, chest, ect.
    /// Possible Options are sent when the prefab is sent 
    /// </summary>

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Mutate(string[] options)
    {
        int max = options.Length;
        int rand = Random.Range(0, max - 1);
        gameObject.tag = options[rand];
    }
}
