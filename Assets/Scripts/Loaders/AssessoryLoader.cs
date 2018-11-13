using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssessoryLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public static void AssignAssessory(string a, UnitAssessory u)
    {

        UnitAssessoryDetails ruby = new UnitAssessoryDetails();
        ruby.name = "Ruby";
        ruby.boost = 0.2f;
        ruby.weight = 1;
        ruby.boostStr = true;
       
        if (a == ruby.name) u.details = ruby;

   

    }

    public static void StartingInventoryAssessory()
    {

        ///  if (a == vemonBlade.name) u.details = vemonBlade;
        UnitAssessory ruby = new UnitAssessory();
        ruby.name = "Ruby";       
        ruby.details.boost = 0.2f;
        ruby.details.weight = 1;
        ruby.details.boostStr = true;
        ruby.idx = "Ruby" + IDMaker.NewID();
        ruby.cost = 150;
      
        CurrentGame.game.memoryGeneral.itemsOwned.assessories.Add(ruby);
        CurrentGame.game.memoryGeneral.shopWares.assessories.Add(ruby);

        UnitAssessory ruby2 = new UnitAssessory();
        ruby2.name = "Ruby";
        ruby2.details.boost = 0.2f;
        ruby2.details.weight = 1;
        ruby2.details.boostStr = true;
        ruby2.idx = "Ruby" + IDMaker.NewID();

        CurrentGame.game.memoryGeneral.itemsOwned.assessories.Add(ruby2);
    }
}
