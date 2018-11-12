using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveMenu : MonoBehaviour {
    public enum Menu
    {
        SaveMenu,
        SaveGame,
        LoadGame,
        Delete
    }

    public Menu currentMenu;
    public GameObject menuPar;
    void OnGUI()
    {

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();
        GUILayout.FlexibleSpace();

        if (currentMenu == Menu.SaveMenu)
        {

            GUILayout.Box("Save Menu");
            GUILayout.Space(10);

            if (GUILayout.Button("Save Game"))
            {
                SaveLoad.Load();
                currentMenu = Menu.SaveGame;
            }

            if (GUILayout.Button("Load Game"))
            {
                SaveLoad.Load();
                currentMenu = Menu.LoadGame;
            }

            if (GUILayout.Button("Delete Save"))
            {
                SaveLoad.Load();
                currentMenu = Menu.Delete;
            }

            if (GUILayout.Button("Quit Game"))
            {
                Application.Quit();
            }

            if (GUILayout.Button("Exit Menu"))
            {
                menuPar.SetActive(false);
            }
        }

        else if (currentMenu == Menu.SaveGame)
        {

            GUILayout.Box("Select Save File To Save");
            GUILayout.Space(10);

            foreach (CurrentGame g in SaveLoad.savedGames)
            {
                if (GUILayout.Button(g.fileName.name))
                {
                    Debug.Log(SaveLoad.savedGames.FindIndex(x => x == g));
                    SaveLoad.currentFile = SaveLoad.savedGames.FindIndex(x => x == g);
                    SaveLoad.SaveAt();
                    currentMenu = Menu.SaveMenu;
                    return;
                }
               
            }
              
            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                currentMenu = Menu.SaveMenu;
            }
        }

        else if (currentMenu == Menu.LoadGame)
        {

            GUILayout.Box("Select Save File To Load");
            GUILayout.Space(10);

            foreach (CurrentGame g in SaveLoad.savedGames)
            {
                if (GUILayout.Button(g.fileName.name))
                {
                    CurrentGame.game = g;
                    //Move on to game...
                    Debug.Log(SaveLoad.savedGames.FindIndex(x => x == g));
                    SaveLoad.currentFile = SaveLoad.savedGames.FindIndex(x => x == g);
                    SceneManager.LoadScene("Town");
                }

            }

            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                currentMenu = Menu.SaveMenu;
            }

        }

        else if (currentMenu == Menu.Delete)
        {
            GUILayout.Box("Select Save File To Delete");
            GUILayout.Space(10);
            foreach (CurrentGame g in SaveLoad.savedGames)
            {
                if (GUILayout.Button(g.fileName.name))
                {
                    Debug.Log(SaveLoad.savedGames.FindIndex(x => x == g));
                    SaveLoad.currentFile = SaveLoad.savedGames.FindIndex(x => x == g);
                    SaveLoad.Deleted();
                    currentMenu = Menu.SaveMenu;
                    return;
                }
               
            }
            
            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                currentMenu = Menu.SaveMenu;
            }

        }


        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();

    }
}
