using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int coinsCollected = 0;
    private int health = 100;
    private bool hasKey = false;
    private float dissapear = 0;
    Rigidbody m_Rigidbody;

    public void Update()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //This locks the RigidBody so that it does not move or rotate in the Z axis.
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        if (transform.position.y < 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    public void FixedUpdate()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinsCollected = coinsCollected + 1;
            Debug.Log(coinsCollected);
        }
        else if (other.tag == "Damage")
        {
            health = health - 10;
            Debug.Log(health);
            if (health <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
        else if (other.tag == "Key")
        {
            Destroy(other.gameObject);
            hasKey = true;
        }
        else if (other.tag == "Door")
        {
            if (hasKey)
            {
                other.GetComponent<Animator>().SetTrigger("Open");
            }
        }
        else if (other.tag == "End")
        {
            if (hasKey == true || SceneManager.GetActiveScene().buildIndex==1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            hasKey = false;
        }
        else if (other.tag == "Enemy")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Block")
        {
            dissapear += Time.deltaTime;
            if (dissapear >= 1.5)
            {
                Destroy(other.gameObject);
                dissapear = 0;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Block")
        {
            dissapear = 0;
        }
    }
}