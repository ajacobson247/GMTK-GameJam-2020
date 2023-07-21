using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnitionManager : MonoBehaviour
{
    public ParticleSystem[] particles;

    public void StartIgnition () 
    {
        for (int i = 0; i < 4; i++) 
        {
             particles[i].Play();
        }
    }
}
