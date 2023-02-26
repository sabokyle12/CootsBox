using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserParentScript : MonoBehaviour
{
    [SerializeField] private Transform pCamera;

    // The point of this is to make the lasers move in the x direction relative to the camera
    void Update()
    {
        transform.position = new Vector3(pCamera.position.x, transform.position.y, 0);
    }
}
