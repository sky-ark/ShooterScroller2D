using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public PlayerStats stats;
    public int damage = 20;
    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameSounds.enemyDeath = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("enemy hit");
            stats.DamagePlayer(damage);
        }
    }
}
