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

    public static string RandomNature()
    {
        List<string> allNatures = new List<string>();
        allNatures.Add("Nimble");
        allNatures.Add("Quick");
        allNatures.Add("Runner");
        allNatures.Add("Sprinter");
        allNatures.Add("Speedy");
        allNatures.Add("Smart");
        allNatures.Add("Magical");
        allNatures.Add("Nuke");
        allNatures.Add("SpellCaster");
        allNatures.Add("Haphazard");
        //sp st de sk hp mag will
        allNatures.Add("Willfull");
        allNatures.Add("Resistant");
        allNatures.Add("Resilient");
        allNatures.Add("Faithfull");
        allNatures.Add("Hopefull");
        allNatures.Add("Surviver");

        allNatures.Add("Tough");
        allNatures.Add("Guard");
        allNatures.Add("Hard");
        allNatures.Add("Heavy");
        allNatures.Add("Thick");
        allNatures.Add("Bulky");

        allNatures.Add("Strong");
        allNatures.Add("Aggressive");
        allNatures.Add("Ripper");
        allNatures.Add("Fighter");
        allNatures.Add("Wild");
        allNatures.Add("Hulk");
       
        allNatures.Add("Handy");
        allNatures.Add("Sure");
        allNatures.Add("Steady");
        allNatures.Add("Firm");
        allNatures.Add("Aimmer");
        allNatures.Add("Ready");

        allNatures.Add("Heathly");
        allNatures.Add("Hardy");
        allNatures.Add("Knowing");
        allNatures.Add("Drifter");
        allNatures.Add("Weak");
        allNatures.Add("Dumb");
        allNatures.Add("Lame");

        allNatures.Add("Neutral");
        int i = Random.Range(0, allNatures.Count);
        return allNatures[i];
    }

  

}
