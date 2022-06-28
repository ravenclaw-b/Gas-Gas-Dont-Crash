using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinite_road : MonoBehaviour
{
    [SerializeField] GameObject current;

    [SerializeField] GameObject rightWallSegment;
    [SerializeField] GameObject middleWallSegment;
    [SerializeField] GameObject leftWallSegment;

    GameObject last;
    int currentNum = 1;
    int farthestPlaced = 2;

    void placeSegment(int position)
    {
        int type = Random.Range(1, 4);

        if (type == 1)
        {
            Instantiate(rightWallSegment, new Vector3 (0, 0, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("rightWallSegment(Clone)").name = "Segment (" + position  + ")";
        }

        else if (type == 2)
        {
            Instantiate(middleWallSegment, new Vector3 (0, 0, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("middleWallSegment(Clone)").name = "Segment (" + position  + ")";
        }

        else if (type == 3)
        {
            Instantiate(leftWallSegment, new Vector3 (0, 0, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("leftWallSegment(Clone)").name = "Segment (" + position  + ")";
        }
    }   


    // Start is called before the first frame update
    void Start()
    {
        farthestPlaced++;
        placeSegment(farthestPlaced);
        farthestPlaced++;
        placeSegment(farthestPlaced);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.z);

        if ((transform.position.z) >= (currentNum * 50 + 102))
        {   
            currentNum++;
            Destroy(current);

            farthestPlaced++;
            placeSegment(farthestPlaced);

            current = GameObject.Find("Segment (" + currentNum + ")");
        }
    }
}