using UnityEngine;
using System.IO;

public class FileSaveManager_Lab6 : MonoBehaviour
{
    public SaveData_Lab6 data = new SaveData_Lab6();

    string path;

    void Start()
    {
        path = Application.persistentDataPath + "/save_lab6.json";

        Debug.Log("PATH: " + path);

        LoadData();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            data.score += 10;
            data.level += 1;
            data.timePlayed += 5f;

            Debug.Log("Score: " + data.score);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveData();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }
    }

    public void SaveData()
    {
        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(path, json);

        Debug.Log("Đã SAVE file: " + json);
        Debug.Log("Đường dẫn: " + path);
    }

    public void LoadData()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            data = JsonUtility.FromJson<SaveData_Lab6>(json);

            Debug.Log("Đã LOAD file: " + json);
        }
        else
        {
            Debug.Log("Chưa có file save!");
        }
    }
}