using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
