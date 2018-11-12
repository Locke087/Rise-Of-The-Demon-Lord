using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiddleMapSave : MonoBehaviour {

    string mapname = "";
    string areaname = "";
    string type = "";
  
    string mapnameAlt = "";
    string areanamet = "";
    string typet = "";
    string rotatet = "";
    string empty = "";
    public Button confirm;
    public Button cancel;
    public Button cleanMaps;
    public Button cleanArea;
    public Button cleanType;
    public Text mapnameText;
    public Text areaText;
    public Text typeText;
    public Text fillText;
    public UserMapSaver mapSaver;

    void Start()
    {
        confirm.onClick.AddListener(Confirm);    
     
        cleanArea.onClick.AddListener(RemoveArea);
        cancel.onClick.AddListener(mapSaver.CancelMenu);
        // cleanMaterial = GameObject.Find("CleanBoxMaterial").GetComponent<Button>();
        cleanMaps.onClick.AddListener(RemoveMap);
        //  cleanSpecial = GameObject.Find("CleanBoxSpecial").GetComponent<Button>();
        cleanType.onClick.AddListener(RemoveType);
       
    }


    void FixedUpdate()
    {
        
    }


    public void AssignMap(string name, string display)
    {
        mapname = name;
        mapnameAlt = display;
        mapnameText.text = mapnameAlt;
    }

    public void AssignArea(string name, string display)
    {
        areaname = name;
        areanamet = display;
        areaText.text = areanamet;

    }

    public void AssignType(string name, string display)
    {
        type = name;
        typet = display;
        typeText.text = typet;
    }


    public void RemoveMap()
    {
        mapname = empty;
        mapnameText.text = empty;
    }

    public void RemoveArea()
    {
        areaname = empty;
        areaText.text = empty;
    }


    public void RemoveType()
    {
        type = empty;
        typeText.text = empty;
    }
    public bool allFilled()
    {
        if (mapnameText.text == empty) return false;
        else if (areaText.text == empty) return false;
        else if (typeText.text == empty) return false;
        return true;
    }


    IEnumerator noticeText()
    {
        yield return new WaitForSeconds(1.5f);
        fillText.text = "";
        fillText.color = Color.white;

    }

    public void Confirm()
    {
        if (allFilled())
        {
           
            if (mapname == "gd")
            {
                mapSaver.GD();
            }
            else if (mapname == "ft")
            {
                mapSaver.FT();
            }
            else if (mapname == "og")
            {
                mapSaver.OG();
            }
            else if (mapname == "sw")
            {
                mapSaver.SW();
            }
            fillText.text = "Saved To Map";
            fillText.color = Color.blue;
            StartCoroutine(noticeText());
        }
        else
        {
            fillText.text = "Select Remaining Factors";
            fillText.color = Color.red;
            StartCoroutine(noticeText());
        }
    }

    void Exit()
    {

    }

}
