using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class UIEditorExtention : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler {

    public bool taken = false;
    //public bool removeMe = false;
	// Use this for initialization
	void Start()
    {
        gameObject.GetComponent<Image>().color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!taken)
        {
            if (Input.GetButton("Select"))
            {
                gameObject.GetComponentInParent<GridTiles>().highlighted = true;
                gameObject.GetComponent<Image>().color = Color.magenta;
                // gameObject.GetComponent
            }
            if (Input.GetButton("Deselect") || Input.GetButton("Remove"))
            {
                gameObject.GetComponentInParent<GridTiles>().highlighted = false;
                gameObject.GetComponent<Image>().color = Color.blue;
            }
            if (!gameObject.GetComponentInParent<GridTiles>().highlighted) gameObject.GetComponent<Image>().color = Color.green;

        }
        else
        {
            gameObject.GetComponent<Image>().color = Color.grey;

            /*if (Input.GetButton("Remove"))
            {
                gameObject.GetComponentInParent<GridTiles>().highlighted = false;
                removeMe = true;
                taken = true;
                GameObject.FindObjectOfType<LiveMapGenerator>().Remove(GameObject.FindObjectOfType<MiddleManStorage>().area);
               // gameObject.GetComponent<Image>().color = Color.blue;
               // taken = false;
            }*/
        }

       
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!taken)
        {
            if (!gameObject.GetComponentInParent<GridTiles>().highlighted) gameObject.GetComponent<Image>().color = Color.blue;
        }
        else gameObject.GetComponent<Image>().color = gameObject.GetComponent<Image>().color = Color.grey;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (!taken)
        {
            if (gameObject.GetComponentInParent<GridTiles>().highlighted)
            {
                gameObject.GetComponent<Image>().color = Color.blue;
                gameObject.GetComponentInParent<GridTiles>().highlighted = false;
            }
            else
            {
                gameObject.GetComponent<Image>().color = Color.magenta;
                gameObject.GetComponentInParent<GridTiles>().highlighted = true;
            }
        }
        else
        {
           // Debug.Log("why me tyrtyhh??");
            gameObject.GetComponentInParent<GridTiles>().highlighted = false;
          StartCoroutine(removePiece());
           // GameObject.FindObjectOfType<LiveMapGenerator>().Remove(GameObject.FindObjectOfType<MiddleManStorage>().area);
            //gameObject.GetComponent<Image>().color = Color.blue;
        }

    }


    public IEnumerator removePiece()
    {
        gameObject.GetComponentInParent<GridTiles>().Clean();
        gameObject.GetComponentInParent<GridTiles>().tag = "Tile";
        gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, 1, gameObject.transform.localPosition.z);
        GameObject maps = GameObject.Find("Area" + GameObject.FindObjectOfType<MiddleManStorage>().area.ToString());
        Destroy(maps);
        yield return new WaitForSeconds(0.01f);
        GameObject.FindObjectOfType<LiveMapGenerator>().Generate(GameObject.FindObjectOfType<MiddleManStorage>().area);
        taken = false;
        gameObject.GetComponent<Image>().color = Color.blue;
    }

    /*private void OnMouseOver()
    {
        if (!taken)
        {
            if (Input.GetButton("Select"))
            {
                gameObject.GetComponentInParent<GridTiles>().highlighted = true;
                gameObject.GetComponent<Image>().color = Color.yellow;
                // gameObject.GetComponent
            }

            if (Input.GetButton("Remove"))
            {
                gameObject.GetComponentInParent<GridTiles>().highlighted = false;
                gameObject.GetComponent<Image>().color = Color.blue;
            }
        }

        if (Input.GetButton("Deselect"))
        {
            gameObject.GetComponentInParent<GridTiles>().highlighted = false;
        }
    }*/



}
