using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileHeightSelector : MonoBehaviour {
    public InputField input;
    // Use this for initialization
    void Start () {
        input = GameObject.Find("HeightSelector").GetComponent<InputField>();
        input.onValueChanged.AddListener(delegate { WhatHeight(); });

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WhatHeight()
    {
        string height = input.text;
        if (height != "") GameObject.FindObjectOfType<MiddleManStorage>().AssignHeight((int.Parse(height)));      
    }


}
