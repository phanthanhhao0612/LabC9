using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager_Lab3 : MonoBehaviour
{
    public Text highScoreText;
    public Text currentScoreText;

    int currentScore;
    int highScore;

    void Start()
    {
        currentScore = PlayerPrefs.GetInt("CurrentScore", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        currentScoreText.text = "Current Score: " + currentScore;
        highScoreText.text = "High Score: " + highScore;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentScore += 10;

            currentScoreText.text = "Current Score: " + currentScore;
            
            if (currentScore > highScore)
            {
                highScore = currentScore;
                highScoreText.text = "High Score: " + highScore;
            }

            PlayerPrefs.SetInt("CurrentScore", currentScore);
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }
}