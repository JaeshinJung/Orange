using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class Camera : MonoBehaviour
{
    public GameObject follow;


    // Start is called before the first frame update
    void Start()
    {
        follow = GameObject.Find("ThirdPersonController (1)");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(follow.transform.position.x, follow.transform.position.y + 1, transform.position.z);
    }
}
