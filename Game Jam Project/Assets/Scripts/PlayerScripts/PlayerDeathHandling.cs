using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerDeathHandling : MonoBehaviour
{
    private Rigidbody2D rb;
    private string hackType;
    [SerializeField] private GameObject deathAnim;
    [SerializeField] private bool isBossFight;
    [SerializeField] TMP_Text deathsText;
    [SerializeField] TMP_Text collectiblesText;
    // Start is called before the first frame update
    private void Start()
    {
        PlayerData.isUsingDebug = false;
        PlayerData.isDead = false;
        PlayerData.isFreeze = false;
        rb = GetComponent<Rigidbody2D>();
        if (!isBossFight)
        {
            hackType = PlayerData.hackType;
        }
        
        UpdateUI();

        if (!isBossFight)
        {
            gameObject.transform.position = PlayerData.startPos[PlayerData.checkpoint];
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly") && !(hackType == "Invincibility"))
        {
            PlayerData.isDead = true;
            PlayerData.numDeaths++;
            UpdateUI();
            if (isBossFight)
            {
                PlayerData.bossFightDeaths++;
                SceneManager.LoadScene("BossFightDeathScreen");
            }
            else
            {
                Die();
            }
        }
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Deadly") && !(hackType == "Invincibility"))
        {
            PlayerData.isDead = true;
            PlayerData.numDeaths++;
            if (isBossFight)
            {
                PlayerData.bossFightDeaths++;
                SceneManager.LoadScene("BossFightDeathScreen");
            }
            else
            {
                Die();
            }
        }
    }

    private void Die()
    {
        Time.timeScale = 0f;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        deathAnim.SetActive(true);
        StartCoroutine(wait(1f));
        
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private IEnumerator wait(float seconds)
    {
        yield return new WaitForSecondsRealtime(seconds);
        Time.timeScale = 1f;
        RestartLevel();
    }

    private void UpdateUI()
    {
        deathsText.text = ": " + PlayerData.numDeaths;
        collectiblesText.text = ": " + PlayerData.numItemsCollected;
    }
}
