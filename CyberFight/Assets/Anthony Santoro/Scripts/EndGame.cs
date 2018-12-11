using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
    Rigidbody enemy;
	// Use this for initialization
	void Start () {
        enemy = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Robot")
        {
            print("Game Over");
            SceneManager.LoadScene("Game Over");
        }
    }*/

    private void OnTriggerEnter(Collider Portal)
    {
        if(Portal.gameObject.CompareTag("Portal"))
        {
            print("Game Over");
            SceneManager.LoadScene("Game Over");
        }
    }
}
