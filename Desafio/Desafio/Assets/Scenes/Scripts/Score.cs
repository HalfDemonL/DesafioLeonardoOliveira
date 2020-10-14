using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score = 0;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        score = score + enemy.GetComponent<Enemy>().score;

        Debug.Log("Score = " + score);

    }
}
