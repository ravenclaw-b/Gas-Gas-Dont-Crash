using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public Transform Player;
    public Vector3 cameraOffset;

    public bool playerIsAlive = true;


    void Start() 
    {
        cameraOffset = transform.position - Player.transform.position;
    }
    void LateUpdate()
    {
        if (playerIsAlive)
        {
            Vector3 newPos = Player.transform.position + cameraOffset;
            transform.position = newPos;
        }
    }
}
