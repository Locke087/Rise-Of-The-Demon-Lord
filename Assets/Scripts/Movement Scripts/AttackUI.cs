using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttackUI : MonoBehaviour {
    [SerializeField] GameObject CrossAttack;
    [SerializeField] GameObject SquareAttack;
    [SerializeField] GameObject LineAttack;
    public List<GameObject> unitsShapes;
    public List<string> attackNames;
    public GameObject currentUser;
    public TextMeshProUGUI textMeshPro;
    public List<string> attackOptions;

	// Use this for initialization
	void Start () {
        attackOptions = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadAttackOptions(string[] list)
    {
        attackOptions.Clear();
        textMeshPro.text = "";
        attackOptions.AddRange(list);
        foreach (string attack in attackOptions)
        {
            textMeshPro.text += attack + "\n";
        }
    }

    public void LoadAttackNames(string[] list)
    {
        attackNames.Clear();
        attackNames.AddRange(list);
       /* foreach (string name in attackNames)
        {
            
        }*/
    }

    public void LoadAttackNames(GameObject[] list)
    {
        unitsShapes.Clear();
        unitsShapes.AddRange(list);
        /* foreach (string name in attackNames)
         {

         }*/
    }

    public void SendAttackName()
    {

    }



}
