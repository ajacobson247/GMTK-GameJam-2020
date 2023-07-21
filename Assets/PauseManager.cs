using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField]
    Canvas pauseMenu; 
    [SerializeField]
    Canvas HUD;
    public float gameTime = 0.0f;

    [SerializeField]
    AudioSource audio;
    void Update() {

        gameTime += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
    }

    public void PauseGame() {
        
        HUD.enabled = !HUD.enabled;
        pauseMenu.enabled = !pauseMenu.enabled;
        
        switch (HUD.enabled) {
            case true : 
                Time.timeScale = 1;
                audio.UnPause();
                break;
            case false  : 
                Time.timeScale = 0;
                audio.Pause();
                break; 
            default : 
                Time.timeScale = 1;
                audio.UnPause();
                break;
        }
    }
}
