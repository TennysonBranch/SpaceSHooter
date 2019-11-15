﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    private AudioSource audioSource;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;
    public GameObject shot;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
    }

    void Fire()
    {
        
        Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.Play();
    }

    
}
