using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour {

    private static MusicScript instance = null;
	public AudioSource musicSource;
	public Slider volume;

	public MusicScript Instance(){
		return instance;
    }

	void Start(){
		volume.value = PlayerPrefs.GetFloat ("VolumeSlider");
	}	

	void Update(){
		PlayerPrefs.SetFloat ("VolumeSlider",volume.value);
		musicSource.volume = PlayerPrefs.GetFloat("VolumeSlider");
	}
	/*
	void VolumePrefs(){
		PlayerPrefs.SetFloat ("MusicVolume", musicSource.volume);
	}

	void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
		DontDestroyOnLoad (this.gameObject);
    }

	public void PlayMusic(AudioClip clip){
		musicSource.clip = clip;
		musicSource.Play ();
	}

	public void StopMusic(AudioClip clip){
		musicSource.clip = clip;
		musicSource.Stop ();
	}
	*/
}
