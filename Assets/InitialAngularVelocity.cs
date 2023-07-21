using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialAngularVelocity : MonoBehaviour
{
    public int minRotationRate = 5;
    public int maxRotationRate = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(Random.Range(minRotationRate,maxRotationRate),Random.Range(minRotationRate,maxRotationRate), Random.Range(minRotationRate,maxRotationRate)), ForceMode.Impulse);
    }
}
