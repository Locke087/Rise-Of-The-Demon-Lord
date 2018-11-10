using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void GameEnd()
    {
        GameObject.Find("Menus").SetActive(false);
        GameObject tiles = GameObject.Instantiate(Resources.Load("GameOverScreen")) as GameObject;
        StartCoroutine(BackToMenu());
    }


    public IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
