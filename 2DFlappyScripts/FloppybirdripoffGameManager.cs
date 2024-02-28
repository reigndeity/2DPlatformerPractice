using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FloppybirdripoffGameManager : MonoBehaviour
{
    public int FloppyBird_Score;
    public float obstacleSpeed;
    public TMP_Text scoreText;
    public GameObject mainMenuUI;
    public TMP_Text yourScoreText;
    public TMP_Text highScoreText;

    public void Update()
    {
        scoreText.text = FloppyBird_Score.ToString();
    }

    public void GameReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void ChangeScene(string sceneToLoad)
    {
        ResumeGame();
        SceneManager.LoadScene(sceneToLoad);
    }

    public void PlayeDead()
    {
        HighscoreCheck();
        mainMenuUI.SetActive(true);
    }

    public void PointAdd()
    {
        FloppyBird_Score++;
    }

    public void HighscoreCheck()
    {
        if (FloppyBird_Score > PlayerPrefs.GetInt("FloppyBird_HighScore", 0))
        {
            PlayerPrefs.SetInt("FloppyBird_HighScore", FloppyBird_Score);
        }

        yourScoreText.text = FloppyBird_Score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("FloppyBird_HighScore", 0).ToString();
    }

    public void LinkToWebsite(string website)
    {
        Application.OpenURL(website);
        //Application.OpenURL("https://www.facebook.com/");
    }

    //============ ONLINE SCORE ============


}
