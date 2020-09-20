using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public int damage = 1;
  
    void Start ()
    {
        Destroy(gameObject, 2f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Boss"))
        {

            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}


