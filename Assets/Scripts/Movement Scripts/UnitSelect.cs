using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitSelect : MonoBehaviour, IPointerClickHandler
{
    PlayerUnitMenu unitMenu;
    bool twice = false;
	// Use this for initialization
	void Start () {
        unitMenu = GameObject.FindObjectOfType<PlayerUnitMenu>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!unitMenu.menuActive)
        {
            unitMenu.AssignUnit(gameObject);
            unitMenu.ActiveMenu();

        }
        else if (unitMenu.menuActive && twice)
        {
            unitMenu.RemoveUnit();
            unitMenu.DeactiveMenu();
        }
    }

}
