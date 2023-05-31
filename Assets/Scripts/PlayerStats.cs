using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public class Stats
    {
        public int Health = 100;

    }

    public Stats _stats = new Stats();
    public float enemyRepulseForce = 5f;
    public LifeBar lifeBar;
    
   

    public void DamagePlayer(int damage)
    {
        _stats.Health -= damage;
        GameSounds.hurt = true; 
        
        
        if (_stats.Health <= 0)
        {
            KillPlayer();
            Debug.Log("Player DeD");
        }
    }
    public void KillPlayer()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("MenuScene");
    }
    
        private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Vector2 playerDirection = transform.position - collision.transform.position;
            playerDirection.Normalize();
            GetComponent<Rigidbody2D>().AddForce(playerDirection * enemyRepulseForce, ForceMode2D.Impulse);
            Debug.Log("enemy hit");
            DamagePlayer(10);
        }
    }


    
  // Start is called before the first frame update
    void Start()
    {
    //  lifeBar.SetMaxHealth(_stats);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
