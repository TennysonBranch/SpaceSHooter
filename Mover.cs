﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        if(Input.GetButton("Fire2"))
        {
            rb.velocity = transform.forward * speed * 2;
        }
    }
}