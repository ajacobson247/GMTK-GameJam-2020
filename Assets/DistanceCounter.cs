using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DistanceCounter : MonoBehaviour
{
    [Header("Starting Values")]
    public GameObject ship; 
    public GameObject player;

    //Private Variables 
    TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");
        
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(GetDistance().ToString("F2") + " m");
    }

    float GetDistance() 
    {
        float distanceFromShip = (player.transform.position - ship.transform.position).magnitude;

        return distanceFromShip;
    }
}
