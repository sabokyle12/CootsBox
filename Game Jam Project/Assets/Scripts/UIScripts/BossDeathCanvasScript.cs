using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossDeathCanvasScript : MonoBehaviour
{
    [SerializeField] private TMP_Text deathMessageText;

    void Start()
    {
        if (PlayerData.bossDeathText.Count > PlayerData.bossFightDeaths)
        {
            deathMessageText.text = "Coots says: \"" + PlayerData.bossDeathText[PlayerData.bossFightDeaths] + "\"";
        }
        else
        {
            deathMessageText.text = "Coots says: \"" + PlayerData.bossDeathText[PlayerData.bossDeathText.Count - 1] + "\"";
        }
        
    }
}
