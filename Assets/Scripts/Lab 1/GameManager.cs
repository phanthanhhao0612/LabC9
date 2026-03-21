using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Score nhận được: " + GameData.score;
    }
}