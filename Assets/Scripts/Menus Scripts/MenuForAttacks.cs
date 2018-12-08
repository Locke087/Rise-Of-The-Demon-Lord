using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuForAttacks : MonoBehaviour {

    public enum Menu
    {
        HomeMenu,
        SkillSelection,
        Items
    }
    public Menu currentMenu;
    public GameObject menuPar;
    public bool checking;
    Vector2 scrollPosition;
    public Unit unit;
    public UnitSkillDetail empty;
    public SpeedCenterTurns turnCon;
    public MapPlayerAttack attack;
    public GameObject unitObj;
    public List<GameObject> gotChest;
    public List<GameObject> gotDoor;
    void Start()
    {
        empty = new UnitSkillDetail();
        checking = false;
        gotChest = new List<GameObject>();
        gotDoor = new List<GameObject>();
    }

    public Unit FindMyself(string unitID)
    {
        Unit me = new Unit();
        foreach (Unit u in CurrentGame.game.storeroom.units)
        {
            if (unitID == u.unitID) return u;
        }
        return me;
    }

    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width / 2, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        if (currentMenu == Menu.HomeMenu)
        {

            GUILayout.Box("Shop");
            GUILayout.Space(10);

            if (GUILayout.Button("Select Skill"))
            {
                currentMenu = Menu.SkillSelection;
            }
            if (GUILayout.Button("Use Item"))
            {
                currentMenu = Menu.Items;
            }

            GUILayout.Space(10);
            if (GUILayout.Button("Exit Menu"))
            {
                menuPar.SetActive(false);
            }
        }


        else if (currentMenu == Menu.SkillSelection)
        {

            GUILayout.BeginArea(new Rect(0, 0, Screen.width / 2, Screen.height / 2f));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            //  GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));

            turnCon = GameObject.FindObjectOfType<SpeedCenterTurns>();
            unitObj = turnCon.activeUnit;
            unit = unitObj.GetComponent<Stats>().FindMyself();
            attack = unitObj.GetComponent<MapPlayerAttack>();
            if (unit.unitInfo.main.pickSkill.skill1.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill1;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill1;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }

                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill2.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill2;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill2;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }

            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill3.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill3;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = u;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }

            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill4.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill4;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill4;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill5.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill5;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill5;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill6.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill6;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill6;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill7.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill7;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill7;
                        checking = true;

                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill8.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill8;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill8;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;

                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill9.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill9;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill9;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill10.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill10;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill10;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill11.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill11;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill11;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(3);
            if (unit.unitInfo.main.pickSkill.skill12.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill12;
                if (!checking)
                {
                    if (GUILayout.Button(u.name))
                    {
                        attack.currentAttack = unit.unitInfo.main.pickSkill.skill12;
                        checking = true;
                    }
                    if (u.physicalDamage) GUILayout.Label("Physical Damage");
                    if (u.magicDamage) GUILayout.Label("Magic Damage");
                    if (u.effects.poison) GUILayout.Label("Poison");
                    if (u.effects.fireDamage) GUILayout.Label("Fire Damage");
                }
                else if (attack.currentAttack == u)
                {
                    if (GUILayout.Button("Yes use " + u.name))
                    {
                        attack.UniqueAttack();
                        checking = false;
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                    if (GUILayout.Button("No"))
                    {
                        attack.currentAttack = empty;
                        checking = false;
                    }

                }
            }
            GUILayout.Space(10);
            if (GUILayout.Button("Exit Menu"))
            {
                checking = false;
                attack.currentAttack = empty;
                currentMenu = Menu.HomeMenu;
                menuPar.SetActive(false);

            }
            GUILayout.Label("", GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }



        else if (currentMenu == Menu.Items)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width / 2, Screen.height / 2f));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));

            turnCon = GameObject.FindObjectOfType<SpeedCenterTurns>();
            unitObj = turnCon.activeUnit;
            unit = unitObj.GetComponent<Stats>().FindMyself();
            attack = unitObj.GetComponent<MapPlayerAttack>();
            EquipmentOwned e = CurrentGame.game.memoryGeneral.itemsOwned;
            ItemHolder potionSmall = CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Potion Small");
            ItemHolder potionLarge = CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Potion Large");
            ItemHolder chestKey = CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Chest Key");
            ItemHolder doorKey = CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Door Key");
            if (potionSmall.count > 0)
            {
                if (GUILayout.Button("Potion Small " + "x " + potionSmall.count))
                {
                    unitObj.GetComponent<Stats>().currentHp += potionSmall.effects.effectBase;
                    unitObj.GetComponent<Stats>().HealHp(potionSmall.effects.effectBase);
                    unitObj.GetComponent<Stats>().UpdateHp();
                    CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Potion Small").count--;
                    attack.AssignMe();
                    MapManager manager = GameObject.FindObjectOfType<MapManager>();
                    manager.PlayerSkill();
                    currentMenu = Menu.HomeMenu;
                    menuPar.SetActive(false);
                }

            }
            else
            {
                GUILayout.Label("Potion Small x 0");
            }

            if (potionLarge.count > 0)
            {
                if (GUILayout.Button("Potion Large " + "x " + potionLarge.count))
                {
                    unitObj.GetComponent<Stats>().currentHp += potionLarge.effects.effectBase;
                    unitObj.GetComponent<Stats>().HealHp(potionLarge.effects.effectBase);
                    unitObj.GetComponent<Stats>().UpdateHp();
                    CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Potion Large").count--;
                    attack.AssignMe();
                    MapManager manager = GameObject.FindObjectOfType<MapManager>();
                    manager.PlayerSkill();
                    currentMenu = Menu.HomeMenu;
                    menuPar.SetActive(false);
                }

            }
            else
            {
                GUILayout.Label("Potion Lagre x 0");
            }

            if (chestKey.count > 0)
            {
                if (SomethingClose("Chest", unitObj))
                {
                    if (GUILayout.Button("Chest Key " + "x " + chestKey.count))
                    {

                        float nextTo = 1.9f;
                        List<GameObject> newTargets = new List<GameObject>();
                        gotChest.Clear();
                        AssignArray(newTargets, "Chest");
                        foreach (GameObject obj in newTargets)
                        {
                            float d = Vector3.Distance(GameObject.Find(unitObj.name).transform.position, obj.transform.position);
                            Debug.Log(d + " the space between us");
                            if (nextTo >= d) gotChest.Add(obj);
                        }
                    }           
                }
                else
                {
                    GUILayout.Box("No Nearby Chests");
                    GUILayout.Label("Chest Key " + "x " + chestKey.count);
                }

            }
            else
            {
                GUILayout.Label("Chest Key x 0");
            }
            if (gotChest.Count > 0)
            {
                foreach (GameObject obj in gotChest)
                {
                    if (GUILayout.Button("Open Chest " + obj.name))
                    {
                        obj.GetComponent<ChestRewards>().RandomReward();
                        CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Chest Key").count--;
                        attack.AssignMe();
                        MapManager manager = GameObject.FindObjectOfType<MapManager>();
                        manager.PlayerSkill();
                        gotChest.Clear();
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                }
                if (GUILayout.Button("Dont Use Key"))
                {
                    gotChest.Clear();
                }
            }

            if (doorKey.count > 0)
            {
                if (SomethingClose("Door", unitObj))
                {
                    if (GUILayout.Button("Door Key " + "x " + doorKey.count))
                    {
                        float nextTo = 1.9f;
                        List<GameObject> newTargets = new List<GameObject>();
                        gotDoor.Clear();
                        AssignArray(newTargets, "Door");
                        foreach (GameObject obj in newTargets)
                        {
                            float d = Vector3.Distance(GameObject.Find(unitObj.name).transform.position, obj.transform.position);
                            Debug.Log(d + " the space between us now");
                            if (nextTo >= d)
                            {
                                Debug.Log("Success now");
                                gotDoor.Add(obj);
                            }
                        }
                     
                    }
                  
                }
                else
                {
                    GUILayout.Box("No Nearby Doors");
                    GUILayout.Label("Door Key " + "x " + chestKey.count);
                }

            }
            else
            {
                GUILayout.Label("Door Key x 0");
            }
            if (gotDoor.Count > 0)
            {
                foreach (GameObject obj in gotDoor)
                {
                    if (GUILayout.Button("Open Door " + obj.name))
                    {
                        obj.GetComponent<LockedDoors>().OpenTheWay();
                        CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Door Key").count--;
                        attack.AssignMe();
                        MapManager manager = GameObject.FindObjectOfType<MapManager>();
                        manager.PlayerSkill();
                        gotDoor.Clear();
                        currentMenu = Menu.HomeMenu;
                        menuPar.SetActive(false);
                    }
                }
                if (GUILayout.Button("Dont Use Key"))
                {
                    gotDoor.Clear();
                }


            }
            GUILayout.Space(10);
            if (GUILayout.Button("Exit Menu"))
            {
                checking = false;
                currentMenu = Menu.HomeMenu;
                menuPar.SetActive(false);

            }
            GUILayout.Label("", GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
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

    
    void AssignArray(List<GameObject> list, string me)
    {
        list.AddRange(GameObject.FindGameObjectsWithTag(me));
    }

    bool SomethingClose(string me, GameObject you)
    {
        float nextTo = 1.9f;
        List<GameObject> newTargets = new List<GameObject>();
        AssignArray(newTargets, me);
        foreach (GameObject obj in newTargets)
        {
            float d = Vector3.Distance(GameObject.Find(you.name).transform.position, obj.transform.position);
            Debug.Log(d + " the space between us grows " + obj.name + " " + obj.transform.position);
            if (nextTo >= d) return true;
        }
        return false;

    }

}
