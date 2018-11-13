using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnitManagerMenu : MonoBehaviour {

    public enum Menu
    {
        UnitMenu,
        Inventory,
        WeaponOrAssessory,
        WeaponList,
        AssessoryList,
        finalize
    }

    public Menu currentMenu;
    public GameObject menuPar;
    public Unit unit;
    public bool slot1;
    public bool slot2;
    public bool slot3;
    public bool slot4;
    public bool slot5;
    Vector2 scrollPosition;
    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();
        

        if (currentMenu == Menu.UnitMenu)
        {

            GUILayout.Box("Unit Menu");
            GUILayout.Space(10);

          

            foreach (Unit u in CurrentGame.game.memoryGeneral.unitsInRoster)
            {
                if (GUILayout.Button(u.unitID))
                {
                    unit = u;
                    currentMenu = Menu.Inventory;
                }

            }
            GUILayout.Space(10);
            if (GUILayout.Button("Exit Menu"))
            {
                menuPar.SetActive(false);
            }
        }



        else if (currentMenu == Menu.Inventory)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            //GUILayout.FlexibleSpace();
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(380), GUILayout.Height(700));
          

            GUILayout.Box("Select Slot");
            GUILayout.Space(3);

            GUILayout.Box("Slot 1: " + unit.inventory.invSlot1.holding);
            if (unit.inventory.invSlot1.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot1.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (GUILayout.Button("Get New Item"))
            {
                slot1 = true;

                currentMenu = Menu.WeaponOrAssessory;
            }
            if (unit.inventory.invSlot1.holding != "")
            {
                if (!unit.inventory.invSlot1.weapon.equipped && !unit.inventory.invSlot1.assessory.equipped)
                {
                    if (GUILayout.Button("Equip: " + unit.inventory.invSlot1.holding))
                    {
                        if (unit.inventory.invSlot1.weapon.inSlot)
                        {
                            unit.inventory.invSlot1.weapon.equipped = true;
                            if (unit.inventory.invSlot2.weapon.equipped) unit.inventory.invSlot2.weapon.equipped = false;
                            if (unit.inventory.invSlot3.weapon.equipped) unit.inventory.invSlot3.weapon.equipped = false;
                            if (unit.inventory.invSlot4.weapon.equipped) unit.inventory.invSlot4.weapon.equipped = false;
                            if (unit.inventory.invSlot5.weapon.equipped) unit.inventory.invSlot5.weapon.equipped = false;
                        }
                        else if (unit.inventory.invSlot1.assessory.inSlot)
                        {
                            int i = 0;
                            if (unit.inventory.invSlot1.assessory.equipped) i++;
                            if (unit.inventory.invSlot2.assessory.equipped) i++;
                            if (unit.inventory.invSlot3.assessory.equipped) i++;
                            if (unit.inventory.invSlot4.assessory.equipped) i++;
                            if (unit.inventory.invSlot5.assessory.equipped) i++;
                            if (i < 2) unit.inventory.invSlot1.assessory.equipped = true;
                            else GUILayout.Box("Only 3 Assessories Can Be Equipped");
                        }

                    }
                }
                else if (GUILayout.Button("Unequip: " + unit.inventory.invSlot1.holding))
                {
                    if (unit.inventory.invSlot1.weapon.inSlot)
                    {
                        unit.inventory.invSlot1.weapon.equipped = false;
                    }
                    else if (unit.inventory.invSlot1.assessory.inSlot)
                    {
                        unit.inventory.invSlot1.assessory.equipped = false;
                    }

                }
                if (GUILayout.Button("Remove: " + unit.inventory.invSlot1.holding))
                {
                    if (unit.inventory.invSlot1.weapon.inSlot)
                    {
                        unit.inventory.invSlot1.weapon.equipped = false;
                        unit.inventory.invSlot1.weapon.inSlot = false;
                        unit.inventory.invSlot1.holding = "";
                    }
                    else if (unit.inventory.invSlot1.assessory.inSlot)
                    {
                        unit.inventory.invSlot1.assessory.equipped = false;
                        unit.inventory.invSlot1.assessory.inSlot = false;
                        unit.inventory.invSlot1.holding = "";
                    }
                }
            }
        
            GUILayout.Space(3);
            GUILayout.Box("Slot 2: " + unit.inventory.invSlot2.holding);
            if (unit.inventory.invSlot2.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot2.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (GUILayout.Button("Get New Item"))
            {
                slot2 = true;
                currentMenu = Menu.WeaponOrAssessory;
            }
            if (unit.inventory.invSlot2.holding != "")
            {
                if (!unit.inventory.invSlot2.weapon.equipped && !unit.inventory.invSlot2.assessory.equipped)
                {
                    if (GUILayout.Button("Equip: " + unit.inventory.invSlot2.holding))
                    {
                        if (unit.inventory.invSlot2.weapon.inSlot)
                        {
                            unit.inventory.invSlot2.weapon.equipped = true;
                            if (unit.inventory.invSlot1.weapon.equipped) unit.inventory.invSlot1.weapon.equipped = false;
                            if (unit.inventory.invSlot3.weapon.equipped) unit.inventory.invSlot3.weapon.equipped = false;
                            if (unit.inventory.invSlot4.weapon.equipped) unit.inventory.invSlot4.weapon.equipped = false;
                            if (unit.inventory.invSlot5.weapon.equipped) unit.inventory.invSlot5.weapon.equipped = false;
                        }
                        else if (unit.inventory.invSlot2.assessory.inSlot)
                        {
                            int i = 0;
                            if (unit.inventory.invSlot1.assessory.equipped) i++;
                            if (unit.inventory.invSlot2.assessory.equipped) i++;
                            if (unit.inventory.invSlot3.assessory.equipped) i++;
                            if (unit.inventory.invSlot4.assessory.equipped) i++;
                            if (unit.inventory.invSlot5.assessory.equipped) i++;
                            if (i < 2) unit.inventory.invSlot2.assessory.equipped = true;
                            else GUILayout.Box("Only 3 Assessories Can Be Equipped");
                        }

                    }
                }
                else if (GUILayout.Button("Unequip: " + unit.inventory.invSlot2.holding))
                {
                    if (unit.inventory.invSlot2.weapon.inSlot)
                    {
                        unit.inventory.invSlot2.weapon.equipped = false;
                    }
                    else if (unit.inventory.invSlot2.assessory.inSlot)
                    {
                        unit.inventory.invSlot2.assessory.equipped = false;
                    }

                }
                if (GUILayout.Button("Remove: " + unit.inventory.invSlot2.holding))
                {
                    if (unit.inventory.invSlot2.weapon.inSlot)
                    {
                        unit.inventory.invSlot2.weapon.equipped = false;
                        unit.inventory.invSlot2.weapon.inSlot = false;
                        unit.inventory.invSlot2.holding = "";
                    }
                    else if (unit.inventory.invSlot2.assessory.inSlot)
                    {
                        unit.inventory.invSlot2.assessory.equipped = false;
                        unit.inventory.invSlot2.assessory.inSlot = false;
                        unit.inventory.invSlot2.holding = "";
                    }
                }
            }
            GUILayout.Space(3);

            GUILayout.Box("Slot 3: " + unit.inventory.invSlot3.holding);
            if (unit.inventory.invSlot3.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot3.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (GUILayout.Button("Get New Item"))
            {
                slot3 = true;
                currentMenu = Menu.WeaponOrAssessory;
            }
            if (unit.inventory.invSlot3.holding != "")
            {
                if (!unit.inventory.invSlot3.weapon.equipped && !unit.inventory.invSlot3.assessory.equipped)
                {
                    if (GUILayout.Button("Equip: " + unit.inventory.invSlot3.holding))
                    {
                        if (unit.inventory.invSlot3.weapon.inSlot)
                        {
                            unit.inventory.invSlot3.weapon.equipped = true;
                            if (unit.inventory.invSlot1.weapon.equipped) unit.inventory.invSlot1.weapon.equipped = false;
                            if (unit.inventory.invSlot2.weapon.equipped) unit.inventory.invSlot2.weapon.equipped = false;
                            if (unit.inventory.invSlot4.weapon.equipped) unit.inventory.invSlot4.weapon.equipped = false;
                            if (unit.inventory.invSlot5.weapon.equipped) unit.inventory.invSlot5.weapon.equipped = false;
                        }
                        else if (unit.inventory.invSlot3.assessory.inSlot)
                        {
                            int i = 0;
                            if (unit.inventory.invSlot1.assessory.equipped) i++;
                            if (unit.inventory.invSlot2.assessory.equipped) i++;
                            if (unit.inventory.invSlot3.assessory.equipped) i++;
                            if (unit.inventory.invSlot4.assessory.equipped) i++;
                            if (unit.inventory.invSlot5.assessory.equipped) i++;
                            if (i < 2) unit.inventory.invSlot3.assessory.equipped = true;
                            else GUILayout.Box("Only 3 Assessories Can Be Equipped");
                        }

                    }
                }
                else if (GUILayout.Button("Unequip: " + unit.inventory.invSlot3.holding))
                {
                    if (unit.inventory.invSlot3.weapon.inSlot)
                    {
                        unit.inventory.invSlot3.weapon.equipped = false;
                    }
                    else if (unit.inventory.invSlot3.assessory.inSlot)
                    {
                        unit.inventory.invSlot3.assessory.equipped = false;
                    }

                }
                if (GUILayout.Button("Remove: " + unit.inventory.invSlot3.holding))
                {
                    if (unit.inventory.invSlot3.weapon.inSlot)
                    {
                        unit.inventory.invSlot3.weapon.equipped = false;
                        unit.inventory.invSlot3.weapon.inSlot = false;
                        unit.inventory.invSlot3.holding = "";
                    }
                    else if (unit.inventory.invSlot3.assessory.inSlot)
                    {
                        unit.inventory.invSlot3.assessory.equipped = false;
                        unit.inventory.invSlot3.assessory.inSlot = false;
                        unit.inventory.invSlot3.holding = "";
                    }
                }
            }
            GUILayout.Space(3);
            GUILayout.Box("Slot 4: " + unit.inventory.invSlot4.holding);
            if (unit.inventory.invSlot4.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot4.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (GUILayout.Button("Get New Item"))
            {
                slot4 = true;
                currentMenu = Menu.WeaponOrAssessory;
            }
            if (unit.inventory.invSlot4.holding != "")
            {
                if (!unit.inventory.invSlot4.weapon.equipped && !unit.inventory.invSlot4.assessory.equipped)
                {
                    if (GUILayout.Button("Equip: " + unit.inventory.invSlot4.holding))
                    {
                        if (unit.inventory.invSlot4.weapon.inSlot)
                        {
                            unit.inventory.invSlot4.weapon.equipped = true;
                            if (unit.inventory.invSlot1.weapon.equipped) unit.inventory.invSlot1.weapon.equipped = false;
                            if (unit.inventory.invSlot2.weapon.equipped) unit.inventory.invSlot2.weapon.equipped = false;
                            if (unit.inventory.invSlot3.weapon.equipped) unit.inventory.invSlot3.weapon.equipped = false;
                            if (unit.inventory.invSlot5.weapon.equipped) unit.inventory.invSlot5.weapon.equipped = false;
                        }
                        else if (unit.inventory.invSlot4.assessory.inSlot)
                        {
                            int i = 0;
                            if (unit.inventory.invSlot1.assessory.equipped) i++;
                            if (unit.inventory.invSlot2.assessory.equipped) i++;
                            if (unit.inventory.invSlot3.assessory.equipped) i++;
                            if (unit.inventory.invSlot4.assessory.equipped) i++;
                            if (unit.inventory.invSlot5.assessory.equipped) i++;
                            if (i < 2) unit.inventory.invSlot4.assessory.equipped = true;
                            else GUILayout.Box("Only 3 Assessories Can Be Equipped");
                        }

                    }
                }
                else if (GUILayout.Button("Unequip: " + unit.inventory.invSlot4.holding))
                {
                    if (unit.inventory.invSlot4.weapon.inSlot)
                    {
                        unit.inventory.invSlot4.weapon.equipped = false;
                    }
                    else if (unit.inventory.invSlot4.assessory.inSlot)
                    {
                        unit.inventory.invSlot4.assessory.equipped = false;
                    }

                }
                if (GUILayout.Button("Remove: " + unit.inventory.invSlot4.holding))
                {
                    if (unit.inventory.invSlot4.weapon.inSlot)
                    {
                        unit.inventory.invSlot4.weapon.equipped = false;
                        unit.inventory.invSlot4.weapon.inSlot = false;
                        unit.inventory.invSlot4.holding = "";
                    }
                    else if (unit.inventory.invSlot4.assessory.inSlot)
                    {
                        unit.inventory.invSlot4.assessory.equipped = false;
                        unit.inventory.invSlot4.assessory.inSlot = false;
                        unit.inventory.invSlot4.holding = "";
                    }
                }
            }
            GUILayout.Space(3);

            GUILayout.Box("Slot 5: " + unit.inventory.invSlot4.holding);
            if (unit.inventory.invSlot5.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot5.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (GUILayout.Button("Get New Item"))
            {
                slot5 = true;
                currentMenu = Menu.WeaponOrAssessory;
            }
            if (unit.inventory.invSlot5.holding != "")
            {
                if (!unit.inventory.invSlot5.weapon.equipped && !unit.inventory.invSlot5.assessory.equipped)
                {
                    if (GUILayout.Button("Equip: " + unit.inventory.invSlot5.holding))
                    {
                        if (unit.inventory.invSlot5.weapon.inSlot)
                        {
                            unit.inventory.invSlot5.weapon.equipped = true;
                            if (unit.inventory.invSlot1.weapon.equipped) unit.inventory.invSlot1.weapon.equipped = false;
                            if (unit.inventory.invSlot2.weapon.equipped) unit.inventory.invSlot2.weapon.equipped = false;
                            if (unit.inventory.invSlot3.weapon.equipped) unit.inventory.invSlot3.weapon.equipped = false;
                            if (unit.inventory.invSlot4.weapon.equipped) unit.inventory.invSlot4.weapon.equipped = false;
                        }
                        else if (unit.inventory.invSlot5.assessory.inSlot)
                        {
                            int i = 0;
                            if (unit.inventory.invSlot1.assessory.equipped) i++;
                            if (unit.inventory.invSlot2.assessory.equipped) i++;
                            if (unit.inventory.invSlot3.assessory.equipped) i++;
                            if (unit.inventory.invSlot4.assessory.equipped) i++;
                            if (unit.inventory.invSlot5.assessory.equipped) i++;
                            if (i < 2) unit.inventory.invSlot5.assessory.equipped = true;
                            else GUILayout.Box("Only 3 Assessories Can Be Equipped");
                        }

                    }
                }
                else if (GUILayout.Button("Unequip: " + unit.inventory.invSlot5.holding))
                {
                    if (unit.inventory.invSlot5.weapon.inSlot)
                    {
                        unit.inventory.invSlot5.weapon.equipped = false;
                    }
                    else if (unit.inventory.invSlot5.assessory.inSlot)
                    {
                        unit.inventory.invSlot5.assessory.equipped = false;
                    }

                }
                if (GUILayout.Button("Remove: " + unit.inventory.invSlot5.holding))
                {
                    if (unit.inventory.invSlot5.weapon.inSlot)
                    {
                        unit.inventory.invSlot5.weapon.equipped = false;
                        unit.inventory.invSlot5.weapon.inSlot = false;
                        unit.inventory.invSlot5.holding = "";
                    }
                    else if (unit.inventory.invSlot5.assessory.inSlot)
                    {
                        unit.inventory.invSlot5.assessory.equipped = false;
                        unit.inventory.invSlot5.assessory.inSlot = false;
                        unit.inventory.invSlot5.holding = "";
                    }
                }
            }
  
            GUILayout.Space(5);
            if (GUILayout.Button("Confirm & Exit"))
            {
                int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                CurrentGame.game.storeroom.units[num] = unit;
                CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Cancel & Exit"))
            {
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Label("", GUILayout.Width(380), GUILayout.Height(500));
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }
   


        else if (currentMenu == Menu.WeaponOrAssessory)
        {
            GUILayout.Box("Select Item");
            GUILayout.Space(10);
            if (GUILayout.Button("Equip Weapon"))
            {
                currentMenu = Menu.WeaponList;
            }

            GUILayout.Space(10);
            if (GUILayout.Button("Equip Assessory"))
            {
                currentMenu = Menu.AssessoryList;
            }

            GUILayout.Space(5);
            if (GUILayout.Button("Comfirm & Exit"))
            {
                int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                CurrentGame.game.storeroom.units[num] = unit;
                CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Cancel & Exit"))
            {
                currentMenu = Menu.UnitMenu;
            }

        }



        else if (currentMenu == Menu.WeaponList)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            //GUILayout.FlexibleSpace();
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(380), GUILayout.Height(700));
            GUILayout.Box("Select Item");
            GUILayout.Space(10);
            foreach (UnitWeapon u in CurrentGame.game.memoryGeneral.itemsOwned.weapons)
            {
                if (!u.inSlot)
                {
                    GUILayout.Label(u.name);
                    //   GUILayout.Box("", GUILayout.Width(100), GUILayout.Height(100));
                    GUILayout.Label("Mt: " + u.details.might.ToString() + " | Hit: " + u.details.hitrate.ToString() + " | Wt: " + u.details.weight.ToString() +
                      " | CritR: " + u.details.critrate.ToString() + " | CritC: " + u.details.critchance.ToString() + " | Range: " + u.details.range.ToString());
                  /*GUILayout.Label("Might: " + u.details.might.ToString());
                    GUILayout.Label("Hitrate: " + u.details.hitrate.ToString());
                    GUILayout.Label("Range: " + u.details.range.ToString());
                    GUILayout.Label("Weight: " + u.details.weight.ToString());
                    GUILayout.Label("Critrate: " + u.details.critrate.ToString());
                    GUILayout.Label("Critchance: " + u.details.critchance.ToString());*/
                    if (u.details.physical) GUILayout.Label("Physical Damage");
                    if (u.details.magic) GUILayout.Label("Magic Damage");
                    if (u.details.effects.poison) GUILayout.Label("Poison");
                    if (u.details.effects.fireDamage) GUILayout.Label("Fire Damage");
                    GUILayout.Space(5);
                    if (GUILayout.Button("Put In Slot"))
                    {
                      
                        u.inSlot = true;
                        
                        if (slot1)
                        {
                            if (unit.inventory.invSlot1.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot1.weapon.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                            }
                            unit.inventory.invSlot1.holding = u.name;
                            unit.inventory.invSlot1.weapon = u;
                            unit.inventory.invSlot1.weapon.inSlot = true;
                        }
                        else if (slot2)
                        {
                            if (unit.inventory.invSlot2.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot2.weapon.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                            }
                            unit.inventory.invSlot2.holding = u.name;
                            unit.inventory.invSlot2.weapon = u;
                            unit.inventory.invSlot2.weapon.inSlot = true;
                        }
                        else if (slot3)
                        {
                            if (unit.inventory.invSlot3.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot3.weapon.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                            }
                            unit.inventory.invSlot3.holding = u.name;
                            unit.inventory.invSlot3.weapon = u;
                            unit.inventory.invSlot3.weapon.inSlot = true;
                        }
                        else if (slot4)
                        {
                            if (unit.inventory.invSlot4.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot4.weapon.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                            }
                            unit.inventory.invSlot4.holding = u.name;
                            unit.inventory.invSlot4.weapon = u;
                            unit.inventory.invSlot4.weapon.inSlot = true;
                        }
                        else if (slot5)
                        {
                            if (unit.inventory.invSlot5.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot5.weapon.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                            }
                            unit.inventory.invSlot5.holding = u.name;
                            unit.inventory.invSlot5.weapon = u;
                            unit.inventory.invSlot5.weapon.inSlot = true;
                        }
                        slot1 = false;
                        slot2 = false;
                        slot3 = false;
                        slot4 = false;
                        slot5 = false;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        currentMenu = Menu.Inventory;
                    }
                }

            }

       
            GUILayout.Space(5);
            if (GUILayout.Button("Confirm & Exit"))
            {
                int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                CurrentGame.game.storeroom.units[num] = unit;
                CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Cancel & Exit"))
            {
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Label("", GUILayout.Width(380), GUILayout.Height(500));
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();

        }

        else if (currentMenu == Menu.AssessoryList)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            //GUILayout.FlexibleSpace();
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(380), GUILayout.Height(700));
            GUILayout.Box("Select Item");
            GUILayout.Space(10);
            foreach (UnitAssessory u in CurrentGame.game.memoryGeneral.itemsOwned.assessories)
            {
                if (!u.inSlot)
                {
                    GUILayout.Box(u.name);
                    if (u.details.weight > 0) GUILayout.Label("Weight " + u.details.weight.ToString());
                    if (u.details.boostStr) GUILayout.Label("Boost Str" + " By " + u.details.boost.ToString());
                    if (u.details.boostDef) GUILayout.Label("Boost Def" + " By " + u.details.boost.ToString());
                    if (u.details.boostSkill) GUILayout.Label("Boost Skill" + " By " + u.details.boost.ToString());
                    if (u.details.boostHp) GUILayout.Label("Boost HP" + " By " + u.details.boost.ToString());
                    if (u.details.boostSpd) GUILayout.Label("Boost Spd" + " By " + u.details.boost.ToString());
                    if (u.details.boostWill) GUILayout.Label("Boost Will" + " By " + u.details.boost.ToString());

                    GUILayout.Space(5);
                    if (GUILayout.Button("Put In Slot"))
                    {
                        
                        u.inSlot = true;
                        if (slot1)
                        {
                            if (unit.inventory.invSlot1.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot1.assessory.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                            }
                            unit.inventory.invSlot1.holding = u.name;
                            unit.inventory.invSlot1.assessory = u;
                            unit.inventory.invSlot1.assessory.inSlot = true;
                        }
                        else if (slot2)
                        {
                            if (unit.inventory.invSlot2.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot2.assessory.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                            }
                            unit.inventory.invSlot2.holding = u.name;
                            unit.inventory.invSlot2.assessory = u;
                            unit.inventory.invSlot2.assessory.inSlot = true;
                        }
                        else if (slot3)
                        {
                            if (unit.inventory.invSlot3.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot3.assessory.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                            }
                            unit.inventory.invSlot3.holding = u.name;
                            unit.inventory.invSlot3.assessory = u;
                            unit.inventory.invSlot3.assessory.inSlot = true;
                        }
                        else if (slot4)
                        {
                            if (unit.inventory.invSlot4.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot4.assessory.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                            }
                            unit.inventory.invSlot4.holding = u.name;
                            unit.inventory.invSlot4.assessory = u;
                            unit.inventory.invSlot4.assessory.inSlot = true;
                        }
                        else if (slot5)
                        {
                            if (unit.inventory.invSlot5.holding != "")
                            {
                                int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot5.assessory.idx);
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                                CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                            }
                            unit.inventory.invSlot5.holding = u.name;
                            unit.inventory.invSlot5.assessory = u;
                            unit.inventory.invSlot5.assessory.inSlot = true;
                        }
                        slot1 = false;
                        slot2 = false;
                        slot3 = false;
                        slot4 = false;
                        slot5 = false;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        currentMenu = Menu.Inventory;
                    }
                }

            }
            GUILayout.Space(5);
            if (GUILayout.Button("Confirm & Exit"))
            {
                int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                CurrentGame.game.storeroom.units[num] = unit;
                CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Cancel & Exit"))
            {
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Label("", GUILayout.Width(380), GUILayout.Height(500));
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();

    }
}
