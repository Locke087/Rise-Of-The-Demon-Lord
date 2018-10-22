using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleManStorage : MonoBehaviour {

    public string material = "";
    public string shape = "";
    public string special = "";
    public string rotate = "";
    public string materialt = "";
    public string shapet = "";
    public string specialt = "";
    public string rotatet = "";
    public int height = 0;
    string empty = "";
    int zero = 0;
    public Button confirm;
    public Button cancel;
    public Button cleanMaterial;
    public Button cleanShape;
    public Button cleanSpecial;
    public Button cleanRotate;
    public Button cleanHeight;
    public int area = 1;
    public Text materialText;
    public Text shapeText;
    public Text specialText;
    public Text rotateText;
    public Text heightText;
    public void Start()
    {
        //confirm = GameObject.Find("ConfirmB").GetComponent<Button>();
        confirm.onClick.AddListener(Confirm);
        //cancel = GameObject.Find("ResetB").GetComponent<Button>();
        cancel.onClick.AddListener(ResetMap);
        //cleanRotate = GameObject.Find("CleanBoxRotate").GetComponent<Button>();
        cleanRotate.onClick.AddListener(RemoveRotate);
       // cleanShape = GameObject.Find("CleanBoxShape").GetComponent<Button>();
        cleanShape.onClick.AddListener(RemoveShape);
       // cleanMaterial = GameObject.Find("CleanBoxMaterial").GetComponent<Button>();
        cleanMaterial.onClick.AddListener(RemoveMaterial);
      //  cleanSpecial = GameObject.Find("CleanBoxSpecial").GetComponent<Button>();
        cleanSpecial.onClick.AddListener(RemoveSpecial);
       // cleanHeight = GameObject.Find("CleanBoxHeight").GetComponent<Button>();
        cleanHeight.onClick.AddListener(RemoveHeight);
    }



    public void AssignMaterial(string name, string display)
    {
        Debug.Log(name + " " + display + " mat");
        material = name;
        materialt = display;
        materialText.text = materialt;
    }

    public  void AssignShape(string name, string display)
    {
        Debug.Log(name + " " + display + " shape");
        shape = name;
        shapet = display;
        shapeText.text = shapet;
        
    }

    public void AssignSpecial(string name, string display)
    {
        Debug.Log(name + " " + display + " spec");
        special = name;
        specialt = display;
        specialText.text = specialt;
    }

    public void AssignRotate(string name, string display)
    {
        Debug.Log(name + " " + display + " rotate");
        rotate = name;
        rotatet = display;
        rotateText.text = rotatet;
    }

    public void AssignHeight(int num)
    {
        Debug.Log(num + " " + " tall");
        height = num;
        heightText.text = height.ToString();
    }

    public void RemoveMaterial()
    {
        material = empty;
        materialText.text = empty;
    }

    public void RemoveShape()
    {
        shape = empty;
        shapeText.text = empty;
    }

    public void RemoveSpecial()
    {
        special = empty;
        specialText.text = empty;
    }

    public void RemoveRotate()
    {
        rotate = empty;
        rotateText.text = empty;
    }

    public void RemoveHeight()
    {
        height = zero;
        heightText.text = height.ToString();
    }

    public void Confirm()
    {

        GameObject maps = GameObject.Find("AreaPrim");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                if (tile.highlighted)
                {
                    tile.GetComponentInChildren<UIEditorExtention>().taken = true;
                    tile.highlighted = false;

                    if (shape != "") tile.tag = shape;
                    if (material != "") tile.CheckWithText(material);
                    if (special != "") tile.CheckSpecialorTurnText(special);
                    if (rotate != "")
                    {
                        tile.CheckSpecialorTurnText(rotate);
                        tile.TurnSelf();
                    }
                   
                    if (height != 0) tile.transform.localPosition = new Vector3(tile.transform.localPosition.x, height, tile.transform.localPosition.z);
                    tile.GetComponentInChildren<UIEditorExtention>().gameObject.GetComponent<Image>().color = Color.grey;
                    Debug.Log(tile.tag + " this is the tag");
                }
            }
        }

       GameObject.FindObjectOfType<LiveMapGenerator>().Generate(area);
       
    }

    public void ResetMap()
    {
        GameObject maps = GameObject.Find("AreaPrim");
        Rows[] allRows = maps.GetComponentsInChildren<Rows>();
        foreach (Rows row in allRows)
        {
            GridTiles[] allTiles = row.GetComponentsInChildren<GridTiles>();
            foreach (GridTiles tile in allTiles)
            {
                tile.Clean();
                tile.GetComponentInChildren<UIEditorExtention>().taken = false;
                tile.GetComponentInChildren<UIEditorExtention>().gameObject.GetComponent<Image>().color = Color.blue;
            }
        }

        maps = GameObject.Find("Area" + area.ToString());
        Destroy(maps);
    }


}
