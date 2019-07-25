using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIscript : MonoBehaviour {

	GUIStyle guiStyle = new GUIStyle();
	int nyawa;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		nyawa = PlayerPrefs.GetInt("PlayerHealth");
	}

	void OnGUI(){
		GUI.color = Color.black;
		guiStyle.fontSize = 20;
		GUI.Label(new Rect(0,0,300,50), "Nyawa: "+nyawa.ToString(), guiStyle);
	}
}
