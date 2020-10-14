using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip fireSound, deathPlayerSound, enemyDeathSound;
    static AudioSource audioSourc;
    // Start is called before the first frame update
    void Start()
    {
        fireSound = Resources.Load<AudioClip>("Fire_Sound");
        deathPlayerSound = Resources.Load<AudioClip>("Death_Sound");
        enemyDeathSound = Resources.Load<AudioClip>("Hero_Sound");
        audioSourc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSourc.PlayOneShot(fireSound);
            break;
            case "heroDeath":
                audioSourc.PlayOneShot(deathPlayerSound);
            break;
            case "enemyDeath":
                audioSourc.PlayOneShot(enemyDeathSound);
            break;

        }
    }
}
