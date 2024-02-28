using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public void Update()
    {
        transform.position += Vector3.left * 1f * Time.deltaTime;
    }
}
