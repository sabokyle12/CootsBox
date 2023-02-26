using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerData.numHacksCompleted++;
            PlayerData.hacksCompleted[PlayerData.hackType] = true;
            PlayerData.hackType = "";
            PlayerData.checkpoint = 0;
            SceneManager.LoadScene("CootsCutscene");
            
        }
    }
}
