using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    [SerializeField] Transform Player;
    Vector3 cameraOffset;

    public bool playerIsAlive = false;
    
    public void move()
    {
        playerIsAlive = true;
    }

    public void SaveAndQuit()
    {
        Application.Quit();
    }

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
