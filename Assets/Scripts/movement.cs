using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5;

    void Start()
    {

    }
 
    void FixedUpdate()
    {
        if (GameObject.Find("Cam").GetComponent<camera_movement>().playerIsAlive)
        {               
            Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            Vector3 newPos = transform.position + new Vector3(0, 0, speed);

            if(( (m_Input * Time.deltaTime * Vector3(2, 0, 0) ).x > -9) && ( (m_Input * Time.deltaTime * Vector3(2, 0, 0) ).x < 9))
            {
                newPos += m_Input * Time.deltaTime;
            }

            this.GetComponent<Rigidbody>().MovePosition(newPos);
        }
    }
}
