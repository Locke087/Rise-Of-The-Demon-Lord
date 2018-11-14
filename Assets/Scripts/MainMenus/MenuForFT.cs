using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuForFT : MonoBehaviour {

    public Button level1;
    public Button frozen;
    public Button back;
    public GameObject levelSelect;
    public GameObject main;

    // Use this for initialization
    void Start()
    {

        frozen.onClick.AddListener(LevelSelect);
        level1.onClick.AddListener(Level1);
        back.onClick.AddListener(BackOut);
        CheckStatus();
        levelSelect.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckStatus()
    {
        if (InUse("ftlevel1"))
        {
            level1.GetComponent<Image>().color = Color.gray;
            level1.onClick.RemoveAllListeners();
        }

    }

    public bool InUse(string name)
    {
        foreach (CurrentLevel l in CurrentGame.game.memoryGeneral.currentLevels)
        {
            if (name == l.level) return true;
        }
        return false;
    }

    public void Level1()
    {
        EnemiesInMap enemiesInMap = new EnemiesInMap();
        enemiesInMap.units.AddRange(FindObjectOfType<UnitLoader>().LoadEnemies(2));
        CurrentGame.game.memoryGeneral.enemiesInMaps = enemiesInMap;
        string name = "ftlevel1";
        CurrentGame.game.memoryGeneral.currentLevelID = name;
     
        SceneManager.LoadScene("FTMap1");
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
