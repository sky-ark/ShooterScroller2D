using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public GameObject Player;
    public static string HighScore;

    public GameObject chrono;

    void OnTriggerEnter(Collider Player)
    {
        Debug.Log("Finito !");
        Timer.StopChrono();

        SceneManager.LoadScene("MenuScene");
    }

    public static void SetHighScore(string chronoScore)
    {
        HighScore = chronoScore;
    }

    public static string getHighscore()
    {
        return HighScore;
    }
}