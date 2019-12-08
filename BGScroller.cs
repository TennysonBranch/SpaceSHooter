using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BGScroller : MonoBehaviour
{
    public static float scrollspeed;
    public float tilseSizedZ;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Mathf.Repeat (Time.time*scrollspeed, tilseSizedZ);
        transform.position = startPosition + Vector3.forward * newPosition;
        //make it so if win is true scrollspeed increases
        

    } 
}
