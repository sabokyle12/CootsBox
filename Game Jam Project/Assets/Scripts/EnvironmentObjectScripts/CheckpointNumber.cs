using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointNumber : MonoBehaviour
{
    [SerializeField] private int checkpointNumber;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerData.checkpoint = checkpointNumber;
        }
    }
}
