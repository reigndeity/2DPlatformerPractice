using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirtWallColor : MonoBehaviour
{
    
    public Player playerObject;
    public int colorState;
    public AudioSource audioSource;
    

    public void Start()
    {
        
        playerObject = GameObject.FindObjectOfType<Player>();
        audioSource = GetComponent<AudioSource>();
        

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        
        if (target.gameObject.CompareTag("Player"))
        {
           

            if (playerObject.x == colorState)
            {
                audioSource.Play();
                playerObject.ColorFunction();
                Invoke("Destroyer", 0.3f);
            }
            else

            {
                playerObject.Dead();
            }


        }
    }

    public void Destroyer()
    {
        Destroy(this.gameObject);
    }

}
