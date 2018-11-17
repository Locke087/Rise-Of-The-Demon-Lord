using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuForFT : MonoBehaviour {

    public Button frozen;  
    public GameObject levelSelect;
    
    // Use this for initialization
    void Start()
    {
      

        frozen.onClick.AddListener(LevelSelect);
        levelSelect.SetActive(false);
    }

 
    public void LevelSelect()
    {

        levelSelect.SetActive(true);
    }

}
