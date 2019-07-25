using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour {

    private float timer;
    float lamaWaktuSplashScreen = 5f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > lamaWaktuSplashScreen)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
