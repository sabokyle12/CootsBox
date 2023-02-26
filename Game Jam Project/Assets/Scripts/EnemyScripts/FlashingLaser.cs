using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLaser : MonoBehaviour
{
    // makes the laser flash on and off
    // put in the laser pointer object
    private GameObject laser;
    private bool isWaiting;
    private bool isStarting;
    [SerializeField] private float buffer; //time it takes for the laser to first turn on
    public float waitTime; // time in seconds between it turning on and turning off and vice versa
    
    void Start()
    {
        laser = transform.Find("Laser").gameObject;
        isStarting = true;
    }

    
    void Update()
    {
        if (!isWaiting)
        {
            if(isStarting)
            {
                StartCoroutine(bufferCountdown(buffer));
            }
            else
            {
                StartCoroutine(enableAndDisable(waitTime, laser));
            }
        }
    }
    IEnumerator bufferCountdown(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        isStarting = false;
    }

    IEnumerator enableAndDisable(float seconds, GameObject obj)
    {
        isWaiting = true;
        yield return new WaitForSeconds(seconds);
        if (!PlayerData.isFreeze)
        {
            obj.SetActive(true);
        }
        
        yield return new WaitForSeconds(seconds);
        if (!PlayerData.isFreeze)
        {
            obj.SetActive(false);
        }
        
        isWaiting = false;
    }
}
