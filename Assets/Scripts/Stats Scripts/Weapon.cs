using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{


    public Stats stats;
    public bool weaponUsed = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void statAssign(Stats newStats)
    {
        stats = newStats;
    }

    public void weaponStats()
    {
        stats.SetMeleetWeaponStats(0, 0, 0);

    }

    [System.Serializable]
    public class WeaponEquipped
    {

        // Use this for initialization
        public bool isSpd;
        public bool isStr;
        public bool isDef;
        public bool isSkill;
        public bool isHp;
        public bool visited = false;
        public int level = 0;
        public WeaponEquipped(bool spd, bool str, bool def, bool skl, bool hp)
        {
            level++;
            isSpd = spd;
            isStr = str;
            isDef = def;
            visited = false;
            isSkill = skl;
            isHp = hp;
        }


    }

    [System.Serializable]
    public class newWeapon
    {
        public string weaponName;
        public int totalDurability;
        public int currentDurability;
        public int weight;
        public int might;
        public int accurary;
        public int[] range;
        public bool equipped = false;
        public int weaponUsed;
        Stats stats;

        // Use this for initialization
        void Start()
        {

        }

        public newWeapon(int dur, int weight)
        {

        }
    }
}
