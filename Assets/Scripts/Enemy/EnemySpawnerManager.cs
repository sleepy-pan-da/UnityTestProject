using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : MonoBehaviour
{
    private int numberOfSpawners;

    private void Start()
    {
        numberOfSpawners = transform.childCount;
    }

    public void SpawnEnemyFromRandomSpawner()
    {
        int spawnerIndex = Random.Range(0, numberOfSpawners);
        Transform chosenEnemySpawner = transform.GetChild(spawnerIndex);
        chosenEnemySpawner.gameObject.GetComponent<EnemySpawner>().SpawnEnemy();
    }
    
}
