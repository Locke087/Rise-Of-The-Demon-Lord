using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    //Unfinished Script

    public List<string> heldItems;
    // Use this for initialization
    void Start()
    {
        heldItems = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void AddToInventory()
    {

    }


    [System.Serializable]
    public class CurrentItems
    {

        public int totalDurability = 50;
        public int currentDurability = 50;
        public int weight = 5;
        public int might = 10;
        public int accurary = 80;
        public int[] range = { 1, 1 };
        public bool equipped = true;
        public int weaponUsed = 0;
        Stats stats;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {

            //  if (currentDurability <= 0) Destroy(this);
            currentDurability = totalDurability - weaponUsed;

            if (stats.weaponUsed)
            {
                stats.weaponUsed = false;
                weaponUsed++;
            }


        }
    }
}
