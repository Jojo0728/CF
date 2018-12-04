using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public GameObject GameOverc;
    public GameObject Setting;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnAgain()
    {
        SceneManager.LoadScene("uidemo");
    }

    public void OnExit()
    {
        SceneManager.LoadScene("Home");
    }

    public void OnSetting()
    {
        Setting.SetActive(true);
        GameOverc.SetActive(false);
    }

    public void OnBack()
    {
        Setting.SetActive(false);
        GameOverc.SetActive(true);
    }
}
