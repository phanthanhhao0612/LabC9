using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        GameData.score = 100; 
        scoreText.text = "Score gốc: " + GameData.score;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}