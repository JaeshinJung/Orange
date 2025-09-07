using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform1 : MonoBehaviour
{

    string direction = "right";
    float xStart = 0;


    // Start is called before the first frame update
    void Start()
    {
        xStart = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(direction=="right")
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime);
            if (gameObject.transform.position.x >= xStart + 5)
            {
                direction = "left";
            }
        }
        else
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime);
            if (gameObject.transform.position.x <= xStart)
            {
                direction = "right";
            }
        }
    }
}
