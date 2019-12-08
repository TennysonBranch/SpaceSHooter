using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWin : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int getscore = GameController.score;
        if (GameController.score >= 100)
        {
            musicSource.clip = musicClip;
            musicSource.Play();
        }
    }
}
