using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSwitch : MonoBehaviour
{
    public bool prepOn = false;
    public bool gridOn = true;
    public Button button;
    // Use this for initialization
    void Start()
    {
        gridOn = true;
        // button.onClick.AddListener(OnOffGrid);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnOffGrid()
    {
        if (gridOn == true) gridOn = false;
        else gridOn = true;
    }

    public void OnOffPrep()
    {
        if (gridOn == true) gridOn = false;
        else gridOn = true;
    }

}
