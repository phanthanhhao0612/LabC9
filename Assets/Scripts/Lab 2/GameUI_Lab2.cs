using UnityEngine;
using UnityEngine.UI;

public class GameUI_Lab2 : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score Lab2: " + GameManager_Lab2.instance.score;
    }
}