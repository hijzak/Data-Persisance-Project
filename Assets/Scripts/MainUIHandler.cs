using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    public MainManager mainManager;
    public int currentScore;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = mainManager.m_Points;
        highScoreText.text = "Best Score : " + PlayerPrefs.GetString("HighScoreName") + " : "  + PlayerPrefs.GetInt("HighScore");
    }



    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore()
    {
        int score = mainManager.m_Points;
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.SetString("HighScoreName", PlayerPrefs.GetString("PlayerName"));
        }
        else if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.SetString("HighScoreName", PlayerPrefs.GetString("PlayerName"));
        }
    }
}
