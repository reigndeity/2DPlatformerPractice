using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmeraldPoint : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    public Player playerObject;
    public AudioSource audioSource;

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
            playerObject.ColorFunction();
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }
    }
}
