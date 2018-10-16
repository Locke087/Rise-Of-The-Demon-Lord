using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARandomNature : MonoBehaviour {

    // Use this for initialization
    public List<string> allNature;
	void Start () {
        

    }
	
    public void PickANature()
    {
        allNature = new List<string>();
        allNature.Add("Nimble");
        allNature.Add("Tough");
        allNature.Add("Strong");
        allNature.Add("Aggressive");
        allNature.Add("Handy");
        allNature.Add("Heathly");
        allNature.Add("Neutral");
        int i = Random.Range(0, allNature.Count - 1);
        GetComponent<Stats>().nature = allNature[i];
    }
}
