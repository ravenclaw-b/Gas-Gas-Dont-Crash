using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 2;
    public float time;
    public Rigidbody rigidbody;

    void Start()
    {
        speed = time/3;
    }
 
    void FixedUpdate()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, 5);
        rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * 4);
    }
}
