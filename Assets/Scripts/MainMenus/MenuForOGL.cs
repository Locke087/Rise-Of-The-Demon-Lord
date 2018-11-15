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
        CurrentLevel level1 = new CurrentLevel();
        level1.deployLimit = 2;
        level1.powerRanking = 2;
        level1.enemiesInMap.units = unitLoader.LoadEnemies(level1.powerRanking);
        level1.name = "A Grassy Start";
        level1.idx = "1" + IDMaker.NewID();
        level1.sceneName = "OGLMap1";
        
        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Add(level1);
        CurrentLevel level2 = new CurrentLevel();
        level2.deployLimit = 4;
        level2.powerRanking = 1;
        level2.enemiesInMap.units = unitLoader.LoadEnemies(level2.powerRanking);
        level2.name = "A Deadly Knoll";
        level2.idx = "2" + IDMaker.NewID();
        level2.sceneName = "OGLMap1";
     
        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Add(level2);
        CurrentLevel level3 = new CurrentLevel();
        level3.deployLimit = 8;
        level3.powerRanking = 4;
        level3.enemiesInMap.units = unitLoader.LoadEnemies(level3.powerRanking);
        level3.name = "Weed Out The Enemy";
        level3.idx = "3" + IDMaker.NewID();
        level3.sceneName = "OGLMap1";
        CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Add(level3);
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
