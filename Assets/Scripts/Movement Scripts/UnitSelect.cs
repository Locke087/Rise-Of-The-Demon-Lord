using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelect : MonoBehaviour
{
    PlayerUnitMenu unitMenu;
    bool twice = false;
    public bool isTurn = false;
	// Use this for initialization
	void Start () {
        unitMenu = GameObject.FindObjectOfType<PlayerUnitMenu>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Menu()
    {
        Debug.Log("Why??????");
        unitMenu.AssignUnit(gameObject);
        yield return new WaitForSeconds(0.01f);
        unitMenu.ActiveMenu();

    }

}
