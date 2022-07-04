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
        if (collision.gameObject.name == "wall")
        {
            Debug.Log("You died");
        }
    }
}