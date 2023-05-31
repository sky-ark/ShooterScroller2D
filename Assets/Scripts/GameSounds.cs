using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSounds : MonoBehaviour
{
    public static bool shooting;
    public static bool enemyDeath;
    public static bool hurt;
    public AudioClip shootingClip;
    public AudioClip hurtClip;

    public AudioClip enemyDeathClip;
    // Update is called once per frame
    void Update()
    {
        if (shooting)
        {
            Debug.Log("son du tir");
            GetComponent<AudioSource>().clip = shootingClip;
            GetComponent<AudioSource>().Play();
            Debug.Log("Son du tir");
            shooting = false;
        }

        if (hurt) 
        {
            GetComponent<AudioSource>().clip = hurtClip;
            GetComponent<AudioSource>().Play();
        hurt = false;
        }
        if (enemyDeath)
        {
            GetComponent<AudioSource>().clip = enemyDeathClip;
            GetComponent<AudioSource>().Play();
            enemyDeath = false;
        }
        
        
    }
}
