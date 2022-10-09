using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]GameObject[] enemyPrefab;
    private float spawnRange = 20;
    [SerializeField]int enemyCount;
    int waveNumber = 1;
    


    // Start is called before the first frame update
    void Start()
    {        

        // ABSTRACTION
        /*
        enemyCount = 10;
        for(int i = 0; i < enemyCount; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
        */

        SpawnEnemyWave(enemyCount); // ABSTRACTION

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, enemyPrefab[0].transform.position.y, spawnPosZ);
        return randomPos;        
    }

    void SpawnEnemyWave(int enemiesToSpawn) // ABSTRACTION
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab[0], GenerateSpawnPosition(), enemyPrefab[0].transform.rotation);
            Instantiate(enemyPrefab[1], GenerateSpawnPosition(), enemyPrefab[0].transform.rotation);

        }
    }
}
