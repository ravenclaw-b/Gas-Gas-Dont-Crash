using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_system : MonoBehaviour
{

    void Start() 
    {
        
    }

    void Update() 
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {   
            GameObject.Find("Cam").GetComponent<camera_movement>().playerIsAlive = false;

            Destroy(collision.gameObject);
            Debug.Log("You died");
        }
    }
}