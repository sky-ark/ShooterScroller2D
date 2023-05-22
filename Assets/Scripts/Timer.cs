using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public TMP_Text chrono;
    private static float timer;

    private static string chronoScore;
    private static string FinalChronoScore;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        var minutes = timer / 60;
        var seconds = timer % 60;
        var fraction = (timer * 100) % 60;
        
        chronoScore = String.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
        chrono.text = chronoScore;
    }

    public static void StopChrono()
    {
        FinalChronoScore = chronoScore;
        FinishScript.SetHighScore(FinalChronoScore);
    }

    public static void ResetTimer()
    {
        timer = 0f;
    }
}
// https://www.youtube.com/watch?v=Qxwqd2kMHbI Start Stop Reset a Timer