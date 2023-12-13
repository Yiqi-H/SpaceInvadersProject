using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurseSpawner : MonoBehaviour
{
    public GameObject EnemyCurse;
    public float spawnTimer;
    public float spawnMax = 10;
    public float spawnMin = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Instantiate(EnemyCurse, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
        
    }
}