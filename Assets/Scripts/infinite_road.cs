using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinite_road : MonoBehaviour
{
    [SerializeField] GameObject current;
    [SerializeField] GameObject blank_segment;
    GameObject last;
    int currentNum = 1;
    int farthestPlaced = 2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.z);

        if ((transform.position.z) >= (currentNum * 100 + 102))
        {   
            currentNum++;
            Destroy(current);

            farthestPlaced++;
            Instantiate(blank_segment, new Vector3 (0, 0, farthestPlaced * 100 + 50), Quaternion.identity);
            GameObject.Find("emptySegment(Clone)").name = "Segment (" + farthestPlaced  + ")";

            current = GameObject.Find("Segment (" + currentNum + ")");
        }
    }
}
