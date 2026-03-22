using UnityEngine;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{
    public static SaveLoadManager instance;

    public SaveData data = new SaveData();

    string path;

    void Awake()
    {
        instance = this;
        path = Application.persistentDataPath + "/savegame.json";
    }

    public void SaveGame()
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);

        Debug.Log("Saved to: " + path);
    }

    public void LoadGame()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            data = JsonUtility.FromJson<SaveData>(json);

            Debug.Log("Loaded from: " + path);
        }
        else
        {
            Debug.Log("No save file found!");
        }
    }
}