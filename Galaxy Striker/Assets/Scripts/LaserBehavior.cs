using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    // The variables of our rigidbody, timer and damage
    private Rigidbody2D rb2d;

    private float despawnTimer = 3f;
    private float despawnTimeCounter;

    private int damage = 5;

    // If the lase collides with an enemy, the laser gets destroyed and the enemy takes damage
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GameObject enemy = collision.gameObject;
            EnemyBehavior enemyScript = enemy.GetComponent<EnemyBehavior>();
            enemyScript.Health = enemyScript.Health - damage;
            Destroy(gameObject);
        }
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // A timer for despawning lazers that miss
        despawnTimeCounter += Time.deltaTime;

        if (despawnTimeCounter >= despawnTimer)
        {
            Destroy(gameObject);
        }

        // The velocity of our lazer
        rb2d.velocity = new Vector3(0,5,0);
    }
}
