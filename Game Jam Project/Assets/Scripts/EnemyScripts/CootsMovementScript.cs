using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CootsMovementScript : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float speed;
    [SerializeField] private float timeToAttack;
    [SerializeField] private GameObject laser;
    [SerializeField] private Transform laserParent;
    
    private Transform leftEye;
    private Transform rightEye;
    private float timeElapsed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        leftEye = transform.Find("LeftEye");
        rightEye = transform.Find("RightEye");
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("shootLasers", 2.0f, timeToAttack);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeElapsed += Time.deltaTime;
        Vector3 targetPos = player.transform.position + new Vector3(6f, 3f, 0f);
        float step = speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
    }

    void shootLasers()
    {
        GameObject laser1 = Instantiate(laser, leftEye.position, transform.rotation);
        GameObject laser2 = Instantiate(laser, rightEye.position, transform.rotation);
        laser1.GetComponent<CootsLaserScript>().speedMulti = Mathf.Pow(1.1f, timeElapsed);
        laser2.GetComponent<CootsLaserScript>().speedMulti = Mathf.Pow(1.1f, timeElapsed);
    }
}
