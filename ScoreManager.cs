using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreTxt;


    public void AddScore(int score)
    {
        totalScore += score;
        scoreTxt.text = "Score: " + totalScore.ToString();
    }
}
