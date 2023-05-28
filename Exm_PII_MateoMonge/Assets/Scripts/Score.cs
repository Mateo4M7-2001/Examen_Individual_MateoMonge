using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreLine;

    private void Start()
    {
        ScoreManager.GetInstance().updated += ScoreUI;
    }

    private void ScoreUI(int score)
    {
        scoreLine.text = "Score: "+score.ToString();
    }
}
