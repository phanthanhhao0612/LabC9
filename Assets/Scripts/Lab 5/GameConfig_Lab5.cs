using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig_Lab5", menuName = "Config/GameConfig")]
public class GameConfig_Lab5 : ScriptableObject
{
    public int playerHP = 100;
    public float playerSpeed = 5f;
    public int damage = 10;
}