using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TownGeneralMenu : MonoBehaviour {

    // Use this for initialization
    public Button mapEditor;
    public Button save;
    public GameObject saveMenu;
    public Text changer;
    public Button changeButton;
	void Start () {
        changeButton.onClick.AddListener(ChangeText);
        mapEditor.onClick.AddListener(LoadEditor);
        save.onClick.AddListener(Save);
        changer.text = CurrentGame.game.memoryGeneral.doISave;
        saveMenu.SetActive(false);
  
    }
	
    void ChangeText()
    {
        CurrentGame.game.memoryGeneral.doISave = "chess";
        changer.text = CurrentGame.game.memoryGeneral.doISave;
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Save()
    {
        saveMenu.SetActive(true);
    }

    

    void LoadEditor()
    {
        SceneManager.LoadScene("UserEndMapEditor");
    }
}
