using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePointScript : MonoBehaviour {

	private GameObject player;
	private Vector3 playerPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("Player").GetComponent<SpriteRenderer> ().flipX == true) {
			transform.position = playerPosition + new Vector3(-1.5f, 0.0f, 0.0f);
		} else {
			transform.position = playerPosition + new Vector3(1.5f, 0.0f, 0.0f);
		}
	}

	void LateUpdate(){
		player = GameObject.FindGameObjectWithTag ("Player");
		playerPosition = player.GetComponent<Transform> ().position;
	}
}
