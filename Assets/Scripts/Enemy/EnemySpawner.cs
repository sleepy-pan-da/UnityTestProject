using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyToSpawn;

    public void SpawnEnemy()
    {
        Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
    }
}
