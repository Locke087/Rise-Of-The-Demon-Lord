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

    void Start()
    {
        empty = new UnitSkillDetail();
        checking = false;
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

            GUILayout.BeginArea(new Rect(0, 0, Screen.width/2, Screen.height/2f));
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
                        menuPar.SetActive(false);
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
                        menuPar.SetActive(false);
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
                        menuPar.SetActive(false);
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
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));

            turnCon = GameObject.FindObjectOfType<SpeedCenterTurns>();
            unitObj = turnCon.activeUnit;
            unit = unitObj.GetComponent<Stats>().FindMyself();
            EquipmentOwned e = CurrentGame.game.memoryGeneral.itemsOwned;
            ItemHolder potionSmall = CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Potion Small");

            if (potionSmall.count > 0)
            {
                if (GUILayout.Button("Potion Small"))
                {
                    unitObj.GetComponent<Stats>().currentHp += potionSmall.effects.effectBase;
                    CurrentGame.game.memoryGeneral.itemsOwned.items.Find(x => x.name == "Potion Small " + "x " + potionSmall.count).count--;
                }

            }
            else
            {
                GUILayout.Label("Potion Smalls x 0");
            }


            GUILayout.Space(10);
            if (GUILayout.Button("Exit Menu"))
            {
                checking = false;
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
}
