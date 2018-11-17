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
       

        scorch.onClick.AddListener(LevelSelect);      
        levelSelect.SetActive(false);
    }

    public void LevelSelect()
    {
        levelSelect.SetActive(true);
    }

}
