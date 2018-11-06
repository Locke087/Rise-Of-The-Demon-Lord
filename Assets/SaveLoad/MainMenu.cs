using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour {

	public enum Menu {
		MainMenu,
		NewGame,
		Continue,
        Delete
	}

	public Menu currentMenu;

	void OnGUI () {

		GUILayout.BeginArea(new Rect(0,0,Screen.width, Screen.height));
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();

		if(currentMenu == Menu.MainMenu) {

			GUILayout.Box("Rise Of The Demon Lord");
			GUILayout.Space(10);

			if(GUILayout.Button("New Game")) {
                CurrentGame.game = new CurrentGame();
				currentMenu = Menu.NewGame;
			}

			if(GUILayout.Button("Continue")) {
				SaveLoad.Load();
				currentMenu = Menu.Continue;
			}

            if (GUILayout.Button("Delete Save"))
            {
                SaveLoad.Load();
                currentMenu = Menu.Delete;
            }

            if (GUILayout.Button("Quit")) {
				Application.Quit();
			}
		}

		else if (currentMenu == Menu.NewGame) {

			GUILayout.Box("Name Your Characters");
			GUILayout.Space(10);

			GUILayout.Label("File Name");
			CurrentGame.game.fileName.name = GUILayout.TextField(CurrentGame.game.fileName.name, 20);
            CurrentGame.game.overGrown = GameObject.Find("LoadMaps").GetComponent<TempDisplayer>().overGrownLabyrinth;

			if(GUILayout.Button("Save")) {
				//Save the current Game as a new saved Game
				SaveLoad.Save();
                //Move on to game...=
  
                SceneManager.LoadScene("Town");

            }

			GUILayout.Space(10);
			if(GUILayout.Button("Cancel")) {
				currentMenu = Menu.MainMenu;
			}

		}

		else if (currentMenu == Menu.Continue) {
			
			GUILayout.Box("Select Save File");
			GUILayout.Space(10);
			
			foreach(CurrentGame g in SaveLoad.savedGames) {
				if(GUILayout.Button(g.fileName.name)) {
					CurrentGame.game = g;
                    //Move on to game...

                    SceneManager.LoadScene("Town");
                }

            }

			GUILayout.Space(10);
			if(GUILayout.Button("Cancel")) {
				currentMenu = Menu.MainMenu;
			}
			
		}

        else if (currentMenu == Menu.Delete)
        {

            foreach (CurrentGame g in SaveLoad.savedGames)
            {
                if (GUILayout.Button(g.fileName.name))
                {
                    SaveLoad.Deleted();
                }

            }

            GUILayout.Space(10);
            if (GUILayout.Button("Cancel"))
            {
                currentMenu = Menu.MainMenu;
            }

        }


        GUILayout.FlexibleSpace();
		GUILayout.EndVertical();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();

	}
}
