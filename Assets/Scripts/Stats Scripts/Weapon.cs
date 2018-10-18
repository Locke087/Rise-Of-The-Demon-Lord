using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{


    public Stats stats;
    public int might;
    public int hitrate;
    public int weight;
    public float critrate;
    public int critchance;
    public bool weaponUsed = true;
    public string weapon = "";
    public List<WeaponEquipped> allWeapons;
    // Use this for initialization
    void Start()
    {
        stats = gameObject.GetComponent<Stats>();
        allWeapons = new List<WeaponEquipped>();
        allWeapons.Add(new WeaponEquipped("Sword", "Long Sword", 8, 60, 5, 1.5f, 5));
        allWeapons.Add(new WeaponEquipped("Axe", "Battle Axe", 8, 60, 9, 2, 5));
        weaponStats();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void weaponStats()
    {
        int key = 0;
        int count = 0;
        foreach (WeaponEquipped w in allWeapons)
        {
            if (w.weaponName == weapon) key = count;
            count++;
        }
        if (key > 1) key = 1;
        might = allWeapons[key].isMight;
        hitrate = allWeapons[key].isHit;
        weight = allWeapons[key].isWeight;
        critchance = allWeapons[key].isCritChance;
        critrate = allWeapons[key].isCritRate;

        stats.SetMeleetWeaponStats(hitrate, might, weight, critchance, critrate);

    }

    [System.Serializable]
    public class WeaponEquipped
    {

        // Use this for initialization
        public string weaponType;
        public string weaponName;
        public int isMight;
        public int isHit;
        public int isWeight;
        public float isCritRate;
        public int isCritChance;
        public WeaponEquipped(string wt, string wn, int m, int h, int w, float cr, int cc)
        {
            weaponType = wt;
            weaponName = wn;
            isMight = m;
            isHit = h;
            isWeight = w;
            isCritRate = cr;
            isCritChance = cc;
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
