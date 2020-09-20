﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public int damage = 1;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.gameObject.tag=="Projectile")  // collision with game objct
        {
            TakeDamage(1);
        }
    }

    void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.gameObject.tag == "Enemy")  // collision with game objct
        {
            TakeDamage(1);
        }
    }



    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
