using UnityEngine;
using System.Collections;

public class StarFieldController : MonoBehaviour
{
    
    private ParticleSystem ps;
    public bool includeChildren = true;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        
        
        int getscore = GameController.score;
        if(GameController.score >= 100)
        {
            ps.Stop(includeChildren, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
        
    }

    
}
