using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cutscene8Text : MonoBehaviour
{
    [SerializeField] private TMP_Text cutsceneText;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerData.numItemsCollected == 4)
        {
            cutsceneText.text = "Good thing all my stuff is still here!";
        }
        else
        {
            cutsceneText.text = "WAIT WHERE IS MY STUFF???";
        }
    }
}
