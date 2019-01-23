using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour {

    public static ScoreManager2 GetInstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<ScoreManager2>();

            if(instance == null)
            {
                GameObject container = new GameObject("ScoreManager");
                instance = container.AddComponent<ScoreManager2>();
            }
        }
        return instance;
    }

    private static ScoreManager2 instance;
    private int score = 0;

    private void Start()
    {
        if(instance != null)
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score = score + newScore;
    }
}
