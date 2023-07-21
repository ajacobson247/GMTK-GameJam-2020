using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int sceneIndex = 1;

    public void LoadGame () {
        Time.timeScale = 1;
        StartCoroutine(Delay(1f));
        SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
    }

    public void LoadHard () {
        Time.timeScale = 1;
        StartCoroutine(Delay(1f));
        SceneManager.LoadScene(2,LoadSceneMode.Single);
    }

    public void ResetLevel () {
        Time.timeScale = 1;
        StartCoroutine(Delay(1f));
        SceneManager.LoadScene(SceneManager.GetActiveScene().name,LoadSceneMode.Single);
    }

    public void ExitGame () {
        Time.timeScale = 1;
        StartCoroutine(Delay(1f));
        Application.Quit();
    }

    IEnumerator Delay(float time) 
    {
        yield return new WaitForSecondsRealtime(time);
    }
}
