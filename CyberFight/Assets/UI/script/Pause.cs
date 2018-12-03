using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    public GameObject Pausemenu;
    public GameObject Pausebutton;
    public GameObject settingmenu;
	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnPause()
    {
        Time.timeScale = 0;
        Pausemenu.SetActive(true);
        Pausebutton.SetActive(false);
    }

    public void OnResume()
    {
        Time.timeScale = 1f;
        Pausemenu.SetActive(false);
        Pausebutton.SetActive(true);
    }

    public void OnSetting()
    {
        Time.timeScale = 0;
        Pausemenu.SetActive(false);
        settingmenu.SetActive(true);
    }

    public void OnBack()
    {
        Time.timeScale = 0;
        settingmenu.SetActive(false);
        Pausemenu.SetActive(true);
    }
    public void OnExit()
    {
        SceneManager.LoadScene("Home");
    }

}
