using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    // Use this for initialization
    public Transform FirePoint;
    public GameObject Bullet;


    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
       /* timer += Time.deltaTime;
        if (timer >= 3)
        {
            Destroy(this.gameObject);
        }
        */
    }
    void Shoot()
    {
        Debug.Log("Shoot");
        Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(this.gameObject);
    }
}
