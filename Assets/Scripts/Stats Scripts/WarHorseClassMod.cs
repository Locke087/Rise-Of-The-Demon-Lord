using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarHorseClassMod : MonoBehaviour
{


    public int classHp = 3;
    public int classStr = 5;
    public int classDef = 2;
    public int classSpd = 7;
    public int classSkill = 10;
    public int classMovement = 1;
    public Stats stats;

    // Use this for initializatize
    void Start()
    {
        stats = gameObject.GetComponent<Stats>();
        stats.hpMod = classHp;
        stats.strMod = classStr;
        stats.defMod = classDef;
        stats.spdMod = classSpd;
        stats.skillMod = classSkill;

        stats.movementMod = classMovement;

    }
    // Update is called once per frame
    void Update()
    {

    }

}
