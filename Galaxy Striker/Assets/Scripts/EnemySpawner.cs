using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject Enemy;

    private float randomSpawnTime = 3f;
    private float randomSpawnTimeCounter;

    System.Random spawnValue = new System.Random();

    private int spawnIndex = 30;

    private int waveIndex;
    private float waveCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        randomSpawnTimeCounter += Time.deltaTime;

        if (randomSpawnTimeCounter >= randomSpawnTime)
        {
            int willSpawn = spawnValue.Next(1, spawnIndex);
            if ( willSpawn >= spawnIndex/2)
            {
                GameObject newEnemy = Instantiate(Enemy);
                newEnemy.transform.position = gameObject.transform.position;
            }
            randomSpawnTimeCounter = 0;
        }

        waveCounter += Time.deltaTime;

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
