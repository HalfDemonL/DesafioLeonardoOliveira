using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public int score = 0;
    public GameObject particle;
    int life;

    // Start is called before the first frame update
    void Start()
    {

        life = 30;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, 2f * Time.deltaTime*1.7f); ;
        if(life <= 0)
        {
            score = 1;
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SoundManager.PlaySound("heroDeath");
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            life = life - 10;
            Destroy(collision.gameObject);
           
        }
        if (collision.gameObject.layer == 10)
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
