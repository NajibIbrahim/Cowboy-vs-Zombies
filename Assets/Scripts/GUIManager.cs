using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onPlay()
    {
        SceneManager.LoadScene("Level Selection");
    }
    public void onOption()
    {
        SceneManager.LoadScene("Option");
    }
    public void onBackLevel()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void onExit()
    {
        Application.Quit();
    }
    public void onDesert()
    {
        SceneManager.LoadScene("Desert");
    }
    public void onGrave()
    {
        SceneManager.LoadScene("Grave");
    }
    public void onForest()
    {
        SceneManager.LoadScene("Forest");
    }

}
