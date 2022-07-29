using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 100;

    void Start()
    {

    }
 
    void FixedUpdate()
    {
        if (GameObject.Find("Cam").GetComponent<camera_movement>().playerIsAlive)
        {               
            Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
    
            Vector3 forward = new Vector3(0, 0, 2);
            Vector3 horizontal = (m_Input * Time.deltaTime * 10) + transform.position;

            if(horizontal.x > -9 && horizontal.x < 9)
            {
                this.GetComponent<Rigidbody>().MovePosition(forward + horizontal);
            }
            else
            {
                this.GetComponent<Rigidbody>().MovePosition(forward * Time.deltaTime);
            }
        }
    }
}
