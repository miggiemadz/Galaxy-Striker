using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // The enemy prefab variable
    [SerializeField] GameObject Enemy;

    private float randomSpawnTime = 3f; // The timer limit for spawning
    private float randomSpawnTimeCounter; // The counter for our timer

    System.Random spawnValue = new System.Random(); // Gives us a random spawn number to check if the enemy will spawn.

    private int spawnIndex = 30; // The max chance value for spawning

    private int waveIndex; // The level of difficulty wave we are in
    private float waveCounter; // How long a wave has passed

    public int SpawnIndex { get => spawnIndex; set => spawnIndex = value; }
    public int WaveIndex { get => waveIndex; set => waveIndex = value; }

    void Start()
    {
        
    }


    void Update()
    {
        // A timer that after it reaches a certain time, a enemy has a random chance to spawn.
        randomSpawnTimeCounter += Time.deltaTime;

        if (randomSpawnTimeCounter >= randomSpawnTime)
        {
            int willSpawn = spawnValue.Next(1, spawnIndex);
            if ( willSpawn >= spawnIndex/2)
            {
                GameObject newEnemy = Instantiate(Enemy);
                newEnemy.transform.position = gameObject.transform.position;
                EnemyBehavior enemyBehaviorScript = newEnemy.GetComponent<EnemyBehavior>();
                if (spawnIndex == 30)
                {
                    enemyBehaviorScript.EnemySpeed = 1;
                }
                if (spawnIndex == 20)
                {
                    enemyBehaviorScript.EnemySpeed = 2;
                }
                if (spawnIndex == 10)
                {
                    enemyBehaviorScript.EnemySpeed = 3;
                }
            }
            randomSpawnTimeCounter = 0;
        }

        // A counter that checks how long the game has gone for.
        waveCounter += Time.deltaTime;

        // After a certain amount of seconds increase tha spawn chance.
        if (waveCounter >= 30)
        {
            spawnIndex = 20;
        }

        if (waveCounter >= 60)
        {
            spawnIndex = 10;
        }
    }
}
