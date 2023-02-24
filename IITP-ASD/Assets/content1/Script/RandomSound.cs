using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    public AudioClip[] Sound = new AudioClip[5]; //sound
    AudioSource AS;


    void Start()
    {
        AS = GetComponent<AudioSource>();
        //AS= FindObjectOfType<AudioSource>();

        RandomPlay();

        /*
        if (!AS.isPlaying)
        {
            RandomPlay();
        }
        */
        
    }

    void Update()
    {
        if (!AS.isPlaying)
        {
            
        }
    }

    void RandomPlay()
    {
        AS.clip = Sound[Random.Range(0,Sound.Length)];
        AS.Play();
        Debug.Log(AS.clip.ToString());
        //Debug.Log(AS.ToString()); -> MainCamera(UnityEngine.AudioSource)
    }
}
