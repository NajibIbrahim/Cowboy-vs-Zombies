using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour {

	public float speed = 10f;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb.velocity = new Vector2(-10.0f, 0.0f);
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D hitInfo)
	{
		Debug.Log(hitInfo.name);
		//Destroy(gameObject);
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(this.gameObject);
	}
}
