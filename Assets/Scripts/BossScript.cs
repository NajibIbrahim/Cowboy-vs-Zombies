using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour {

	GameObject player;
	Animator animator;
	Rigidbody2D myRigidBody2D;
	private bool Dead;
	private float timer;
	private float fireTimer;
	private int bossLife;

	public Transform FirePoint;
	public GameObject Bullet;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag("Player");
		myRigidBody2D = GetComponent<Rigidbody2D>();
		Dead = false;
		bossLife = 5;
	}
	
	// Update is called once per frame
	void Update () {
		int jarak = Mathf.RoundToInt(Vector3.Distance(transform.position, player.transform.position));
		animator.SetInteger("Jarak", jarak);

		if (jarak < 20) {
			fireTimer += Time.deltaTime;
			if (fireTimer >= 1) {
				Shoot ();
				fireTimer = 0;
			}
		}

		if (Dead == true) {
			timer += Time.deltaTime;
			if (timer >= 1)
			{
				Destroy(this.gameObject);
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "Bullet")
		{
			bossLife--;
			if (bossLife == 0){
				animator.SetBool ("Matek", true);
				Dead = true;
			}
		}   
	}

	void Shoot()
	{
		Debug.Log("Shoot");
		Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
	}
}
