using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerBehaviour : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20,
        spawnPosZ = 20;

    public float startDelay = 2f,
        spawnInterval = 1.5f;

    private Vector3 spawnVector3;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    
    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnVector3.Set(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnVector3, animalPrefabs[animalIndex].transform.rotation);   
    }
}
