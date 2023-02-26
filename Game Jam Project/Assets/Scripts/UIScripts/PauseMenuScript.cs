using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] private GameObject pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        pauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                pauseCanvas.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                pauseCanvas.SetActive(true);
                Time.timeScale = 0f;
            }
            isPaused = !isPaused;
        }


    }
    public void ResumeGame()
    {
      pauseCanvas.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("TitleScreen");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
