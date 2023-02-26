using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Update() // sets the camera to the player's position
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
