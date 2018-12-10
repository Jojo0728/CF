using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private int enemyCount = 0;
    public int maxEnemyCount = 12;
    public float timeBetweenSpawns = 2.0f;
    public GameObject enemy;
    void Start()
    {
        InvokeRepeating("Spawn", 0, timeBetweenSpawns);
    }

    void Spawn()
    {
        Instantiate(enemy);
            //, gameObject.transform.position, gameObject.transform.rotation);

        enemyCount++;
        if (enemyCount >= maxEnemyCount)
        {
            CancelInvoke("Spawn");
        }
    }
}