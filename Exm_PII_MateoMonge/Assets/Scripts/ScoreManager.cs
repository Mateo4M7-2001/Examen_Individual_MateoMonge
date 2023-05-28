using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    public static ScoreManager GetInstance()
    {
        return instance;
    }

    private int score;



    public event Action<int> updated;

  
    public void MoreScore(int number)
    {
        score += number;
        updated?.Invoke(score);
    }
}
