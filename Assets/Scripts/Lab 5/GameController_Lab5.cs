using UnityEngine;
using UnityEngine.UI;

public class GameController_Lab5 : MonoBehaviour
{
    public GameConfig_Lab5 config;
    public Text configText;

    void Start()
    {
        configText.text = "HP: " + config.playerHP +
                          "\nSpeed: " + config.playerSpeed +
                          "\nDamage: " + config.damage;
    }
}