﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericHorseman : Stats
{
    // Use this for initialization
    void Start()
    {
        hp = 20;
        str = 8;
        def = 4;
        spd = 6;
        skill = 10;

        movement = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }

}