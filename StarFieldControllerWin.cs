using UnityEngine;
using System.Collections;

public class StarFieldControllerWin : MonoBehaviour
{

    private ParticleSystem psw;
    public bool includeChildren = true;
    void Start()
    {
        psw = GetComponent<ParticleSystem>();
    }

    void Update()
    {


        int getscore = GameController.score;
        if (GameController.score >= 100)
        {
            psw.Play(includeChildren);
        }

    }


}
