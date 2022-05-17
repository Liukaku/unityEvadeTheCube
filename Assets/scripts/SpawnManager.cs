using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject catchPrefab;
    public Vector2 spawnRange;
    private Stats stats;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEvade), 0, 2.0f);
        InvokeRepeating(nameof(SpawnCatcher), 0, 1.0f);
    }

    private void SpawnCatcher()
    {
        SpawnEnemy(EnemyType.Catcher);
    }

    private void SpawnEvade()
    {
        SpawnEnemy(EnemyType.Enemy);
    }


    void SpawnEnemy(EnemyType enemyType)
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnRange[0], spawnRange[1]), 
            enemyPrefab.transform.position.y, 
            enemyPrefab.transform.position.z
            );

        if(enemyType == EnemyType.Enemy)
        {
            Instantiate(
                enemyPrefab,
                spawnPosition,
                enemyPrefab.transform.rotation
                );
        } else
        {
            Instantiate(
    catchPrefab,
    spawnPosition,
    catchPrefab.transform.rotation
);
        }




    }
}
