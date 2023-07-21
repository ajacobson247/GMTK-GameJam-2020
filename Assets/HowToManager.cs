using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Michsky.UI.ModernUIPack;

public class HowToManager : MonoBehaviour
{
    public ButtonManager buttonManager; 
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI highlightedButtonText;
    public TextMeshProUGUI instructionsText;
    public Canvas[] canvases;
    int currentInstruction = 0;
    public void NextInstruction () 
    {
        switch (currentInstruction) {
            case 0 : 
                buttonText.SetText("NEXT");
                highlightedButtonText.SetText("NEXT");
                canvases[0].enabled = false;
                canvases[1].enabled = true;
                currentInstruction++;
                break;
            case 1 : 
                instructionsText.SetText("You can slightly aim your extinguisher with your mouse.");
                currentInstruction++;
                break;
            case 2 : 
                instructionsText.SetText("Press escape to pause the game if you want to restart.");
                currentInstruction++;
                break;            
            case 3 : 
                instructionsText.SetText("Good luck and don't get lost in space!");
                buttonText.SetText("BACK TO MENU");
                highlightedButtonText.SetText("BACK TO MENU");
                currentInstruction++;
                break;
            case 4 : 
                instructionsText.SetText("Get back to your ship using a fire extinguisher by pressing either the Space Bar or Left Mouse Button.");
                canvases[0].enabled = true;
                canvases[1].enabled = false;
                currentInstruction = 0;
                break;
            default : 
            canvases[0].enabled = true;
            canvases[1].enabled = false;
            currentInstruction = 0;
                break;
        }
    }

    public void SelectDifficulty () 
    {
        canvases[0].enabled = !canvases[0].enabled;
        canvases[2].enabled = !canvases[2].enabled;
    }

}
