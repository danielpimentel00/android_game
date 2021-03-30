using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip laserSound;
    public static AudioClip balloonExplosion;
    public static AudioClip shipExplosion;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        laserSound = Resources.Load<AudioClip>("laser_29");
        balloonExplosion = Resources.Load<AudioClip>("explosion_08");
        shipExplosion = Resources.Load<AudioClip>("explosion_02");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "laser_29":
                audioSrc.PlayOneShot(laserSound);
                break;
            case "explosion_08":
                audioSrc.PlayOneShot(balloonExplosion);
                break;
            case "explosion_02":
                audioSrc.PlayOneShot(shipExplosion);
                break;

        }
    }
}
