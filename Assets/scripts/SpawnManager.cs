using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject catchPrefab;
    public Vector2 spawnRange;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0, 2.0f);
        InvokeRepeating(nameof(SpawnPointCube), 0, 1.0f);
    }


    void SpawnPointCube()
    {

        Vector3 pointSpawnPosition = new Vector3(
        Random.Range(spawnRange[0], spawnRange[1]),
        catchPrefab.transform.position.y,
        catchPrefab.transform.position.z
        );
        Instantiate(
catchPrefab,
pointSpawnPosition,
catchPrefab.transform.rotation
);
    }
    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRange[0], spawnRange[1]), 
            enemyPrefab.transform.position.y, 
            enemyPrefab.transform.position.z
            );


        Instantiate(
            enemyPrefab,
            spawnPosition,
            enemyPrefab.transform.rotation
            );


    }
}
