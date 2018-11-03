using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AreaHolder {

    public string id;
    public string type;
    public List<RowHolder> rows;
    public bool choosen;
	public AreaHolder()
    {
        id = "";
        type = "";
        rows = new List<RowHolder>();
        choosen = false;
    }
}
