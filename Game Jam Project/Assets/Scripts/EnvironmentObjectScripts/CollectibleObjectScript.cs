using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleObjectScript : MonoBehaviour
{
    [SerializeField] private TMP_Text collectiblesText;

    private void Start()
    {
        UpdateUI();
        if (PlayerData.itemsCollected[gameObject.name])
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            PlayerData.itemsCollected[gameObject.name] = true;
            PlayerData.numItemsCollected++;
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        collectiblesText.text = ": " + PlayerData.numItemsCollected;
    }
}
