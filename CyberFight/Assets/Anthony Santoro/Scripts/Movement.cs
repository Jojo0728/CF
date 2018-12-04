using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    int x=5, y=5;

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            x--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            x++;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            y++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            y--;
        }

        if (x <= 0)
            x = 9;

        if (y <= 0)
            y = 9;

        if (x >= 10)
            x = 1;

        if (y >= 10)
            y = 1;

        player.transform.position = new Vector3(x, 0, y);
	}
}
