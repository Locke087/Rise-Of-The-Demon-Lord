using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIExtention : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.GetComponentInParent<GridTiles>().overTile = true;
        if (gameObject.GetComponentInParent<GridTiles>().attack)
        {

        }
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.GetComponentInParent<GridTiles>().overTile = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("sdjfjjs");
        gameObject.GetComponentInParent<GridTiles>().SendInfo();
        if (gameObject.GetComponentInParent<GridTiles>().unit != null)
        {
            GameObject.Find("DefHp").GetComponentInChildren<Text>().text = gameObject.GetComponentInParent<GridTiles>().unit.GetComponent<Stats>().currentHp.ToString();
        }

    }

   

}
