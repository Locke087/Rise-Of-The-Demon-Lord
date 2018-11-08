using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuForOGL : MonoBehaviour {

    public Button level1;
    public Button overGrowth;
    public Button back;
    public GameObject levelSelect;
    public GameObject main;
    
	// Use this for initialization
	void Start () {
        
        overGrowth.onClick.AddListener(LevelSelect);
        level1.onClick.AddListener(Level1);
        back.onClick.AddListener(BackOut);
        levelSelect.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}

    public void Level1()
    {
        EnemiesInMap enemiesInMap = new EnemiesInMap();
        enemiesInMap.units.AddRange(FindObjectOfType<UnitLoader>().LoadEnemies(2));
        CurrentGame.game.memoryGeneral.enemiesInMaps = enemiesInMap;
          
        SceneManager.LoadScene("OGLMap1");
    }

    public void LevelSelect()
    {
   
        levelSelect.SetActive(true);
        main.SetActive(false);
    }

    public void BackOut()
    {
        main.SetActive(true);
        levelSelect.SetActive(false);
    }
}
