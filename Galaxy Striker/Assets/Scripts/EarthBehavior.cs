using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBehavior : MonoBehaviour
{
    // The earth's health variable
    private int health = 3;

    public int Health { get => health; set => health = value; }

    // If the enemy collides with the earth it loses health
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            health -= 1;
            Destroy(collision.gameObject);
        }
    }

    void Start()
    {
        
    }

    // If the earth's health drops to zero the game is over.
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }
    }
}
