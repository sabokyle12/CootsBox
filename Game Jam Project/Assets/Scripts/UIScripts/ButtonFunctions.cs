using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    private GameObject[] hackButtons;

    private void Start()
    {
        hackButtons = GameObject.FindGameObjectsWithTag("HackSelectionButton");
    }


    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void MainMenuStart()
    {
        LoadScene("Cutscene1");
    }

    public void SetHack(string hack)
    {
        PlayerData.hackType = hack;

        foreach (GameObject button in hackButtons) // makes the selected button highlighted
        {
            if (button.name == hack)
            {
                (button.GetComponent("Outline") as MonoBehaviour).enabled = true;
            }
            else
            {
                (button.GetComponent("Outline") as MonoBehaviour).enabled = false;
            }
        }
    }

    public void HackScreenStart()
    {
        if (PlayerData.hackType != "")
        {
            LoadScene("Level1");
        }
    }

    public void BossFightTryAgain()
    {
        LoadScene("BossFight");
    }

    public void ExitFunction()
    {
        Application.Quit();
    }
}
