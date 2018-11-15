using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuForSW : MonoBehaviour {


   
    public Button scorch;
    public GameObject levelSelect;

    // Use this for initialization
    void Start()
    {
        UnitLoader unitLoader = gameObject.GetComponent<UnitLoader>();
        CurrentLevel level1 = new CurrentLevel();
        level1.deployLimit = 2;
        level1.powerRanking = 2;
        level1.enemiesInMap.units = unitLoader.LoadEnemies(level1.powerRanking);
        level1.name = "A Sweaty Welcome";
        level1.idx = "1" + IDMaker.NewID();
        level1.sceneName = "SWMap1";

        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Add(level1);
        CurrentLevel level2 = new CurrentLevel();
        level2.deployLimit = 4;
        level2.powerRanking = 1;
        level2.enemiesInMap.units = unitLoader.LoadEnemies(level2.powerRanking);
        level2.name = "An Oasis Of Evil";
        level2.idx = "2" + IDMaker.NewID();
        level2.sceneName = "SWMap1";

        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Add(level2);
        CurrentLevel level3 = new CurrentLevel();
        level3.deployLimit = 8;
        level3.powerRanking = 3;
        level3.enemiesInMap.units = unitLoader.LoadEnemies(level3.powerRanking);
        level3.name = "The Sands of Danger";
        level3.idx = "3" + IDMaker.NewID();
        level3.sceneName = "SWMap1";
        CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Add(level3);

        scorch.onClick.AddListener(LevelSelect);      
        levelSelect.SetActive(false);
    }

    public void LevelSelect()
    {
        levelSelect.SetActive(true);
    }

}
