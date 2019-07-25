using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NyawaScript : MonoBehaviour {

	public static int nyawaValue = 0;
	Text nyawa;
	// Use this for initialization
	void Start () {
		nyawaValue = PlayerPrefs.GetInt("PlayerHealth");
		nyawa = GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		nyawa.text = " " + nyawaValue;
		nyawaValue = PlayerPrefs.GetInt("PlayerHealth");
	}
}
