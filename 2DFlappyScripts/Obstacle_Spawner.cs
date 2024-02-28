using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public float maxTime = 1.5f;
    public float gameObjectLifetime;
    private float timer;

    public GameObject[] obstacles = new GameObject[0];

    void Update()
    {
        SpawnObstacle();
    }

    public void SpawnObstacle()
    {
        if (timer > maxTime)
        {
            int rnd = Random.Range(0, obstacles.Length);
            GameObject newObstacle;
            newObstacle = Instantiate(obstacles[rnd], transform.position, Quaternion.identity, transform);
            Destroy(newObstacle, gameObjectLifetime);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}