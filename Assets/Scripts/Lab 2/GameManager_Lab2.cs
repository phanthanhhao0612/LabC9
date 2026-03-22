using UnityEngine;

public class GameManager_Lab2 : MonoBehaviour
{
    public static GameManager_Lab2 instance;

    public int score = 100;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log("GameManager_Lab2 đang tồn tại, Score = " + score);
    }
}