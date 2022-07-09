using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Destroy(collision.gameObject);
            StartCoroutine(restart());
        }
    }
     
    IEnumerator restart()
    {
        GameObject.Find("Cam").GetComponent<camera_movement>().playerIsAlive = false;

        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("Game");
    }
}