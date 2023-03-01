using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("HighScore"))
        {
            scoreText.text = "Best Score";
        }
        else
        {
            scoreText.text = "Best Score : " + PlayerPrefs.GetString("HighScoreName") + " : " + PlayerPrefs.GetInt("HighScore");
        }
    }

    public void SaveName()
    {
        string playerName = nameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
