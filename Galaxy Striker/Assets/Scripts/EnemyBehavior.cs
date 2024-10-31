using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Enemy rigidbody and health variables
    [SerializeField] private Rigidbody2D rigidbody2;

    [SerializeField] private UiManager uiScript;

    private float enemySpeed;
    private int health = 15;
    private int points = 15;

    public int Health { get => health; set => health = value; }
    public float EnemySpeed { get => enemySpeed; set => enemySpeed = value; }

    void Start()
    {
        uiScript = GameObject.Find("UI").GetComponent<UiManager>();
    }

    void Update()
    {
        // The velocity of our enemy and if the health drops to 0 it dies
        rigidbody2.velocity = new Vector3(0,-enemySpeed,0);

        if (health <= 0)
        {
            uiScript.TotalPoints += points;
            Destroy(gameObject);
        }
    }
}
