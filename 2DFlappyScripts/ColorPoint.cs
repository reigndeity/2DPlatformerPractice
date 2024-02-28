using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPoint : MonoBehaviour
{
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    public Player playerObject;
    public int colorState;
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
            
            if (playerObject.x == colorState)
            {
                FloppybirdripoffGameManager.PointAdd();
                audioSource.Play();
                playerObject.ColorFunction();
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

                //Invoke("Destroyer", 0.25f);


            } else

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
