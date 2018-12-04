using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;

    public float spawnWait;
    public float spawnMostWait= 10f;
    public float spawnLeastWait= 5f;
    public int startWait;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            Instantiate(enemy, this.gameObject.transform.position, this.gameObject.transform.rotation);

            yield return new WaitForSeconds(startWait);
        }
    }
}
