using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public class Stats
    {
        public int Health = 100;

    }

    public Stats _stats = new Stats();

    public void DamagePlayer(int damage)
    {
        _stats.Health -= damage;
        if (_stats.Health <= 0)
        {
            KillPlayer();
            Debug.Log("Player DeD");
        }
    }

    public void KillPlayer()
    {
        Destroy(gameObject);
    }
    
  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
