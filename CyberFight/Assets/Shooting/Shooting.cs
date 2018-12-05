using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Rigidbody Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            Rigidbody clone;
            clone = Instantiate(Bullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Rigidbody clone;
            clone = Instantiate(Bullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(-Vector3.forward * 10);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Rigidbody clone;
            clone = Instantiate(Bullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.left * 10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Rigidbody clone;
            clone = Instantiate(Bullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.right * 10);
        }
    }
}
