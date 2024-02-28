using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Behavior : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("Start Called");
    }

    void Update()
    {
        //Debug.Log("Update Called");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bert")
        {
            Debug.Log("It collided with something with a tag of play ehhehe");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Object has triggered something");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Object has triggered something and he is staying");
    }

}
