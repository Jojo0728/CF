using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject[] enemies = new GameObject[12];

    public GameObject enemy;

    public float spawnWait;
    public float spawnMostWait= 5f;
    public float spawnLeastWait= 3f;
    public int startWait;

    public float Timer;
    public float NextLevelTimer;
    public float TimerNextSpawn;
    public int NextSpawnPoint;

    void Start()
    {
        TimerNextSpawn = Random.Range(spawnLeastWait, spawnMostWait);

        Timer = Time.time + 5;

        NextLevelTimer = Time.time + 60;
    }

    void Update()
    {
        if(Timer < Time.time)
        {
            NextSpawnPoint = Random.Range(0, 11);
            Instantiate(enemy, enemies[NextSpawnPoint].gameObject.transform.position, enemies[NextSpawnPoint].gameObject.transform.rotation);
            Timer = Time.time + TimerNextSpawn;
        }

        if (NextLevelTimer < Time.time)
        {
            spawnLeastWait--;
            spawnMostWait--;
            NextLevelTimer = Time.time + 60;
        }
    }
}
