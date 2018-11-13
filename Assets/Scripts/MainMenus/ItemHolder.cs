using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemHolder {

    public string name;
    public int count;
    public int cost;
    public string description;
    public ItemEffects effects;
	public ItemHolder()
    {
        name = "";
        count = 0;
        cost = 0;
        description = "";
        effects = new ItemEffects();
    }
}

