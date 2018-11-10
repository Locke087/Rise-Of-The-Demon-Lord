using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Success : MonoBehaviour {

    // Use this for initialization
    public MapRewards rewards;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Win()
    {
        rewards = GameObject.FindObjectOfType<MapRewards>();
        GameObject.Find("Menus").SetActive(false);
        GameObject tiles = GameObject.Instantiate(Resources.Load("WinScreen")) as GameObject;
        CurrentGame.game.memoryGeneral.gold += rewards.gold;
        GameObject.Find("GText").GetComponent<Text>().text = rewards.gold.ToString();
        InUse();
        StartCoroutine(BackToTown());

    }

    public void InUse()
    {
        foreach (CurrentLevel l in CurrentGame.game.memoryGeneral.currentLevels)
        {
            if (CurrentGame.game.memoryGeneral.currentLevelID == l.level) l.complete = true;
        }

    }


    public IEnumerator BackToTown()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Town");
    }
}
