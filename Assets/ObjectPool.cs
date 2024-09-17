using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objectPool { get; private set; }

    public GameObject obstaclePrefab;
    private List<GameObject> pool = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab);
            obstacle.SetActive(false); 
            pool.Add(obstacle); 
        }
    }
    public void GetPooledObject(Transform spawnPoint)
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.activeInHierarchy) 
            {
                transform.position = spawnPoint.position;
                obj.SetActive(true);
            }
        }
    }
}

