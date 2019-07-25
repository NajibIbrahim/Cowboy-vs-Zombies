using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2f;
    public float jump = 200f;
    Animator animator;
    Rigidbody2D myRigidBody2D;
    private int jumpCount = 0;
    public int maxJump = 1;
	private int playerHealth;
	private bool dead;
	private float timer;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        jumpCount = maxJump;
        myRigidBody2D = GetComponent<Rigidbody2D>();
		dead = false;
		PlayerPrefs.SetInt ("PlayerHealth", 3);
		playerHealth = PlayerPrefs.GetInt ("PlayerHealth");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        animator.SetBool("isMoving", false);
        animator.SetBool("isJumping", false);
		if (dead == false) {
			if (Input.GetKey (KeyCode.D)) {
				transform.position = transform.position + (Vector3.right * speed * Time.deltaTime);
				animator.SetBool ("isMoving", true);
				GetComponent<SpriteRenderer> ().flipX = false;
			}
			if (Input.GetKey (KeyCode.A)) {
				transform.position = transform.position + (Vector3.left * speed * Time.deltaTime);
				animator.SetBool ("isMoving", true);
				GetComponent<SpriteRenderer> ().flipX = true;
        	
			}
			if (Input.GetKey (KeyCode.W)) {
				if (jumpCount > 0) {
					Jump ();
				}
			}
		}
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y < 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
		if (playerHealth <= 0)
		{
			animator.SetBool ("isDead", true);
			dead = true;
			timer += Time.deltaTime;
			if (timer >= 3)
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
    }

	void Update(){
		playerHealth = PlayerPrefs.GetInt ("PlayerHealth");
	}
    
    void Jump()
    {
		myRigidBody2D.velocity = transform.up * jump;
        animator.SetBool("isJumping", true);
        jumpCount--;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jumpCount = maxJump;
        }
		if (collision.gameObject.tag == "Zombie")
		{
			playerHealth--;
			PlayerPrefs.SetInt ("PlayerHealth", playerHealth);

			if(playerHealth<0){
				playerHealth = 0;
				PlayerPrefs.SetInt ("PlayerHealth", playerHealth);
			}

		}
    }
}
