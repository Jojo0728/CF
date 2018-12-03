using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enterlevel : MonoBehaviour {
    public GameObject homemenu;
    public GameObject settingmenu;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStart()
    {
        
        SceneManager.LoadScene("uidemo");
        
    }

    public void OnSetting()
    {
        homemenu.SetActive(false);
        settingmenu.SetActive(true);

    }

    public void OnBack()
    {
        homemenu.SetActive(true);
        settingmenu.SetActive(false);
    }

    public void OnQuit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
