using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public int vida = 3;
    public float speed;
    public GameObject bullet, spawnerBulletPos;
    public GameObject particle;
    public GameObject particleDeath;
    public float fireRate;
    public float nextFire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(vida <= 0)
        {
            Instantiate(particleDeath, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SoundManager.PlaySound("enemyDeath");
        }
        Move();

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            SoundManager.PlaySound("fire");
            nextFire = Time.time + fireRate;
            Instantiate(bullet, spawnerBulletPos.transform.position, this.gameObject.transform.rotation);
            
        }

    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            vida -= 1;
        }
    }

   
}
