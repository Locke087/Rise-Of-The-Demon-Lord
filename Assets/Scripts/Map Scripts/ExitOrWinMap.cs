using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitOrWinMap : MonoBehaviour {

    public Success success;
    public Button winner;
    public Button run;
    private void Start()
    {
        winner.onClick.AddListener(JustWin);
        run.onClick.AddListener(Run);
    }

    public void JustWin()
    {
        success = GameObject.FindObjectOfType<Success>();
        success.Win();
    }

    public void Run()
    {
        CurrentGame.game.memoryGeneral.currentLevel = null;
        CurrentGame.game.memoryGeneral.gold -= 50;
        CurrentGame.game.memoryGeneral.unitsInParty.Clear();
        SceneManager.LoadScene("Town");

    }
}
