using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    string direction = "right";


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == "right")
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * 2);
        }
        else
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * 2);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="ETrigger")
        {
            if (direction == "right") direction = "left";
            else direction = "right";
        }
    }
}
