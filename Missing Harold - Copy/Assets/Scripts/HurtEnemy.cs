using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    public GameObject projectile;

    int damage = 1;
    public float Hitpoints;
    public float MaxHitpoints = 2;

    void OnTriggerEnter2D(Collider2D _collision)
    {
        if (_collision.gameObject.tag == "Bullet")  // collision with game objct
        {
            TakeHit(1);
            FindObjectOfType<AudioManager>().Play("enemyhit");
        }
    }
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;

        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
