using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AttackController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    // Use this for initialization
    public GameObject holder1;
    public GameObject holder2;
    public GameObject holder3;
    public GameObject holder4;
    public GameObject holder5;
    public GameObject holder6;
    public GameObject holder7;
    public GridTiles tile1;
    public GridTiles tile2;
    public GridTiles tile3;
    public GridTiles tile4;
    public GridTiles tile5;
    public GridTiles tile6;
    public GridTiles tile7;
    public bool oneTile;
    public bool twoTiles;
    public bool threeTiles;
    public bool fourTiles;
    public bool fiveTiles;
    public bool sixTiles;
    public bool sevenTiles;
    void Start () {

	}

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (oneTile)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);

            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();
        }
        if (twoTiles)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);
            tile2 = FindAssociatedTile.FindMyTile(holder2.transform.localPosition, gameObject);

            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile2.unit != null)
            {
                tile2.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();
        }
        if (threeTiles)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);
            tile2 = FindAssociatedTile.FindMyTile(holder2.transform.localPosition, gameObject);
            tile3 = FindAssociatedTile.FindMyTile(holder3.transform.localPosition, gameObject);

            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile2.unit != null)
            {
                tile2.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile3.unit != null)
            {
                tile3.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();
        }
        if (fourTiles)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);
            tile2 = FindAssociatedTile.FindMyTile(holder2.transform.localPosition, gameObject);
            tile3 = FindAssociatedTile.FindMyTile(holder3.transform.localPosition, gameObject);
            tile4 = FindAssociatedTile.FindMyTile(holder4.transform.localPosition, gameObject);

            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile2.unit != null)
            {
                tile2.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile3.unit != null)
            {
                tile3.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile4.unit != null)
            {
                tile4.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();
        }
        if (fiveTiles)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);
            tile2 = FindAssociatedTile.FindMyTile(holder2.transform.localPosition, gameObject);
            tile3 = FindAssociatedTile.FindMyTile(holder3.transform.localPosition, gameObject);
            tile4 = FindAssociatedTile.FindMyTile(holder4.transform.localPosition, gameObject);
            tile5 = FindAssociatedTile.FindMyTile(holder5.transform.localPosition, gameObject);

            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile2.unit != null)
            {
                tile2.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile3.unit != null)
            {
                tile3.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile4.unit != null)
            {
                tile4.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile5.unit != null)
            {
                tile5.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();
        }
        else if (sixTiles)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);
            tile2 = FindAssociatedTile.FindMyTile(holder2.transform.localPosition, gameObject);
            tile3 = FindAssociatedTile.FindMyTile(holder3.transform.localPosition, gameObject);
            tile4 = FindAssociatedTile.FindMyTile(holder4.transform.localPosition, gameObject);
            tile5 = FindAssociatedTile.FindMyTile(holder5.transform.localPosition, gameObject);
            tile6 = FindAssociatedTile.FindMyTile(holder6.transform.localPosition, gameObject);

            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile2.unit != null)
            {
                tile2.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile3.unit != null)
            {
                tile3.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile4.unit != null)
            {
                tile4.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile5.unit != null)
            {
                tile5.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile6.unit != null)
            {
                tile6.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();

        }
        if (sevenTiles)
        {
            tile1 = FindAssociatedTile.FindMyTile(holder1.transform.localPosition, gameObject);
            tile2 = FindAssociatedTile.FindMyTile(holder2.transform.localPosition, gameObject);
            tile3 = FindAssociatedTile.FindMyTile(holder3.transform.localPosition, gameObject);
            tile4 = FindAssociatedTile.FindMyTile(holder4.transform.localPosition, gameObject);
            tile5 = FindAssociatedTile.FindMyTile(holder5.transform.localPosition, gameObject);
            tile6 = FindAssociatedTile.FindMyTile(holder6.transform.localPosition, gameObject);
            tile7 = FindAssociatedTile.FindMyTile(holder7.transform.localPosition, gameObject);
            if (tile1.unit != null)
            {
                tile1.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile2.unit != null)
            {
                tile2.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile3.unit != null)
            {
                tile3.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile4.unit != null)
            {
                tile4.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile5.unit != null)
            {
                tile5.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile6.unit != null)
            {
                tile6.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            if (tile7.unit != null)
            {
                tile7.unit.GetComponent<Stats>().Skill(GameObject.FindObjectOfType<MapManager>().currentUser.GetComponent<Stats>());
            }
            GameObject.FindObjectOfType<MapManager>().PlayerSkill();
        }

    }
}
