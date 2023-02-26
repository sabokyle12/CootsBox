using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CootsCutsceneTextScript : MonoBehaviour
{
    [SerializeField] private TMP_Text cootsText;
    // Start is called before the first frame update
    void Start()
    {
        cootsText.text = PlayerData.cootsText[PlayerData.numHacksCompleted];
    }

}
