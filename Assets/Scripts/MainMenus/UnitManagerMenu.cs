﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnitManagerMenu : MonoBehaviour {

    public enum Menu
    {
        UnitMenu,
        Inventory,
        ClassChange,
        WeaponOrAssessory,
        WeaponList,
        AssessoryList,
        finalize,
        Human,
        Imp
    }

    public Menu currentMenu;
    public GameObject menuPar;
    public List<Sprite> sprite;
    public List<Sprite> spritem;
    public Unit unit;
    public bool slot1;
    public bool slot2;
    public bool slot3;
    public bool slot4;
    public bool slot5;
    public Image image;
    public DisplayStats stats;
    public bool done = false;
    public Texture2D texture;
    public Texture2D texture2;
    public Texture2D perm;
    Vector2 scrollPosition;

    void Start()
    {
       // spritem = new List<Sprite>();
       // spritem.AddRange(Resources.LoadAll<Sprite>("Actor_FW01"));
       // foreach (Sprite i in spritem)
       // {
          //  Debug.Log(i.name);
       // }
       // image.sprite = spritem.Find(x => x.name == "Dude");
       // perm = new Texture2D((int)image.sprite.rect.width, (int)image.sprite.rect.height);

        sprite = new List<Sprite>();
    }

    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();
        

        if (currentMenu == Menu.UnitMenu)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));

            GUILayout.Box("Unit Menu");

            foreach (Unit u in CurrentGame.game.memoryGeneral.unitsInRoster)
            {
                GUILayout.Box(u.unitID);
                if (GUILayout.Button("Inventory"))
                {
                    unit = u;
                 
                    currentMenu = Menu.Inventory;
                }
                if (GUILayout.Button("Class") )
                {
                    unit = u;
                    
                    stats.unitID = unit.unitID;
                    stats.StartUp();             
                    currentMenu = Menu.ClassChange;
                }
                GUILayout.Space(5);
            }
            GUILayout.Space(10);
            if (GUILayout.Button("Exit Menu"))
            {
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



        else if(currentMenu == Menu.ClassChange)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 1.5f), GUILayout.Height(Screen.height * 1.5f));
       
           
            /*var croppedTexture = new Texture2D((int)image.sprite.rect.width, (int)image.sprite.rect.height);
            if (!done)
            {
                stats.StartUp();
                done = true;

                GUILayout.Box(unit.unitID);
                sprite.AddRange(Resources.LoadAll<Sprite>("Actor_FW01"));
                foreach (Sprite i in sprite)
                {
                    Debug.Log(i.name);
                }


                image.sprite = sprite.Find(x => x.name == unit.unitInfo.mugName);
               
                var pixels = image.sprite.texture.GetPixels((int)image.sprite.rect.x,
                                                        (int)image.sprite.rect.y,
                                                        (int)image.sprite.rect.width,
                                                        (int)image.sprite.rect.height);
                croppedTexture.SetPixels(pixels);
                croppedTexture.Apply();
                perm = croppedTexture;
            }
            GUILayout.Box(perm);*/
            GUILayout.Label(unit.unitClass.main.mainClass + " Level " + unit.unitInfo.main.level);
            GUILayout.Label(unit.unitClass.main.race);
            GUILayout.Label("str: " + stats.str  + " def: " + stats.def + " spd: " + stats.spd + " skill: " + stats.skill + " magic: "  + stats.magic + " will: " + stats.will);
            GUILayout.Label("Skills");
            if (unit.unitInfo.main.pickSkill.skill1.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill1;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill2.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill2;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill3.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill3;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill4.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill4;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill5.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill5;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill6.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill6;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill7.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill7;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill8.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill8;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill9.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill9;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill10.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill10;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill11.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill11;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            if (unit.unitInfo.main.pickSkill.skill12.name != "")
            {
                UnitSkillDetail u = unit.unitInfo.main.pickSkill.skill12;
                GUILayout.Label("Has Skill " + u.name);
                GUILayout.Space(1);
            }
            GUILayout.Space(1);
            GUILayout.Label("Inventory");
            GUILayout.Space(1);
            GUILayout.Box("Slot 1: " + unit.inventory.invSlot1.holding);
            if (unit.inventory.invSlot1.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot1.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (unit.inventory.invSlot1.holding != "")
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
            GUILayout.Space(3);
            GUILayout.Box("Slot 2: " + unit.inventory.invSlot2.holding);
            if (unit.inventory.invSlot2.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot2.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (unit.inventory.invSlot2.holding != "")
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
            GUILayout.Space(3);
            GUILayout.Box("Slot 3: " + unit.inventory.invSlot3.holding);
            if (unit.inventory.invSlot3.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot3.assessory.equipped) GUILayout.Label("Equipped Assessory");         
            if (unit.inventory.invSlot3.holding != "")
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
            GUILayout.Space(3);
            GUILayout.Box("Slot 4: " + unit.inventory.invSlot4.holding);
            if (unit.inventory.invSlot4.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot4.assessory.equipped) GUILayout.Label("Equipped Assessory");     
            if (unit.inventory.invSlot4.holding != "")
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
            GUILayout.Space(3);
            GUILayout.Box("Slot 5: " + unit.inventory.invSlot5.holding);
            if (unit.inventory.invSlot5.weapon.equipped) GUILayout.Label("Equipped Weapon");
            if (unit.inventory.invSlot5.assessory.equipped) GUILayout.Label("Equipped Assessory");
            if (unit.inventory.invSlot5.holding != "")
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

            if (unit.unitInfo.human)
            {


                if (unit.unitClass.main.human.warrior.unlocked)
                {


                    if (unit.unitClass.main.mainClass != "Warrior")
                    {
                        if (GUILayout.Button("Switch to Warrior"))
                        {
                            UnsignOldClass(unit);

                            unit.unitClass.main.human.warrior.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.modifiers;
                            unit.unitClass.main.human.warrior.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.classWeapons;
                            unit.unitClass.main.human.warrior.caps = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.caps;

                            unit.unitClass.main.human.warrior.level = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level;
                            unit.unitClass.main.human.warrior.movement = CurrentGame.game.memoryGeneral.humanClassProgress.warrior.movement;
                            unit.unitClass.main.mainClass = "Warrior";
                            unit.unitInfo.main = unit.unitClass.main.human.warrior;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.warrior);
                            CurrentGame.game.memoryGeneral.humanClassProgress.warrior.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.warrior.movement +
                           " Has Learned  " + (WarriorLoader.HowManySkills(unit.unitClass.main.human.cavalier.pickSkill)) + " Skills");
                    }
                    else
                    {

                        GUILayout.Box("Currently Your a Warrior" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.warrior.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.warrior.movement);
                        GUILayout.Box("Has Learned " + (WarriorLoader.HowManySkills(unit.unitClass.main.human.warrior.pickSkill)) + " Skills");
                        
                    }
                }
                if (unit.unitClass.main.human.rogue.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Rogue")
                    {
                        if (GUILayout.Button("Switch to Rogue"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.rogue.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.modifiers;
                            unit.unitClass.main.human.rogue.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.classWeapons;
                            unit.unitClass.main.human.rogue.caps = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.caps;
                            unit.unitClass.main.human.rogue.level = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level;
                            unit.unitClass.main.human.rogue.movement = CurrentGame.game.memoryGeneral.humanClassProgress.rogue.movement;
                            unit.unitInfo.main = unit.unitClass.main.human.rogue;
                            unit.unitClass.main.mainClass = "Rogue";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.rogue);
                            CurrentGame.game.memoryGeneral.humanClassProgress.rogue.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label("Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.rogue.movement +
                           " Has Learned  " + (RogueLoader.HowManySkills(unit.unitClass.main.human.rogue.pickSkill) + 1) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Rogue" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.rogue.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.rogue.movement);
                        GUILayout.Box("Has Learned " + (RogueLoader.HowManySkills(unit.unitClass.main.human.rogue.pickSkill)) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.mage.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Mage")
                    {
                        if (GUILayout.Button("Switch to Mage"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.mage.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.mage.modifiers;
                            unit.unitClass.main.human.mage.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.mage.classWeapons;
                            unit.unitClass.main.human.mage.caps = CurrentGame.game.memoryGeneral.humanClassProgress.mage.caps;
                            unit.unitClass.main.human.mage.level = CurrentGame.game.memoryGeneral.humanClassProgress.mage.level;
                            unit.unitClass.main.human.mage.movement = CurrentGame.game.memoryGeneral.humanClassProgress.mage.movement;
                            unit.unitInfo.main = unit.unitClass.main.human.mage;
                            unit.unitClass.main.mainClass = "Mage";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.mage);
                            CurrentGame.game.memoryGeneral.humanClassProgress.mage.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.mage.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.mage.movement +
                           " Has Learned  " + (MageLoader.HowManySkills(unit.unitClass.main.human.mage.pickSkill)) + " Skills");
                    }
                    else
                    {

                        GUILayout.Box("Currently Your a Mage" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.mage.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.mage.movement);
                        GUILayout.Box("Has Learned " + (MageLoader.HowManySkills(unit.unitClass.main.human.mage.pickSkill)) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.archer.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Archer")
                    {
                        if (GUILayout.Button("Switch to Archer"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.archer.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.archer.modifiers;
                            unit.unitClass.main.human.archer.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.archer.classWeapons;
                            unit.unitClass.main.human.archer.caps = CurrentGame.game.memoryGeneral.humanClassProgress.archer.caps;
                            unit.unitClass.main.human.archer.level = CurrentGame.game.memoryGeneral.humanClassProgress.archer.level;
                            unit.unitClass.main.human.archer.movement = CurrentGame.game.memoryGeneral.humanClassProgress.archer.movement;
                            unit.unitInfo.weaponRanks.Ranged.canUse = true;
                            unit.unitInfo.weaponRanks.Ranged.rank = CurrentGame.game.memoryGeneral.humanClassProgress.archer.classWeapons.classWeapon1.rank;
                            unit.unitInfo.main = unit.unitClass.main.human.archer;
                            unit.unitClass.main.mainClass = "Archer";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.archer);
                            CurrentGame.game.memoryGeneral.humanClassProgress.archer.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.archer.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.archer.movement +
                           " Has Learned  " + ArcherLoader.HowManySkills(unit.unitClass.main.human.archer.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Archer" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.archer.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.archer.movement);
                        GUILayout.Box("Has Learned " + ArcherLoader.HowManySkills(unit.unitClass.main.human.archer.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.cavalier.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Cavalier")
                    {
                        if (GUILayout.Button("Switch to Cavalier"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.cavalier.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.modifiers;
                            unit.unitClass.main.human.cavalier.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.classWeapons;
                            unit.unitClass.main.human.cavalier.caps = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.caps;
                            unit.unitClass.main.human.cavalier.level = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level;
                            unit.unitClass.main.human.cavalier.movement = CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.movement;
                            unit.unitInfo.main = unit.unitClass.main.human.cavalier;
                            unit.unitClass.main.mainClass = "Cavalier";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.cavalier);
                            CurrentGame.game.memoryGeneral.humanClassProgress.archer.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.movement +
                           " Has Learned  " + CavalierLoader.HowManySkills(unit.unitClass.main.human.cavalier.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Cavalier" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.movement);
                        GUILayout.Box("Has Learned " + CavalierLoader.HowManySkills(unit.unitClass.main.human.cavalier.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.bard.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Bard")
                    {
                        if (GUILayout.Button("Switch to Bard"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.bard.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.bard.modifiers;
                            unit.unitClass.main.human.bard.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.bard.classWeapons;
                            unit.unitClass.main.human.bard.caps = CurrentGame.game.memoryGeneral.humanClassProgress.bard.caps;
                            unit.unitClass.main.human.bard.level = CurrentGame.game.memoryGeneral.humanClassProgress.bard.level;
                            unit.unitClass.main.human.bard.movement = CurrentGame.game.memoryGeneral.humanClassProgress.bard.movement;
                            unit.unitClass.main.mainClass = "Bard";
                            unit.unitInfo.main = unit.unitClass.main.human.bard;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.bard);
                            CurrentGame.game.memoryGeneral.humanClassProgress.bard.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.bard.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.bard.movement +
                           " Has Learned  " + BardLoader.HowManySkills(unit.unitClass.main.human.bard.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Bard" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.bard.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.bard.movement);
                        GUILayout.Box("Has Learned " + BardLoader.HowManySkills(unit.unitClass.main.human.bard.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.charger.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Charger")
                    {
                        if (GUILayout.Button("Switch to Charger"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.charger.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.charger.modifiers;
                            unit.unitClass.main.human.charger.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.charger.classWeapons;
                            unit.unitClass.main.human.charger.caps = CurrentGame.game.memoryGeneral.humanClassProgress.charger.caps;
                            unit.unitClass.main.human.charger.level = CurrentGame.game.memoryGeneral.humanClassProgress.charger.level;
                            unit.unitClass.main.human.charger.movement = CurrentGame.game.memoryGeneral.humanClassProgress.charger.movement;
                            unit.unitClass.main.mainClass = "Charger";
                            unit.unitInfo.main = unit.unitClass.main.human.charger;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.charger);
                            CurrentGame.game.memoryGeneral.humanClassProgress.charger.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.charger.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.charger.movement +
                           " Has Learned  " + BardLoader.HowManySkills(unit.unitClass.main.human.charger.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Charger" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.charger.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.charger.movement);
                        GUILayout.Box("Has Learned " + BardLoader.HowManySkills(unit.unitClass.main.human.charger.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.knight.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Knight")
                    {
                        if (GUILayout.Button("Switch to Knight"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.knight.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.knight.modifiers;
                            unit.unitClass.main.human.knight.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.knight.classWeapons;
                            unit.unitClass.main.human.knight.caps = CurrentGame.game.memoryGeneral.humanClassProgress.knight.caps;
                            unit.unitClass.main.human.knight.level = CurrentGame.game.memoryGeneral.humanClassProgress.knight.level;
                            unit.unitClass.main.human.knight.movement = CurrentGame.game.memoryGeneral.humanClassProgress.knight.movement;
                            unit.unitClass.main.mainClass = "Knight";
                            unit.unitInfo.main = unit.unitClass.main.human.knight;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.knight);
                            CurrentGame.game.memoryGeneral.humanClassProgress.knight.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.knight.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.knight.movement +
                           " Has Learned  " + BardLoader.HowManySkills(unit.unitClass.main.human.knight.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Knight" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.knight.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.knight.movement);
                        GUILayout.Box("Has Learned " + BardLoader.HowManySkills(unit.unitClass.main.human.knight.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.paladin.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Paladin")
                    {
                        if (GUILayout.Button("Switch to Paladin"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.paladin.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.modifiers;
                            unit.unitClass.main.human.paladin.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.classWeapons;
                            unit.unitClass.main.human.paladin.caps = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.caps;
                            unit.unitClass.main.human.paladin.level = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level;
                            unit.unitClass.main.human.paladin.movement = CurrentGame.game.memoryGeneral.humanClassProgress.paladin.movement;
                            unit.unitClass.main.mainClass = "Paladin";
                            unit.unitInfo.main = unit.unitClass.main.human.paladin;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.paladin);
                            CurrentGame.game.memoryGeneral.humanClassProgress.paladin.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.paladin.movement +
                           " Has Learned  " + BardLoader.HowManySkills(unit.unitClass.main.human.paladin.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Paladin" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.paladin.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.paladin.movement);
                        GUILayout.Box("Has Learned " + BardLoader.HowManySkills(unit.unitClass.main.human.paladin.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.sniper.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Sniper")
                    {
                        if (GUILayout.Button("Switch to Sniper"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.sniper.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.modifiers;
                            unit.unitClass.main.human.sniper.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.classWeapons;
                            unit.unitClass.main.human.sniper.caps = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.caps;
                            unit.unitClass.main.human.sniper.level = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level;
                            unit.unitClass.main.human.sniper.movement = CurrentGame.game.memoryGeneral.humanClassProgress.sniper.movement;
                            unit.unitClass.main.mainClass = "Sniper";
                            unit.unitInfo.main = unit.unitClass.main.human.sniper;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.sniper);
                            CurrentGame.game.memoryGeneral.humanClassProgress.sniper.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.sniper.movement +
                           " Has Learned  " + BardLoader.HowManySkills(unit.unitClass.main.human.sniper.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Sniper" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.sniper.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.sniper.movement);
                        GUILayout.Box("Has Learned " + BardLoader.HowManySkills(unit.unitClass.main.human.sniper.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.human.assassin.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Assassin")
                    {
                        if (GUILayout.Button("Switch to Assassin"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.human.assassin.modifiers = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.modifiers;
                            unit.unitClass.main.human.assassin.classWeapons = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.classWeapons;
                            unit.unitClass.main.human.assassin.caps = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.caps;
                            unit.unitClass.main.human.assassin.level = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level;
                            unit.unitClass.main.human.assassin.movement = CurrentGame.game.memoryGeneral.humanClassProgress.assassin.movement;
                            unit.unitClass.main.mainClass = "Assassin";
                            unit.unitInfo.main = unit.unitClass.main.human.assassin;
                            UnequipNonClassWeapons(unit, unit.unitClass.main.human.assassin);
                            CurrentGame.game.memoryGeneral.humanClassProgress.assassin.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level +
                        " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.assassin.movement +
                           " Has Learned  " + BardLoader.HowManySkills(unit.unitClass.main.human.assassin.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Assassin" + " Level: " + CurrentGame.game.memoryGeneral.humanClassProgress.assassin.level +
                       " Movement " + CurrentGame.game.memoryGeneral.humanClassProgress.assassin.movement);
                        GUILayout.Box("Has Learned " + BardLoader.HowManySkills(unit.unitClass.main.human.assassin.pickSkill) + " Skills");
                    }
                }
             
            }
            if (unit.unitInfo.imp)
            {
                if (unit.unitClass.main.imp.dread.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Dread")
                    {
                        if (GUILayout.Button("Switch to Dread"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.dread.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.dread.modifiers;
                            unit.unitClass.main.imp.dread.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.dread.classWeapons;
                            unit.unitClass.main.imp.dread.caps = CurrentGame.game.memoryGeneral.impClassProgress.dread.caps;
                            unit.unitClass.main.imp.dread.level = CurrentGame.game.memoryGeneral.impClassProgress.dread.level;
                            unit.unitClass.main.imp.dread.movement = CurrentGame.game.memoryGeneral.impClassProgress.dread.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.dread;
                            unit.unitClass.main.mainClass = "Dread";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.dread);
                            CurrentGame.game.memoryGeneral.impClassProgress.dread.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.dread.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.dread.movement +
                           " Has Learned  " + DreadLoader.HowManySkills(unit.unitClass.main.imp.dread.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Dread" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.dread.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.dread.movement);
                        GUILayout.Box("Has Learned " + DreadLoader.HowManySkills(unit.unitClass.main.imp.dread.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.fusilier.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Fusilier")
                    {
                        if (GUILayout.Button("Switch to Fusilier"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.fusilier.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.modifiers;
                            unit.unitClass.main.imp.fusilier.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.classWeapons;
                            unit.unitClass.main.imp.fusilier.caps = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.caps;
                            unit.unitClass.main.imp.fusilier.level = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level;
                            unit.unitClass.main.imp.fusilier.movement = CurrentGame.game.memoryGeneral.impClassProgress.fusilier.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.fusilier;
                            unit.unitClass.main.mainClass = "Fusilier";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.fusilier);
                            CurrentGame.game.memoryGeneral.impClassProgress.fusilier.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.fusilier.movement +
                           " Has Learned  " + FusilierLoader.HowManySkills(unit.unitClass.main.imp.fusilier.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Fusilier" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.fusilier.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.fusilier.movement);
                        GUILayout.Box("Has Learned " + FusilierLoader.HowManySkills(unit.unitClass.main.imp.fusilier.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.shadow.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Shadow")
                    {
                        if (GUILayout.Button("Switch to Shadow"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.shadow.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.shadow.modifiers;
                            unit.unitClass.main.imp.shadow.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.shadow.classWeapons;
                            unit.unitClass.main.imp.shadow.caps = CurrentGame.game.memoryGeneral.impClassProgress.shadow.caps;
                            unit.unitClass.main.imp.shadow.level = CurrentGame.game.memoryGeneral.impClassProgress.shadow.level;
                            unit.unitClass.main.imp.shadow.movement = CurrentGame.game.memoryGeneral.impClassProgress.shadow.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.shadow;
                            unit.unitClass.main.mainClass = "Shadow";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.shadow);
                            CurrentGame.game.memoryGeneral.impClassProgress.shadow.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.shadow.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.shadow.movement +
                           " Has Learned  " + ShadowLoader.HowManySkills(unit.unitClass.main.imp.shadow.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Shadow" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.shadow.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.shadow.movement);
                        GUILayout.Box("Has Learned " + ShadowLoader.HowManySkills(unit.unitClass.main.imp.shadow.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.shrike.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Shrike")
                    {
                        if (GUILayout.Button("Switch to Shrike"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.shrike.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.shrike.modifiers;
                            unit.unitClass.main.imp.shrike.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.shrike.classWeapons;
                            unit.unitClass.main.imp.shrike.caps = CurrentGame.game.memoryGeneral.impClassProgress.shrike.caps;
                            unit.unitClass.main.imp.shrike.level = CurrentGame.game.memoryGeneral.impClassProgress.shrike.level;
                            unit.unitClass.main.imp.shrike.movement = CurrentGame.game.memoryGeneral.impClassProgress.shrike.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.shrike;
                            unit.unitClass.main.mainClass = "Shrike";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.shrike);
                            CurrentGame.game.memoryGeneral.impClassProgress.shrike.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.shrike.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.shrike.movement +
                           " Has Learned  " + ShrikeLoader.HowManySkills(unit.unitClass.main.imp.shrike.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Shrike" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.shrike.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.shrike.movement);
                        GUILayout.Box("Has Learned " + ShrikeLoader.HowManySkills(unit.unitClass.main.imp.shrike.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.swashbuckler.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Swashbulkler")
                    {
                        if (GUILayout.Button("Switch to Swashbulkler"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.swashbuckler.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.modifiers;
                            unit.unitClass.main.imp.swashbuckler.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.classWeapons;
                            unit.unitClass.main.imp.swashbuckler.caps = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.caps;
                            unit.unitClass.main.imp.swashbuckler.level = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level;
                            unit.unitClass.main.imp.swashbuckler.movement = CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.swashbuckler;
                            unit.unitClass.main.mainClass = "Swashbulkler";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.swashbuckler);
                            CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.subbed.Add(unit.idx);
                            stats.RefreshIt();

                            GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level +
                        " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.movement +
                           " Has Learned  " + SwashbucklerLoader.HowManySkills(unit.unitClass.main.imp.swashbuckler.pickSkill) + " Skills");
                        }
                        else
                        {
                            GUILayout.Box("Currently Your a Swashbulkler" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.level +
                            " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.movement);
                            GUILayout.Box("Has Learned " + SwashbucklerLoader.HowManySkills(unit.unitClass.main.imp.swashbuckler.pickSkill) + " Skills");
                        }
                    }            
                }
                if (unit.unitClass.main.imp.duelist.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Duelist")
                    {
                        if (GUILayout.Button("Switch to Duelist"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.duelist.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.duelist.modifiers;
                            unit.unitClass.main.imp.duelist.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.duelist.classWeapons;
                            unit.unitClass.main.imp.duelist.caps = CurrentGame.game.memoryGeneral.impClassProgress.duelist.caps;
                            unit.unitClass.main.imp.duelist.level = CurrentGame.game.memoryGeneral.impClassProgress.duelist.level;
                            unit.unitClass.main.imp.duelist.movement = CurrentGame.game.memoryGeneral.impClassProgress.duelist.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.duelist;
                            unit.unitClass.main.mainClass = "Duelist";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.duelist);
                            CurrentGame.game.memoryGeneral.impClassProgress.duelist.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.duelist.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.duelist.movement +
                           " Has Learned  " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.duelist.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Duelist" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.duelist.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.duelist.movement);
                        GUILayout.Box("Has Learned " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.duelist.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.cannoneer.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Cannoneer")
                    {
                        if (GUILayout.Button("Switch to Cannoneer"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.cannoneer.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.modifiers;
                            unit.unitClass.main.imp.cannoneer.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.classWeapons;
                            unit.unitClass.main.imp.cannoneer.caps = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.caps;
                            unit.unitClass.main.imp.cannoneer.level = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level;
                            unit.unitClass.main.imp.cannoneer.movement = CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.cannoneer;
                            unit.unitClass.main.mainClass = "Cannoneer";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.cannoneer);
                            CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.movement +
                           " Has Learned  " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.cannoneer.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Cannoneer" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.cannoneer.movement);
                        GUILayout.Box("Has Learned " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.cannoneer.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.darkknight.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Dark Knight")
                    {
                        if (GUILayout.Button("Switch to Dark Knight"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.darkknight.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.modifiers;
                            unit.unitClass.main.imp.darkknight.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.classWeapons;
                            unit.unitClass.main.imp.darkknight.caps = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.caps;
                            unit.unitClass.main.imp.darkknight.level = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level;
                            unit.unitClass.main.imp.darkknight.movement = CurrentGame.game.memoryGeneral.impClassProgress.darkknight.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.darkknight;
                            unit.unitClass.main.mainClass = "Dark Knight";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.darkknight);
                            CurrentGame.game.memoryGeneral.impClassProgress.darkknight.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.darkknight.movement +
                           " Has Learned  " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.darkknight.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Dark Knight" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.darkknight.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.darkknight.movement);
                        GUILayout.Box("Has Learned " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.darkknight.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.demonRider.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Demon Rider")
                    {
                        if (GUILayout.Button("Switch to Demon Rider"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.demonRider.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.modifiers;
                            unit.unitClass.main.imp.demonRider.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.classWeapons;
                            unit.unitClass.main.imp.demonRider.caps = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.caps;
                            unit.unitClass.main.imp.demonRider.level = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level;
                            unit.unitClass.main.imp.demonRider.movement = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.demonRider;
                            unit.unitClass.main.mainClass = "Demon Rider";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.demonRider);
                            CurrentGame.game.memoryGeneral.impClassProgress.demonRider.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement +
                           " Has Learned  " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.demonRider.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Demon Rider" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement);
                        GUILayout.Box("Has Learned " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.demonRider.pickSkill) + " Skills");
                    }
                }
                if (unit.unitClass.main.imp.nightblade.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Night Blade")
                    {
                        if (GUILayout.Button("Switch to Night Blade"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.imp.demonRider.modifiers = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.modifiers;
                            unit.unitClass.main.imp.demonRider.classWeapons = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.classWeapons;
                            unit.unitClass.main.imp.demonRider.caps = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.caps;
                            unit.unitClass.main.imp.demonRider.level = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level;
                            unit.unitClass.main.imp.demonRider.movement = CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement;
                            unit.unitInfo.main = unit.unitClass.main.imp.demonRider;
                            unit.unitClass.main.mainClass = "Night Blade";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.imp.demonRider);
                            CurrentGame.game.memoryGeneral.impClassProgress.demonRider.subbed.Add(unit.idx);
                            stats.RefreshIt();
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement +
                           " Has Learned  " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.demonRider.pickSkill) + " Skills");
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Night Blade" + " Level: " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.level +
                       " Movement " + CurrentGame.game.memoryGeneral.impClassProgress.demonRider.movement);
                        GUILayout.Box("Has Learned " + DuelistLoader.HowManySkills(unit.unitClass.main.imp.demonRider.pickSkill) + " Skills");
                    }
                }
            }
            if (GUILayout.Button("Confirm & Exit"))
            {
                done = false;
                int num = CurrentGame.game.storeroom.units.FindIndex(x => x.unitID == unit.unitID);
                int num1 = CurrentGame.game.memoryGeneral.unitsInRoster.FindIndex(x => x.unitID == unit.unitID);
                CurrentGame.game.storeroom.units[num] = unit;
                CurrentGame.game.memoryGeneral.unitsInRoster[num1] = unit;
                stats.Clean();
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Space(5);
            if (GUILayout.Button("Cancel & Exit"))
            {
                done = false;
                stats.Clean();
                currentMenu = Menu.UnitMenu;
            }
            GUILayout.Label("", GUILayout.Width(Screen.width /2f), GUILayout.Height(Screen.height * 1.5f));
            GUILayout.EndScrollView();
            GUILayout.FlexibleSpace();
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndArea();
        }





        else if (currentMenu == Menu.Inventory)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.BeginVertical();
            GUILayout.FlexibleSpace();
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
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
                    if (CanEquip(unit, unit.unitInfo.main, "slot1"))
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
                    if (CanEquip(unit, unit.unitInfo.main, "slot2"))
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
                    if (CanEquip(unit, unit.unitInfo.main, "slot3"))
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
                    if (CanEquip(unit, unit.unitInfo.main, "slot4"))
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

            GUILayout.Box("Slot 5: " + unit.inventory.invSlot5.holding);
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
                    if (CanEquip(unit, unit.unitInfo.main, "slot5"))
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
            GUILayout.Label("", GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
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
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
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
            GUILayout.Label("", GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
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
            GUILayout.Space(10);
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, true, GUILayout.Width(Screen.width / 2f), GUILayout.Height(Screen.height * 1.5f));
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

    public void UnequipNonClassWeapons(Unit unit, UnitClassDetail unitClass)
    {
        if (unit.inventory.invSlot1.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot1.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
        {

        }
        else if (unit.inventory.invSlot1.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot1.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
        {

        }
        else
        {
            if (!UnitWeaponRankCheck(unit.inventory.invSlot1.weapon.details.type, unit.inventory.invSlot1.weapon.details.rank)) unit.inventory.invSlot1.weapon.equipped = false;
        }

        if (unit.inventory.invSlot2.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot2.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
        {

        }
        else if (unit.inventory.invSlot2.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot2.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
        {

        }
        else
        {
            if (!UnitWeaponRankCheck(unit.inventory.invSlot2.weapon.details.type, unit.inventory.invSlot2.weapon.details.rank)) unit.inventory.invSlot2.weapon.equipped = false;
        }

        if (unit.inventory.invSlot3.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot3.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
        {

        }
        else if (unit.inventory.invSlot3.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot3.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
        {

        }
        else
        {
            if (!UnitWeaponRankCheck(unit.inventory.invSlot3.weapon.details.type, unit.inventory.invSlot3.weapon.details.rank)) unit.inventory.invSlot3.weapon.equipped = false;
        }

        if (unit.inventory.invSlot4.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot4.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
        {

        }
        else if (unit.inventory.invSlot4.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot4.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
        {

        }
        else
        {
            if (!UnitWeaponRankCheck(unit.inventory.invSlot4.weapon.details.type, unit.inventory.invSlot4.weapon.details.rank)) unit.inventory.invSlot4.weapon.equipped = false;
        }

        if (unit.inventory.invSlot5.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot5.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
        {

        }
        else if (unit.inventory.invSlot5.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot5.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
        {

        }
        else
        {
            if (!UnitWeaponRankCheck(unit.inventory.invSlot5.weapon.details.type, unit.inventory.invSlot5.weapon.details.rank)) unit.inventory.invSlot5.weapon.equipped = false;
        }
    }


    public bool CanEquip(Unit unit, UnitClassDetail unitClass , string name)
    {
        if (name == "slot1")
        {
            if (unit.inventory.invSlot1.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot1.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
            {
                return true;
            }
            else if (unit.inventory.invSlot1.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot1.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
            {
                return true;
            }
            else
            {
                if (!UnitWeaponRankCheck(unit.inventory.invSlot1.weapon.details.type, unit.inventory.invSlot1.weapon.details.rank)) return false;
                else return true;
            }
        }

        if (name == "slot2")
        {
            if (unit.inventory.invSlot2.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot2.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
            {
                return true;
            }
            else if (unit.inventory.invSlot2.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot2.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
            {
                return true;
            }
            else
            {
                Debug.Log("what?");
                Debug.Log(unit.inventory.invSlot2.weapon.details.type);
                Debug.Log(unit.inventory.invSlot2.weapon.details.rank);
                if (!UnitWeaponRankCheck(unit.inventory.invSlot2.weapon.details.type, unit.inventory.invSlot2.weapon.details.rank)) return false;
                else return true;
            }
        }

        if (name == "slot3")
        {
            if (unit.inventory.invSlot3.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot3.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
            {
                return true;
            }
            else if (unit.inventory.invSlot3.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot3.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
            {
                return true;
            }
            else
            {
                if (!UnitWeaponRankCheck(unit.inventory.invSlot3.weapon.details.type, unit.inventory.invSlot3.weapon.details.rank)) return false;
                else return true;
            }
        }

        if (name == "slot4")
        {
            if (unit.inventory.invSlot4.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot4.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
            {
                return true;
            }
            else if (unit.inventory.invSlot4.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot4.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
            {
                return true;
            }
            else
            {
                if (!UnitWeaponRankCheck(unit.inventory.invSlot4.weapon.details.type, unit.inventory.invSlot4.weapon.details.rank)) return false;
                else return true;
            }
        }

        if (name == "slot5")
        {
            if (unit.inventory.invSlot5.weapon.details.type == unitClass.classWeapons.classWeapon1.type && unit.inventory.invSlot5.weapon.details.rank >= unitClass.classWeapons.classWeapon1.rank)
            {
                return true;
            }
            else if (unit.inventory.invSlot5.weapon.details.type == unitClass.classWeapons.classWeapon2.type && unit.inventory.invSlot5.weapon.details.rank >= unitClass.classWeapons.classWeapon2.rank)
            {
                return true;
            }
            else
            {
                if (!UnitWeaponRankCheck(unit.inventory.invSlot5.weapon.details.type, unit.inventory.invSlot5.weapon.details.rank)) return false;
                else return true;
            }
        }
        return false;
    }

    public bool UnitWeaponRankCheck(string name, int rank)
    {
        if (unit.unitInfo.weaponRanks.HeavyBlade.name == name)
        {
            if (unit.unitInfo.weaponRanks.HeavyBlade.canUse && unit.unitInfo.weaponRanks.HeavyBlade.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Spear.name == name)
        {
            if (unit.unitInfo.weaponRanks.Spear.canUse && unit.unitInfo.weaponRanks.Spear.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Stave.name == name)
        {
            if (unit.unitInfo.weaponRanks.Stave.canUse && unit.unitInfo.weaponRanks.Stave.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Tome.name == name)
        {
            if (unit.unitInfo.weaponRanks.Tome.canUse && unit.unitInfo.weaponRanks.Tome.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.LightBlades.name == name)
        {
            if (unit.unitInfo.weaponRanks.LightBlades.canUse && unit.unitInfo.weaponRanks.LightBlades.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Athames.name == name)
        {
            if (unit.unitInfo.weaponRanks.Athames.canUse && unit.unitInfo.weaponRanks.Athames.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Axe.name == name)
        {
            if (unit.unitInfo.weaponRanks.Axe.canUse && unit.unitInfo.weaponRanks.Axe.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Close.name == name)
        {
            if (unit.unitInfo.weaponRanks.Close.canUse && unit.unitInfo.weaponRanks.Close.rank <= rank) return true;
        }
        else if (unit.unitInfo.weaponRanks.Ranged.name == name)
        {
            if (unit.unitInfo.weaponRanks.Ranged.canUse && unit.unitInfo.weaponRanks.Ranged.rank <= rank) return true;
        }
        return false;
        //Axes, Heavy Blades, Light Blades, Close, Ranged, Tomes, Staves, Athames, Spears
    }

    public void UnsignOldClass(Unit unit)
    {
        if (unit.unitClass.main.mainClass == "Warrior")
        {
            CurrentGame.game.memoryGeneral.humanClassProgress.warrior.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Rogue")
        {
            CurrentGame.game.memoryGeneral.humanClassProgress.rogue.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Mage")
        {
            CurrentGame.game.memoryGeneral.humanClassProgress.mage.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Archer")
        {
            CurrentGame.game.memoryGeneral.humanClassProgress.archer.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Bard")
        {
            CurrentGame.game.memoryGeneral.humanClassProgress.bard.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Cavalier")
        {
            CurrentGame.game.memoryGeneral.humanClassProgress.cavalier.subbed.Remove(unit.idx);
        }


        if (unit.unitClass.main.mainClass == "Dread")
        {
            CurrentGame.game.memoryGeneral.impClassProgress.dread.subbed.Remove(unit.idx);
        }


        if (unit.unitClass.main.mainClass == "Fusilier")
        {
            CurrentGame.game.memoryGeneral.impClassProgress.fusilier.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Magus")
        {
            CurrentGame.game.memoryGeneral.impClassProgress.duelist.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Shadow")
        {
            CurrentGame.game.memoryGeneral.impClassProgress.shadow.subbed.Remove(unit.idx);
        }


        if (unit.unitClass.main.mainClass == "Shrike")
        {
            CurrentGame.game.memoryGeneral.impClassProgress.shrike.subbed.Remove(unit.idx);
        }


        if (unit.unitClass.main.mainClass == "Swashbulkler")
        {
            CurrentGame.game.memoryGeneral.impClassProgress.swashbuckler.subbed.Remove(unit.idx);
        }


    }
    /*  if (unit.unitClass.main.mainClass == "Chronos")
        {
            CurrentGame.game.memoryGeneral.viraClassProgress.chronos.subbed.Remove(unit.idx);

        }

        if (unit.unitClass.main.mainClass == "Alchemist")
        {
            CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.subbed.Remove(unit.idx);

        }

        if (unit.unitClass.main.mainClass == "Geomancer")
        {
            CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.subbed.Remove(unit.idx);

        }

        if (unit.unitClass.main.mainClass == "Kensai")
        {
            CurrentGame.game.memoryGeneral.viraClassProgress.kensai.subbed.Remove(unit.idx);

        }

        if (unit.unitClass.main.mainClass == "Onmiyoji")
        {
            CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.subbed.Remove(unit.idx);
        }

        if (unit.unitClass.main.mainClass == "Wardancer")
        {
            CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.subbed.Remove(unit.idx);
        }

     */
    /*
     *   if (unit.unitInfo.vira)
            {
                if (unit.unitClass.main.vira.chronos.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Chronos")
                    {
                        if (GUILayout.Button("Switch to Chronos"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.vira.chronos.modifiers = CurrentGame.game.memoryGeneral.viraClassProgress.chronos.modifiers;
                            unit.unitClass.main.vira.chronos.classWeapons = CurrentGame.game.memoryGeneral.viraClassProgress.chronos.classWeapons;
                            unit.unitClass.main.vira.chronos.caps = CurrentGame.game.memoryGeneral.viraClassProgress.chronos.caps;
                            unit.unitClass.main.vira.chronos.level = CurrentGame.game.memoryGeneral.viraClassProgress.chronos.level;
                            unit.unitInfo.main = unit.unitClass.main.vira.chronos;
                            unit.unitClass.main.mainClass = "Chronos";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.vira.chronos);
                            CurrentGame.game.memoryGeneral.viraClassProgress.chronos.subbed.Add(unit.idx);
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.chronos.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.chronos.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.chronos);
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Chronos" + " Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.chronos.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.chronos.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.chronos);
                    }
                }
                if (unit.unitClass.main.vira.alchemist.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Alchemist")
                    {
                        if (GUILayout.Button("Switch to Alchemist"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.vira.alchemist.modifiers = CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.modifiers;
                            unit.unitClass.main.vira.alchemist.classWeapons = CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.classWeapons;
                            unit.unitClass.main.vira.alchemist.caps = CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.caps;
                            unit.unitClass.main.vira.alchemist.level = CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.level;
                            unit.unitInfo.main = unit.unitClass.main.vira.alchemist;
                            unit.unitClass.main.mainClass = "Alchemist";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.vira.alchemist);
                            CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.subbed.Add(unit.idx);
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.level +
                       " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist);
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Alchemist" + " Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.level +
                       " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.alchemist);
                    }
                }
                if (unit.unitClass.main.vira.geomancer.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Geomancer")
                    {
                        if (GUILayout.Button("Switch to Geomancer"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.vira.geomancer.modifiers = CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.modifiers;
                            unit.unitClass.main.vira.geomancer.classWeapons = CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.classWeapons;
                            unit.unitClass.main.vira.geomancer.caps = CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.caps;
                            unit.unitClass.main.vira.geomancer.level = CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.level;
                            unit.unitInfo.main = unit.unitClass.main.vira.geomancer;
                            unit.unitClass.main.mainClass = "Geomancer";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.vira.geomancer);
                            CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.subbed.Add(unit.idx);
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.level +
                       " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer);
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Geomancer" + " Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.level +
                       " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.geomancer);
                    }
                }
                if (unit.unitClass.main.vira.kensai.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Kensai")
                    {
                        if (GUILayout.Button("Switch to Kensai"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.vira.kensai.modifiers = CurrentGame.game.memoryGeneral.viraClassProgress.kensai.modifiers;
                            unit.unitClass.main.vira.kensai.classWeapons = CurrentGame.game.memoryGeneral.viraClassProgress.kensai.classWeapons;
                            unit.unitClass.main.vira.kensai.caps = CurrentGame.game.memoryGeneral.viraClassProgress.kensai.caps;
                            unit.unitClass.main.vira.kensai.level = CurrentGame.game.memoryGeneral.viraClassProgress.kensai.level;
                            unit.unitInfo.main = unit.unitClass.main.vira.kensai;
                            unit.unitClass.main.mainClass = "Kensai";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.vira.kensai);
                            CurrentGame.game.memoryGeneral.viraClassProgress.kensai.subbed.Add(unit.idx);
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.kensai.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.kensai.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.kensai);
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Kensai" + " Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.kensai.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.kensai.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.kensai);
                    }
                }
                if (unit.unitClass.main.vira.onmiyoji.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Onmiyoji")
                    {
                        if (GUILayout.Button("Switch to Onmiyoji"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.vira.onmiyoji.modifiers = CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.modifiers;
                            unit.unitClass.main.vira.onmiyoji.classWeapons = CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.classWeapons;
                            unit.unitClass.main.vira.onmiyoji.caps = CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.caps;
                            unit.unitClass.main.vira.onmiyoji.level = CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.level;
                            unit.unitInfo.main = unit.unitClass.main.vira.onmiyoji;
                            unit.unitClass.main.mainClass = "Onmiyoji";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.vira.onmiyoji);
                            CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.subbed.Add(unit.idx);
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji);
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Onmiyoji" + " Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.onmiyoji);
                    }
                }
                if (unit.unitClass.main.vira.wardancer.unlocked)
                {
                    if (unit.unitClass.main.mainClass != "Wardancer")
                    {
                        if (GUILayout.Button("Switch to Wardancer"))
                        {
                            UnsignOldClass(unit);
                            unit.unitClass.main.vira.wardancer.modifiers = CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.modifiers;
                            unit.unitClass.main.vira.wardancer.classWeapons = CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.classWeapons;
                            unit.unitClass.main.vira.wardancer.caps = CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.caps;
                            unit.unitClass.main.vira.wardancer.level = CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.level;
                            unit.unitInfo.main = unit.unitClass.main.vira.wardancer;
                            unit.unitClass.main.mainClass = "Wardancer";
                            UnequipNonClassWeapons(unit, unit.unitClass.main.vira.wardancer);
                            CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.subbed.Add(unit.idx);
                        }
                        GUILayout.Label(" Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.movement); // + CurrentGame.game.memoryGeneral.viraClassProgress.wardancer);
                    }
                    else
                    {
                        GUILayout.Box("Currently Your a Wardancer" + " Level: " + CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.level +
                        " Movement " + CurrentGame.game.memoryGeneral.viraClassProgress.wardancer.movement); //+ CurrentGame.game.memoryGeneral.viraClassProgress.wardancer);
                    }
                }
              
            }
     */
}
