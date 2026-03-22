using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text levelText;
    public Text timeText;

    float timer = 0f;

    void Start()
    {
        UpdateUI();
    }

    void Update()
    {
        timer += Time.deltaTime;
        SaveLoadManager.instance.data.timePlayed = timer;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SaveLoadManager.instance.data.score += 10;
            SaveLoadManager.instance.data.level += 1;
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        var data = SaveLoadManager.instance.data;

        scoreText.text = "Score: " + data.score;
        levelText.text = "Level: " + data.level;
        timeText.text = "Time: " + Mathf.FloorToInt(data.timePlayed);
    }

    public void SaveGame()
    {
        SaveLoadManager.instance.SaveGame();
    }

    public void LoadGame()
    {
        SaveLoadManager.instance.LoadGame();
        timer = SaveLoadManager.instance.data.timePlayed;
        UpdateUI();
    }
}