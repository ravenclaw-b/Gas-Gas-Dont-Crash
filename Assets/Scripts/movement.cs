using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 2;

    public GameObject self;

    void Start()
    {

    }
 
    void FixedUpdate()
    {
        if (GameObject.Find("Cam").GetComponent<camera_movement>().playerIsAlive)
        {
            Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, 5);
            self.GetComponent<Rigidbody>().MovePosition(transform.position + m_Input * Time.deltaTime * 15);
        }
    }
}
