using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombContact : MonoBehaviour
{
    public GameObject explosion;
    private GameController gameController;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("oops this text is not supposed to be here");
        }
    }

    void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
        {
            return;
        }
        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
        
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}