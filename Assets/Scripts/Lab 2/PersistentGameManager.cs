using UnityEngine;

public class PersistentGameManager : MonoBehaviour
{
    public static PersistentGameManager instance;

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
}