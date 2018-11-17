using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuForOGL : MonoBehaviour {

 
    public Button overGrowth;
    public UnitLoader unitLoader;
    public GameObject levelSelect;
    
	// Use this for initialization
	void Start () {
  
        overGrowth.onClick.AddListener(LevelSelect);
        levelSelect.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

 
    public void LevelSelect()
    {
        levelSelect.SetActive(true);
    }

  
}
