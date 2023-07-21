using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    AudioSource audioSource; 

    [Header("Velocity Values")]
    [SerializeField]
    float minVelocity = 3;
    [SerializeField]
    float maxVelocity = 8;
    [SerializeField]
    float minRotationRate = 3f;
    [SerializeField]
    float maxRotationRate = 8f;

    void Start() {

        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddRelativeForce(new Vector3(Random.Range(minVelocity, maxVelocity), Random.Range(minVelocity, maxVelocity), Random.Range(minVelocity, maxVelocity)), ForceMode.Acceleration);
        rb.AddRelativeTorque(new Vector3(Random.Range(minRotationRate,maxRotationRate),Random.Range(minRotationRate,maxRotationRate), Random.Range(minRotationRate,maxRotationRate)), ForceMode.Acceleration);
    }

    
}
