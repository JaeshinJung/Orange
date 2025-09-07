using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2 : MonoBehaviour
{

    string direction = "up";
    float yStart = 0;


    // Start is called before the first frame update
    void Start()
    {
        yStart = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == "up")
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);
            if (gameObject.transform.position.y >= yStart + 5)
            {
                direction = "down";
            }
        }
        else
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime);
            if (gameObject.transform.position.y <= yStart)
            {
                direction = "up";
            }
        }
    }
}
