using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeDesert : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;

        LoadSceneChange();
    }

    public void LoadSceneChange()
    {
        SceneManager.LoadScene("Grave");

    }

}
