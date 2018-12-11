using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject[] enemies = new GameObject[12];

    public GameObject enemy;

    public float spawnWait;
    public float spawnMostWait= 10f;
    public float spawnLeastWait= 5f;
    public int startWait;

    public float Timer;
    public float TimerNextSpawn;
    public int NextSpawnPoint;

    void Start()
    {
        TimerNextSpawn = Random.Range(3f, 5f);

        Timer = Time.time + 5;
    }

    void Update()
    {
        if(Timer < Time.time)
        {
            NextSpawnPoint = Random.Range(0, 11);
            Instantiate(enemy, enemies[NextSpawnPoint].gameObject.transform.position, enemies[NextSpawnPoint].gameObject.transform.rotation);
            Timer = Time.time + TimerNextSpawn;
        }
    }
}
