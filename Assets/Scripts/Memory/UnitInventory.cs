using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class UnitInventory {

    public UnitInvSlot1 invSlot1;
    public UnitInvSlot2 invSlot2;
    public UnitInvSlot3 invSlot3;
    public UnitInvSlot4 invSlot4;
    public UnitInvSlot5 invSlot5;

    public UnitInventory()
    {
        invSlot1 = new UnitInvSlot1();
        invSlot2 = new UnitInvSlot2();
        invSlot3 = new UnitInvSlot3();
        invSlot4 = new UnitInvSlot4();
        invSlot5 = new UnitInvSlot5();
    }
}
