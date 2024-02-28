using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorApple : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    public Player playerObject;
    public AudioSource audioSource;

    public int x;

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
            playerObject.ColorFunction();
            audioSource.Play();
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;


        }
    }

    public void Destroyer()
    {
        Destroy(this.gameObject);
    }
}
