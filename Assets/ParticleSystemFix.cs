using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemFix : MonoBehaviour
{
    public ParticleSystem[] particles;
    void Awake() 
    {
        foreach (ParticleSystem system in particles)
            system.gameObject.SetActive(true);
    }
}
