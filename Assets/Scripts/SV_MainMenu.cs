using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SV_MainMenu : MonoBehaviour
{
    public TMP_Text HighScoreBox;

    private void Start()
    {
        HighScoreBox.text = FinishScript.getHighscore();
    }

    public void PlayNowButton()
    {
        Timer.ResetTimer();
        SceneManager.LoadScene("PlayScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}