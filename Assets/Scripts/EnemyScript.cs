using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    GameObject player;
    Animator animator;
    Rigidbody2D myRigidBody2D;
    private bool Dead;
	private float timer;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        myRigidBody2D = GetComponent<Rigidbody2D>();
        Dead = false;
	}

    private void LateUpdate()
    {
        int jarak = Mathf.RoundToInt(Vector3.Distance(transform.position, player.transform.position));
        animator.SetInteger("Jarak", jarak);
		if (jarak < 10 && Dead == false && player.transform.position.x < transform.position.x) {
			transform.position = transform.position + (Vector3.left * 2f * Time.deltaTime);
			GetComponent<SpriteRenderer> ().flipX = true;
		} else if (jarak < 10 && Dead == false && player.transform.position.x > transform.position.x + 3) {
			transform.position = transform.position + (Vector3.right * 2f * Time.deltaTime);
			GetComponent<SpriteRenderer> ().flipX = false;
		}
		if (Dead == true) {
			timer += Time.deltaTime;
			if (timer >= 1)
			{
				Destroy(this.gameObject);
			}
		}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
			ScoreScript.scoreValue += 10; 
            animator.SetBool("Matek", true);
            Dead = true;
        }   
    }
}