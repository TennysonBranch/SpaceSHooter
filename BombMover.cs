using UnityEngine;
using System.Collections;

public class BombMover : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        if (Input.GetButton("Fire3"))
        {
            rb.velocity = transform.forward * speed * 2;
        }
    }
}