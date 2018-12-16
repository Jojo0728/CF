using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enterlevel : MonoBehaviour {
    public GameObject homemenu;
    public GameObject settingmenu;
    public GameObject selectlevel;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStart()
    {
       // homemenu.SetActive(false);
        //selectlevel.SetActive(true);
        SceneManager.LoadScene("Player Test Scene");
    }

    public void OnBack2()
    {
        homemenu.SetActive(true);
        selectlevel.SetActive(false);
    }

    /*public void OnLv3()
    {
        SceneManager.LoadScene("Player Test Scene");
    }

    public void OnLv2()
    {
        SceneManager.LoadScene("Third_Level");
    }

    public void OnLv1()
    {
        //SceneManager.LoadScene("Player Test Scene");
    }*/

    private void OnMouseUpAsButton()
    {
        
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
