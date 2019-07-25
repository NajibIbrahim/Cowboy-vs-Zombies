using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManagerOption : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onBackLevel()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void onCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void onBackCredits()
    {
        SceneManager.LoadScene("Option");
    }
}
