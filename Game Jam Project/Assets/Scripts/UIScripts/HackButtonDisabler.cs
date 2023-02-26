using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class HackButtonDisabler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool isActive;
    private string hackName;

    [SerializeField] private TMP_Text infoText;

    // Start is called before the first frame update
    void Start()
    {
        hackName = name;
        if (PlayerData.numHacksCompleted == 0)
        {
            isActive = (hackName == "Invincibility"); // only available hack is invincibility first round
            
        }
        else
        {
            isActive = !(PlayerData.hacksCompleted[hackName]); // only unused hacks are available after that
        }
        if (!isActive)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        gameObject.transform.localScale = new Vector3(1.05f, 1.05f, 1f);
        infoText.text = PlayerData.hackInfo[hackName];
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        infoText.text = "";
    }
}
