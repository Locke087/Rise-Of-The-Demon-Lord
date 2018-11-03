using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RowHolder {

    public List<TileHolder> tiles;
    public string idx;
    public RowHolder(string id)
    {
        tiles = new List<TileHolder>();
        idx = id;
    }
}
