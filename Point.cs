using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int score = 10;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.scoreManager.AddScore(score);
        Debug.Log("Score: " + GameManager.instance.scoreManager.totalScore);
        this.gameObject.SetActive(false);
    }
}
