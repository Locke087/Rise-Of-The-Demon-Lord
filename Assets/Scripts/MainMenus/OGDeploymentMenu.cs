using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OGDeploymentMenu : MonoBehaviour {

  /*  public enum Menu
    {
        LevelMenu,
        WeaponList,
        AssessoryList,
        ItemList,

        Sell
    }

    public Menu currentMenu;
    public GameObject menuPar;
    public bool bought;
    public bool lookAtUnits;
    public bool addToUnit;
    //public Unit unit;
    Vector2 scrollPosition;
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width / 4, Screen.height / 4));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();
        GUILayout.Box("Total Gold " + CurrentGame.game.memoryGeneral.gold.ToString());
        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        if (currentMenu == Menu.LevelMenu)
        {

            GUILayout.Box("Select Level");
            GUILayout.Space(10);
            foreach (CurrentLevel level in CurrentGame.game.memoryGeneral.levelHolder.ogLevels.currentLevels)
            {
                if (!level.complete)
                {
                    if (GUILayout.Button(level.name + " Power Rating of " + level.powerRanking.ToString() + " Stars"))
                    {
                        currentMenu = Menu.WeaponList;
                    }
                }
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

            GUILayout.Space(5);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(380), GUILayout.Height(700));

            GUILayout.Box("Select Weapon");
            GUILayout.Space(10);
            foreach (UnitWeapon u in CurrentGame.game.memoryGeneral.shopWares.weapons)
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
                  GUILayout.Label("Critchance: " + u.details.critchance.ToString());
                if (u.details.physical) GUILayout.Label("Physical Damage");
                if (u.details.magic) GUILayout.Label("Magic Damage");
                if (u.details.effects.poison) GUILayout.Label("Poison");
                if (u.details.effects.fireDamage) GUILayout.Label("Fire Damage");


                if (u.cost <= CurrentGame.game.memoryGeneral.gold)
                {
                    if (GUILayout.Button("Buy for " + u.cost.ToString() + " gold"))
                    {
                        Debug.Log("Hdfsdifjdolkfj");
                        CurrentGame.game.memoryGeneral.gold = (CurrentGame.game.memoryGeneral.gold - u.cost);
                        CurrentGame.game.memoryGeneral.itemsOwned.weapons.Add(u);
                        bought = true;
                    }

                }
                else
                {
                    GUILayout.Box("Not Enough Gold");
                }
                if (bought)
                {
                    if (GUILayout.Button("Add To Unit?"))
                    {
                        bought = false;
                        lookAtUnits = true;
                    }
                    if (GUILayout.Button("Close"))
                    {
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }

                }
                if (lookAtUnits)
                {
                    foreach (Unit f in CurrentGame.game.memoryGeneral.unitsInRoster)
                    {
                        if (GUILayout.Button(f.unitID))
                        {
                            unit = f;
                            addToUnit = true;
                            lookAtUnits = false;
                        }
                    }
                    if (GUILayout.Button("Close"))
                    {
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }

                }
                if (addToUnit)
                {
                    lookAtUnits = false;
                    if (GUILayout.Button("Slot1"))
                    {
                        if (unit.inventory.invSlot1.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot1.weapon.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                        }
                        unit.inventory.invSlot1.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot1.weapon = u;
                        unit.inventory.invSlot1.weapon.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;


                    }
                    if (GUILayout.Button("Slot2"))
                    {
                        if (unit.inventory.invSlot2.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot2.weapon.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                        }
                        unit.inventory.invSlot2.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot2.weapon = u;
                        unit.inventory.invSlot2.weapon.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("Slot3"))
                    {
                        if (unit.inventory.invSlot3.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot3.weapon.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                        }
                        unit.inventory.invSlot3.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot3.weapon = u;
                        unit.inventory.invSlot3.weapon.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("Slot4"))
                    {
                        if (unit.inventory.invSlot4.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot4.weapon.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                        }
                        unit.inventory.invSlot4.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot4.weapon = u;
                        unit.inventory.invSlot4.weapon.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("Slot5"))
                    {
                        if (unit.inventory.invSlot5.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.weapons.FindIndex(x => x.idx == unit.inventory.invSlot5.weapon.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.weapons[numr].equipped = false;
                        }
                        unit.inventory.invSlot5.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot5.weapon = u;
                        unit.inventory.invSlot5.weapon.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("close"))
                    {
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                }
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Exit"))
            {
                currentMenu = Menu.LevelMenu;
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

            GUILayout.Box("Select Assessory");
            GUILayout.Space(10);

            foreach (UnitAssessory u in CurrentGame.game.memoryGeneral.shopWares.assessories)
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




                GUILayout.Space(5);

                if (u.cost <= CurrentGame.game.memoryGeneral.gold)
                {
                    if (GUILayout.Button("Buy for " + u.cost.ToString() + " gold"))
                    {
                        Debug.Log("Huummmmccccm");
                        CurrentGame.game.memoryGeneral.gold = (CurrentGame.game.memoryGeneral.gold - u.cost);
                        CurrentGame.game.memoryGeneral.itemsOwned.assessories.Add(u);
                        bought = true;
                    }
                }
                else
                {
                    GUILayout.Box("Not Enough Gold");
                }
                if (bought)
                {
                    if (GUILayout.Button("Add To Unit?"))
                    {
                        bought = false;
                        lookAtUnits = true;
                    }
                    if (GUILayout.Button("Close"))
                    {
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }

                }
                if (lookAtUnits)
                {
                    foreach (Unit f in CurrentGame.game.memoryGeneral.unitsInRoster)
                    {
                        if (GUILayout.Button(f.unitID))
                        {
                            unit = f;
                            addToUnit = true;
                            lookAtUnits = false;
                        }
                    }
                    if (GUILayout.Button("Close"))
                    {
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }

                }
                if (addToUnit)
                {
                    lookAtUnits = false;
                    if (GUILayout.Button("Slot1"))
                    {
                        if (unit.inventory.invSlot1.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot1.assessory.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                        }
                        unit.inventory.invSlot1.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot1.assessory = u;
                        unit.inventory.invSlot1.assessory.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        bought = false;
                        lookAtUnits = false;


                    }
                    if (GUILayout.Button("Slot2"))
                    {
                        if (unit.inventory.invSlot2.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot2.assessory.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                        }
                        unit.inventory.invSlot2.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot2.assessory = u;
                        unit.inventory.invSlot2.assessory.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("Slot3"))
                    {
                        if (unit.inventory.invSlot3.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot3.assessory.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                        }
                        unit.inventory.invSlot3.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot3.assessory = u;
                        unit.inventory.invSlot3.assessory.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("Slot4"))
                    {
                        if (unit.inventory.invSlot4.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot4.assessory.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                        }
                        unit.inventory.invSlot4.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot4.assessory = u;
                        unit.inventory.invSlot4.assessory.inSlot = true;

                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("Slot5"))
                    {
                        if (unit.inventory.invSlot5.holding != "")
                        {
                            int numr = CurrentGame.game.memoryGeneral.itemsOwned.assessories.FindIndex(x => x.idx == unit.inventory.invSlot5.assessory.idx);
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].inSlot = false;
                            CurrentGame.game.memoryGeneral.itemsOwned.assessories[numr].equipped = false;
                        }
                        unit.inventory.invSlot5.holding = u.name;
                        u.inSlot = true;
                        unit.inventory.invSlot5.assessory = u;
                        unit.inventory.invSlot5.assessory.inSlot = true;
                        int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                        int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                        CurrentGame.game.storeroom.units[num] = unit;
                        CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;

                    }
                    if (GUILayout.Button("close"))
                    {
                        addToUnit = false;
                        bought = false;
                        lookAtUnits = false;
                    }
                }

            }

            GUILayout.Space(5);
            if (GUILayout.Button("Exit"))
            {
                currentMenu = Menu.LevelMenu;
            }
            GUILayout.Label("", GUILayout.Width(380), GUILayout.Height(500));
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }

        else if (currentMenu == Menu.ItemList)
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
            foreach (ItemHolder u in CurrentGame.game.memoryGeneral.shopWares.items)
            {
                int num = CurrentGame.game.memoryGeneral.itemsOwned.items.FindIndex(x => x.name == u.name);
                GUILayout.Box(u.name);
                if (u.description != "") GUILayout.Label(u.description);
                if (u.effects.heal) GUILayout.Label("Heal" + " By " + u.effects.effectBase);
                if (u.effects.revive) GUILayout.Label("Revive" + " Total Hp x " + u.effects.effectMod);
                if (u.effects.curePoison) GUILayout.Label("Cure Poison");
                if (u.effects.doorKey) GUILayout.Label("Unlock Doors");
                if (u.effects.chestKey) GUILayout.Label("Unlock Chest");
                if (u.effects.boostRes) GUILayout.Label("Boost Res" + " Total Will x " + u.effects.effectMod + " for " + u.effects.effectimeLimit + " turns");

                GUILayout.Space(5);
                GUILayout.Box("You Own " + CurrentGame.game.memoryGeneral.itemsOwned.items[num].count.ToString());
                if (u.cost <= CurrentGame.game.memoryGeneral.gold)
                {
                    if (GUILayout.Button("Buy for " + u.cost.ToString() + " gold"))
                    {
                        CurrentGame.game.memoryGeneral.gold = (CurrentGame.game.memoryGeneral.gold - u.cost);
                        CurrentGame.game.memoryGeneral.itemsOwned.items[num].count += 1;
                    }
                }
                else
                {
                    GUILayout.Box("Not Enough Gold");
                }
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Exit"))
            {
                currentMenu = Menu.LevelMenu;
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
    }*/
}
