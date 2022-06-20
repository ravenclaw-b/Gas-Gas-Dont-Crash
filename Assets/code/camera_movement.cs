using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform car;
    public Vector3 cameraOffset;

    void Start() 
    {
        cameraOffset = transform.position - car.transform.position;
    }
    void LateUpdate()
    {
        Vector3 newPos = car.transform.position + cameraOffset;
        transform.position = newPos;
    }
}
