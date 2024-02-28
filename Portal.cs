using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform targetPos;
    public bool isRange;
    public Transform playerPos;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isRange)
        {
            playerPos.position = targetPos.position;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isRange = true;
            if (playerPos == null)
            {
                playerPos = collision.GetComponent<Transform>();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isRange = true;
            if (playerPos == null)
            {
                playerPos = collision.GetComponent<Transform>();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isRange = false;
    }
}
