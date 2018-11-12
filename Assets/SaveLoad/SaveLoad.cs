using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad {

	public static List<CurrentGame> savedGames = new List<CurrentGame>();
    public static int currentFile;		
	//it's static so we can call it from anywhere
	public static void Save() {

        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            Load();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.OpenWrite(Application.persistentDataPath + "/savedGames.gd");
            SaveLoad.savedGames.Add(CurrentGame.game);
            bf.Serialize(file, SaveLoad.savedGames);
            file.Close();
        }
        else
        {
            SaveLoad.savedGames.Add(CurrentGame.game);
            BinaryFormatter bf = new BinaryFormatter();
            //Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
            FileStream file = File.Create(Application.persistentDataPath + "/savedGames.gd"); //you can call it anything you want 
            bf.Serialize(file, SaveLoad.savedGames);
            file.Close();
        }
	}

    public static void SaveAt()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);            
            SaveLoad.savedGames.RemoveAt(currentFile);
            SaveLoad.savedGames.Add(CurrentGame.game);
            bf.Serialize(file, SaveLoad.savedGames);
            file.Close();
        }
    }

    public static void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            Debug.Log(Application.persistentDataPath + "/savedGames.gd");
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            SaveLoad.savedGames = (List<CurrentGame>)bf.Deserialize(file);
            file.Close();
        }
    }

    public static void Deleted()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            SaveLoad.savedGames.RemoveAt(currentFile);
            bf.Serialize(file, SaveLoad.savedGames);
            file.Close();

        }
    }

}
