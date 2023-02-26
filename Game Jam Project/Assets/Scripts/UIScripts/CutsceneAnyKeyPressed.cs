using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneAnyKeyPressed : MonoBehaviour
{
    [SerializeField] private string nextScene;
    [SerializeField] private bool isCootsScene;
    private float timePassed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if ((Input.anyKey || Input.GetMouseButtonDown(0)) && timePassed > 1f)
        {
            if (!isCootsScene || PlayerData.numHacksCompleted < 4)
            {
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                SceneManager.LoadScene("BossFight");
            }    
            
        }
    }
}
