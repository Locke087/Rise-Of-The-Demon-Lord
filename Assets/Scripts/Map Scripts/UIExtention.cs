using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIExtention : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {

    // Use this for initialization
    public GameObject shape;
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
            GameObject user = GameObject.FindObjectOfType<MapManager>().currentUser;
            Transform tileP = gameObject.transform.parent;
            Transform rowP = gameObject.transform.parent.gameObject.transform.parent;
            if (user.GetComponent<MapPlayerAttack>().currentAttack.attackPattern != "")
            {
                           
                shape = GameObject.Instantiate(Resources.Load(user.GetComponent<MapPlayerAttack>().currentAttack.attackPattern)) as GameObject;
                shape.SetActive(true);
                shape.transform.parent = gameObject.GetComponentInParent<GridTiles>().gameObject.GetComponentInParent<Rows>().gameObject.GetComponentInParent<MapManager>().transform;
                shape.transform.localPosition = new Vector3(tileP.localPosition.x, (gameObject.transform.localPosition.y - 0.5f), rowP.transform.localPosition.z);
              
            }
            if (gameObject.GetComponentInParent<GridTiles>().unit != null)
            {
                gameObject.GetComponentInParent<GridTiles>().unit.GetComponent<Stats>().AttackPreview(user.GetComponent<Stats>());
            }
        }
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        if(shape != null) shape.SetActive(false);
        gameObject.GetComponentInParent<GridTiles>().overTile = false;
    }

   
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("sdjfjjs");
        gameObject.GetComponentInParent<GridTiles>().SendInfo();
       // if (shape != null) shape.transform.localPosition = new Vector3(shape.transform.localPosition.x, gameObject.transform.localPosition.y + 0.5f, shape.transform.localPosition.z);
        if (gameObject.GetComponentInParent<GridTiles>().unit != null)
        {
            GameObject.Find("DefHp").GetComponentInChildren<Text>().text = gameObject.GetComponentInParent<GridTiles>().unit.GetComponent<Stats>().currentHp.ToString();
        }

    }

   

}
