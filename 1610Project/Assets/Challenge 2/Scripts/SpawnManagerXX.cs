using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerXX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        float spawnInterval = Random.Range(3f, 6f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        
        int ballSpawnRange = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballSpawnRange], spawnPos, ballPrefabs[ballSpawnRange].transform.rotation);
    }

}
