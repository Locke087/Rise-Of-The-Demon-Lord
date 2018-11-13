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
            OverGrownLabyrinthTileSet overGrown = new OverGrownLabyrinthTileSet();
            GrowlingDeepsTileSet growlingDeeps = new GrowlingDeepsTileSet();
            FrozenTundraTileSet frozenTundra = new FrozenTundraTileSet();
            ScorchingWastesTileSet scorchingWastes = new ScorchingWastesTileSet();
            overGrown = GameObject.Find("LoadMaps").GetComponent<TempDisplayer>().overGrownLabyrinth;
            frozenTundra = GameObject.Find("LoadMaps").GetComponent<TempDisplayer>().frozenTundra;
            growlingDeeps = GameObject.Find("LoadMaps").GetComponent<TempDisplayer>().growlingDeeps;
            scorchingWastes = GameObject.Find("LoadMaps").GetComponent<TempDisplayer>().scorchingWastes;
            CurrentGame.game.overGrown = overGrown;
            CurrentGame.game.growlingDeeps = growlingDeeps;
            CurrentGame.game.scorchingWastes = scorchingWastes;
            CurrentGame.game.frozenTundra = frozenTundra;
            CurrentGame.game.memoryGeneral.gold = 600;
            GameObject.Find("LoadUnits").GetComponent<UnitLoader>().CreateStartingRoster();
            SwordLoader.StartingInventoryWeapon();
            AssessoryLoader.StartingInventoryAssessory();
            ItemLoader.StartingInventoryItems();
            if (GUILayout.Button("Save")) {
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
  
            foreach (CurrentGame g in SaveLoad.savedGames) {
				if(GUILayout.Button(g.fileName.name)) {
					CurrentGame.game = g;
                    //Move on to game...
                    SaveLoad.currentFile = SaveLoad.savedGames.FindIndex(x => x == g);
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
                    Debug.Log(SaveLoad.savedGames.FindIndex(x => x == g));
                    SaveLoad.currentFile = SaveLoad.savedGames.FindIndex(x => x == g);
                    SaveLoad.Deleted();
                    return;
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
