using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] Vector3 targetPos1;
    [SerializeField] Vector3 targetPos2;
    [SerializeField] float speed;
    private SpriteRenderer sprite;
    private float prev = 0;
    private float cur = 0;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        transform.position = targetPos1;
    }

    void Update()
    {
        if (!PlayerData.isFreeze)
        {
            cur = Mathf.PingPong(Time.time * speed, targetPos2.x - targetPos1.x);
            transform.position = new Vector3(Mathf.PingPong(Time.time * speed, targetPos2.x - targetPos1.x) + targetPos1.x, transform.position.y, transform.position.z);
            if (cur > prev)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
            prev = Mathf.PingPong(Time.time * speed, targetPos2.x - targetPos1.x);
        }
        
    }
}
