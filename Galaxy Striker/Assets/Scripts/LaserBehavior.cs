using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2d;

    private float despawnTimer = 3f;
    private float despawnTimeCounter;

    private int damage = 5;

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
        
    }


    void Update()
    {
        despawnTimeCounter += Time.deltaTime;

        if (despawnTimeCounter >= despawnTimer)
        {
            Destroy(gameObject);
        }

        rb2d.velocity = new Vector3(0,5,0);
    }
}
