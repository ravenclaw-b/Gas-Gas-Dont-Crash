using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinite_road : MonoBehaviour
{
    [SerializeField] GameObject current;
    [SerializeField] GameObject currentWall;

    [SerializeField] GameObject emptySegment;
    [SerializeField] GameObject wall;

    GameObject last;
    int currentNum = 1;
    int farthestPlaced = 2;

    void placeSegment(int position)
    {
        int type = Random.Range(1, 4);

        if (type == 1)
        {
            Instantiate(emptySegment, new Vector3 (0, 0, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("emptySegment(Clone)").name = "Segment (" + position  + ")";

            Instantiate(wall, new Vector3 (-7, 3, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("wall(Clone)").name = "wall (" + position  + ")";
        }

        else if (type == 2)
        {
            Instantiate(emptySegment, new Vector3 (0, 0, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("emptySegment(Clone)").name = "Segment (" + position  + ")";

            Instantiate(wall, new Vector3 (0, 3, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("wall(Clone)").name = "wall (" + position  + ")";
        }

        else if (type == 3)
        {
            Instantiate(emptySegment, new Vector3 (0, 0, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("emptySegment(Clone)").name = "Segment (" + position  + ")";

            Instantiate(wall, new Vector3 (7, 3, farthestPlaced * 50 + 50), Quaternion.identity);
            GameObject.Find("wall(Clone)").name = "wall (" + position  + ")";
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
        if ((transform.position.z) >= (currentNum * 50 + 102))
        {   
            currentNum++;
            Destroy(current);
            Destroy(currentWall);

            farthestPlaced++;
            placeSegment(farthestPlaced);

            current = GameObject.Find("Segment (" + currentNum + ")");
            currentWall = GameObject.Find("wall (" + currentNum + ")");
        }
    }
}