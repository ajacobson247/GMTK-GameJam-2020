using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.ModernUIPack;

public class PropulsionControls : MonoBehaviour
{
    //Public Variables
    [Header("Fuel Properties")]
    public float fuelCapacity = 1000f;
    public float rateOfPropulsion = 0.1f;
    public float forceOfPropulsion = 2f;
    
    [Space(10)]
    [Header("Propulsion Points of Interest")]
    public GameObject propulsionPoint; 
    [SerializeField]
    GameObject secondaryPoint;
    public ParticleSystem propulsionFX;
    public MeshRenderer coneMesh;
    [SerializeField]
    ProgressBar fuelBar;
    [Space(5)]
    [SerializeField]
    Canvas HUD;
    [SerializeField]
    Canvas lostScreen;
    [SerializeField]
    AudioSource soundSource; 
    [SerializeField]
    AudioClip emptyWarningSound;

    //Private Variables
    float fuelRemaining = 1000f;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1) 
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && fuelRemaining != 0)  
                if (propulsionFX) 
                {
                    propulsionFX.Play();
                    coneMesh.enabled = false;
                }

            if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) && fuelRemaining != 0)
                ReleasePropulsion(rateOfPropulsion);
            else if (fuelRemaining <= 0)
                StartCoroutine(CountdownToLose());
            
            if (((Input.GetKeyUp(KeyCode.Space) &&  !Input.GetMouseButton(0)) || (Input.GetMouseButtonUp(0) && !Input.GetKey(KeyCode.Space))) || fuelRemaining == 0) 
            {
                propulsionFX.Stop();
                coneMesh.enabled = true;
            }
            if (fuelRemaining == 5 && soundSource) 
                soundSource.PlayOneShot(emptyWarningSound);
        }
    }

    void ReleasePropulsion(float amountToRelease) 
    {
        if (fuelRemaining >= 0) 
        {
            fuelRemaining -= amountToRelease;

            if(propulsionPoint) 
            {
                //Debug.DrawLine(propulsionPoint.transform.position, propulsionPoint.transform.forward * 30f, Color.red, 2f);         
                GetComponent<Rigidbody>().AddForceAtPosition(-propulsionPoint.transform.forward * forceOfPropulsion, transform.position, ForceMode.Impulse);
            }
        }
        SetFuelRemainingText();
    }

    void SetFuelRemainingText() {
        
        if (fuelBar)
            fuelBar.currentPercent = (fuelRemaining / fuelCapacity)*100;
    }

    public IEnumerator CountdownToLose() {

        yield return new WaitForSeconds(3);
        if (HUD)
            HUD.enabled = false;

        if (lostScreen)
            lostScreen.enabled = true;
    }
}
