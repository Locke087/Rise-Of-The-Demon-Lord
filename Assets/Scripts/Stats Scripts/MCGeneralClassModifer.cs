using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCGeneralClassMod : MonoBehaviour
{

    public int classHp = 8;
    public int classStr = 10;
    public int classDef = 5;
    public int classSpd = 7;
    public int classSkill = 10;
    public int classMovement = 0;
    public Stats stats;
    // Use this for initialization

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
