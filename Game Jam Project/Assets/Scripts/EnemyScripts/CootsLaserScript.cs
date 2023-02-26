using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CootsLaserScript : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float startingSpeed;
    public float speedMulti;
    private Vector3 targetPos;
    private float timeElapsed = 0f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        targetPos = player.transform.position;

        Vector3 offset = targetPos - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, offset);
        transform.rotation = rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 5f)
        {
            Destroy(gameObject);
        }
        transform.position += transform.up * startingSpeed * speedMulti * Time.deltaTime;
    }
}
