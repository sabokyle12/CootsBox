using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningLaser : MonoBehaviour
{
    public bool clockwise; // determines which direction it spins in
    public float speed; // spinning speed, 1 is recommended
    
    // put this script in the laser pointer to make it spin
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!PlayerData.isFreeze)
        {
            if (clockwise)
            {
                transform.eulerAngles += new Vector3(0, 0, -speed);
            }
            else
            {
                transform.eulerAngles += new Vector3(0, 0, speed);
            }
        }
    }
}
