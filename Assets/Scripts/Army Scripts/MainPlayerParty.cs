using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerParty : MonoBehaviour
{

    // Use this for initialization
    public List<GameObject> mainMCParty = new List<GameObject>();
    public List<string> newPartyList = new List<string>();
    public UnitParty unitParty;

    void Start()
    {
        unitParty = gameObject.GetComponent<UnitParty>();
        unitParty.FriendOrFoe(true);
        BuildPartyList();
        unitParty.CurrentParty(mainMCParty);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void BuildPartyList()
    {
        //  string[] names = { "Paul", "John", "BlastMan", "AcidMan", "BlockMan", "TundraMan", "TorchMan" };
        string[] names = { "Paul", "John", "BlastMan", "AcidMan", "TundraMan"};
        for (int i = 0; i < names.Length; i++) newPartyList.Add(names[i]);

        foreach (string name in newPartyList)
        {
            GameObject partyMate = Resources.Load<GameObject>(name);
            if (partyMate != null)
                mainMCParty.Add(partyMate);
        }
    }

}
