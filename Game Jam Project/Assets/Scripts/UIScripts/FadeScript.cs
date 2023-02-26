using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    private float timeToFade = 3f;
    private float curTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        var col = gameObject.GetComponent<Renderer>().material.color;
        col.a = 1 - (curTime / timeToFade);
        gameObject.GetComponent<Renderer>().material.color = col;
    }
}
