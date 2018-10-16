using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimParty : MonoBehaviour
{

    public List<GameObject> jimParty = new List<GameObject>();
    public List<string> newPartyList = new List<string>();
    public UnitParty unitParty;
    void Start()
    {
        unitParty = gameObject.GetComponent<UnitParty>();
        unitParty.FriendOrFoe(false);
        BuildPartyList();
        unitParty.CurrentParty(jimParty);
        unitParty.EnemyLevel(5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void BuildPartyList()
    {

        string[] names = { "Jim", "Cavailer", "Warrior", "Cavailer", "Warrior" };
        for (int i = 0; i < names.Length; i++) newPartyList.Add(names[i]);

        foreach (string name in newPartyList)
        {
            GameObject partyMate = Resources.Load<GameObject>(name);
            if (partyMate != null)
                jimParty.Add(partyMate);
        }
    }
}
