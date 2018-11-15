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
    public GameObject partyMenu;
    public Button unitMenu;
    public Button shopMenu;
    public GameObject shopM;
    public Text changer;
    public Button changeButton;
	void Start () {
        CurrentGame.game.memoryGeneral.unitsInParty.Clear();
      // changeButton.onClick.AddListener(ChangeText);
      mapEditor.onClick.AddListener(LoadEditor);
        shopMenu.onClick.AddListener(ShopMenu);
        save.onClick.AddListener(Save);
        unitMenu.onClick.AddListener(UnitMenu);
      //  changer.text = CurrentGame.game.memoryGeneral.doISave;
        saveMenu.SetActive(false);
  
    }
	
   /* void ChangeText()
    {
        CurrentGame.game.memoryGeneral.doISave = "chess";
        changer.text = CurrentGame.game.memoryGeneral.doISave;
    }*/
    void ShopMenu()
    {
        shopM.SetActive(true);
    }

    void UnitMenu()
    {
        partyMenu.SetActive(true);
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
