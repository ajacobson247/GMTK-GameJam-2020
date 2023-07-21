using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] clips;
    [SerializeField]
    PropulsionControls controls;

    //protected variables 
    [SerializeField]
    AudioSource audioSource;
    
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0.0f) {

            if ((Input.GetKeyDown(KeyCode.Space) && !Input.GetMouseButton(0)) || (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.Space)))
                SetClipandPlay(0, 0.8f);
            else if ((Input.GetKeyUp(KeyCode.Space) &&  !Input.GetMouseButton(0)) || (Input.GetMouseButtonUp(0) && !Input.GetKey(KeyCode.Space)))
                SetClipandPlay(1, 1);
        }
    }

    public void SetClipandPlay (int index, float volume) {
        
        if (audioSource) 
        {
            audioSource.clip = clips[index];
            audioSource.volume = volume;
            audioSource.Play();
        }
    }
}
