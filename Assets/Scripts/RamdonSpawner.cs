using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdonSpawner : MonoBehaviour
{
    
    public GameObject enemy;
    float randX;
    public Transform spawnPosition;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            
        
            Instantiate(enemy, spawnPosition.position, Quaternion.identity);
        }
    }
}

