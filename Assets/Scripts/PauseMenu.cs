using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
     public static bool   GameIsPaused = false;
    public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
          
        }
       
		
	}
    void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Resume()
    {
        resume();

    }

    public void onExitGame()
    {
        resume();
        SceneManager.LoadScene("Main Menu");
    }
    public void onoption()
    {
		resume();
        SceneManager.LoadScene("Option");
    }
	public void onReplay()
	{
		resume();
		Application.LoadLevel(Application.loadedLevel);
	}
}
