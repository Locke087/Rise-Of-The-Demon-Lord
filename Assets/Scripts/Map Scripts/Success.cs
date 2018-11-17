using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Success : MonoBehaviour {

    // Use this for initialization
    public MapRewards rewards;



    public void Win()
    {
        rewards = GameObject.FindObjectOfType<MapRewards>();
        GameObject.Find("Menus").SetActive(false);
        GameObject tiles = GameObject.Instantiate(Resources.Load("WinScreen")) as GameObject;
        CurrentGame.game.memoryGeneral.gold += rewards.gold;
        GameObject.Find("GText").GetComponent<Text>().text = rewards.gold.ToString();
        CurrentGame.game.memoryGeneral.unitsInParty.Clear();
         
        if(CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {

        }
        else if (CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {

        }
        else if (CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {

        }
        else if (CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {

        }
        StartCoroutine(BackToTown());

    }

    public IEnumerator BackToTown()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Town");
    }
}
