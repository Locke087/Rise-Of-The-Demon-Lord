using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileHolder {

    public string type;
    public string turnOrSpecial;
    public string material;
    public int height;
    public string id;

    public TileHolder(string ty, string turn, string mat, int h, string i)
    {
        type = ty;
        turnOrSpecial = turn;
        material = mat;
        height = h;
        id = i;
    }
}
