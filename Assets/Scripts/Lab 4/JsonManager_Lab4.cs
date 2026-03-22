using UnityEngine;

public class JsonManager_Lab4 : MonoBehaviour
{
    public PlayerData_Lab4 data = new PlayerData_Lab4();

    void Start()
    {
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
        string json = JsonUtility.ToJson(data);

        PlayerPrefs.SetString("PlayerData_Lab4", json);
        PlayerPrefs.Save();

        Debug.Log("Đã SAVE: " + json);
    }

    public void LoadData()
    {
        if (PlayerPrefs.HasKey("PlayerData_Lab4"))
        {
            string json = PlayerPrefs.GetString("PlayerData_Lab4");

            data = JsonUtility.FromJson<PlayerData_Lab4>(json);

            Debug.Log("Đã LOAD: " + json);
        }
        else
        {
            Debug.Log("Chưa có dữ liệu!");
        }
    }
}