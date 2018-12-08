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
  
      
        LevelUp.LevelUpNow();
    
        if(CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels.Find(x => x == CurrentGame.game.memoryGeneral.currentLevel).complete = true;
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.gold += CurrentGame.game.memoryGeneral.currentLevel.goldReward;         
            CurrentGame.game.memoryGeneral.unitsInParty.Clear();
 
        }
        else if (CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.levelHolder.ftLevels.currentLevels.Find(x => x == CurrentGame.game.memoryGeneral.currentLevel).complete = true;
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.gold += CurrentGame.game.memoryGeneral.currentLevel.goldReward;
         

            CurrentGame.game.memoryGeneral.unitsInParty.Clear();

        }
        else if (CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.levelHolder.swLevels.currentLevels.Find(x => x == CurrentGame.game.memoryGeneral.currentLevel).complete = true;
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.gold += CurrentGame.game.memoryGeneral.currentLevel.goldReward;       
            CurrentGame.game.memoryGeneral.unitsInParty.Clear();

        }
        else if (CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Exists(x => x == CurrentGame.game.memoryGeneral.currentLevel))
        {
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.levelHolder.gdLevels.currentLevels.Find(x => x == CurrentGame.game.memoryGeneral.currentLevel).complete = true;
            CurrentGame.game.memoryGeneral.currentLevel.complete = true;
            CurrentGame.game.memoryGeneral.gold += CurrentGame.game.memoryGeneral.currentLevel.goldReward;
           

            CurrentGame.game.memoryGeneral.unitsInParty.Clear();
        }
       
        StartCoroutine(BackToTown());

    }

    public IEnumerator BackToTown()
    {
        yield return new WaitForSeconds(0.1f);
        GameObject tiles = GameObject.Instantiate(Resources.Load("WinScreen")) as GameObject;
        GameObject.Find("GText").GetComponent<Text>().text = CurrentGame.game.memoryGeneral.currentLevel.goldReward.ToString();
        GameObject.Find("Menus").SetActive(false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Town");
    }
}
