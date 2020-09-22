using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public int damage = 1;

    public HealthBar healthBar; //referencing to HealthBar
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);  //setting the healthbar
    }

    
    void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.gameObject.tag=="Projectile")  // collision with game objct
        {
            TakeDamage(1);
        }
        else if(_collision.gameObject.tag == "Enemy") //collision with enemymicrobot
        {
            TakeDamage(1);
        }
    }




    void TakeDamage(int damage)  //function for when player takes damage, affects health+healthbar and inflicts death
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);  //affect healthbar
        if (currentHealth <= 0)
        {
            Destroy(gameObject);  //destroy player
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
