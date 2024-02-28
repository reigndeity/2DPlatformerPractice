using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    public Player playerObject;
    public AudioSource audioSource;

   // public int x;

    public void Start()
    {
        FloppybirdripoffGameManager = GameObject.FindObjectOfType<FloppybirdripoffGameManager>();
        playerObject = GameObject.FindObjectOfType<Player>();
        audioSource = GetComponent<AudioSource>();

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Player"))
        {
            FloppybirdripoffGameManager.PointAdd();
            audioSource.Play();
            // x = Random.Range(0, playerObject.mcSprites.Length);
            // playerObject.spriteRenderer.sprite = playerObject.mcSprites[x];

            playerObject.ColorFunction();
        }
    }

}
