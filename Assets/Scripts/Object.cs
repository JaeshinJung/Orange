using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class Object : MonoBehaviour
{
    GameObject player;

    private void Update()
    {
        if(transform.childCount==0)
        {
            Destroy(gameObject);
        }
    }
}