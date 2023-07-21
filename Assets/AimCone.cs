using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimCone : MonoBehaviour
{
    float xPercentage; 
    float yPercentage; 

    // Update is called once per frame
    void Update()
    {
        xPercentage = Mathf.LerpUnclamped(-1,1,Mathf.InverseLerp(0,Screen.width, Input.mousePosition.x));
        yPercentage = Mathf.LerpUnclamped(-1,1,Mathf.InverseLerp(0,Screen.height, Input.mousePosition.y));
        
        if (Time.timeScale == 1)
            transform.localRotation = Quaternion.Euler(-yPercentage * 45, -xPercentage * 45 + 90, 0);

        //Debug.Log("X Percentage : " + xPercentage);
        //Debug.Log("Y Percentage : " + yPercentage);
    }
}
