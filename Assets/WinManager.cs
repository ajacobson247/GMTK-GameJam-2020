using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinManager : MonoBehaviour
{
    public Camera[] cameras;
    public FadeIn fadeInScreen;
    public GameObject player;

    public GameObject[] ships;

    public Canvas[] canvases;
    public PauseManager pause;
    public TextMeshProUGUI timeText;
    public IgnitionManager ignition;
    public GameObject droneGroup;
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == player)
            Victory();        
    }

    public void Victory() 
    {
        Debug.Log("VICTORY!");
        timeText.SetText("You were lost in space for " + pause.gameTime.ToString("F1") + " seconds.");

        if (fadeInScreen)
            fadeInScreen.Fade();

        cameras[0].enabled = false;
        cameras[1].enabled = true;

        ships[0].SetActive(false);
        ships[1].SetActive(true);
            
        player.SetActive(false);

        StartCoroutine(Delay());
    }

    IEnumerator Delay () 
    {
        canvases[0].enabled = false;

        yield return new WaitForSecondsRealtime(0.4f);

        if (droneGroup) 
            droneGroup.GetComponent<Animator>().enabled = true;

        ignition.GetComponent<IgnitionManager>().StartIgnition();

        yield return new WaitForSecondsRealtime(1f);

        ships[1].GetComponent<Animator>().Play("spaceshipAnimation", 0);

        yield return new WaitForSecondsRealtime(3f);

        canvases[1].enabled = true;
    }
}
