using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float fadeInTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Fade());
    }

    public IEnumerator Fade() 
    { 
        float elapsedTime = 0.0f;

        Image panel = GetComponent<Image>();
        
        while (elapsedTime < fadeInTime) 
        {
            elapsedTime += Time.deltaTime;

            panel.color = Color.Lerp(Color.black,Color.clear, (elapsedTime/fadeInTime));
            
            yield return null;
        }

        Debug.Log("Faded");
    }

}
