using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{

    //Somewhat Unfinished Script
    public GameObject exts;
    public GameObject main;
    public StartMenu startMenu;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.activeInHierarchy == true)
            if (gameObject.GetComponentInChildren<Text>().color == Color.blue)
                if (Input.GetButtonDown("Action")) CheckName();


    }
    //press E
    void CheckName()
    {
        Debug.Log("ManageParty" + " vs " + gameObject.name);
        if (gameObject.name == "ManageParty")
        {
            Debug.Log("got in");
            PartyManagement();
        }
        if (gameObject.name == "Pt1")
        {
            Debug.Log("got less");
            BackToMenu();
        }

    }

    void PartyManagement()
    {
        exts.SetActive(true);
        main.SetActive(false);
        startMenu.ReassignMenuMovement("Ext", 2, 1);

    }

    void BackToMenu()
    {
        main.SetActive(true);
        exts.SetActive(false);
    }
}
