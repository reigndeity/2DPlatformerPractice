using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffect : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;

    public void Start()
    {
        FloppybirdripoffGameManager = GameObject.FindObjectOfType<FloppybirdripoffGameManager>();
    }

    public void Update()
    {
        transform.position += Vector3.right * FloppybirdripoffGameManager.obstacleSpeed * Time.deltaTime;
    }
}
