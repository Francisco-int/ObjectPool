using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, spawnInterval);
    }

    private void SpawnObstacle()
    {
        ObjectPool.objectPool.GetPooledObject(spawnPoint);
    }
}

