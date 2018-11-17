using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuForGD : MonoBehaviour {

    public Button growling;
    
    public GameObject levelSelect;
  

    // Use this for initialization
    void Start()
    {
     

        growling.onClick.AddListener(LevelSelect);   
        levelSelect.SetActive(false);
    }

    public void LevelSelect()
    {
        levelSelect.SetActive(true);  
    }
}
