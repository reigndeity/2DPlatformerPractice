using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public ScoreManager scoreManager;

    public GameState gameState;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(this);
        }

        gameState = GameState.GAME_RUNNING;
    }

    public void GameOver()
    {
        Debug.Log("Meow loser lol");
    }
}
