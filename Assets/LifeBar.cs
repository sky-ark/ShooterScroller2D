using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Slider slider;
    public PlayerStats.Stats stats;
    public void SetMaxHealth(int Health)
    {
        slider.maxValue = stats.Health;
        slider.value = stats.Health;
    }

    public void SetHealth(int Health)
    {
        slider.value = stats.Health;
    }
    
}
