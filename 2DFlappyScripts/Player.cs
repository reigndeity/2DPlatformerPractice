using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public AudioSource audioSource;
    public Rigidbody2D rb;
    public FloppybirdripoffGameManager FloppybirdripoffGameManager;
    //public AudioClip[] audioClip;
    public GameObject deathGameObjectSpawn;
    public int x;
    //
    public Sprite[] mcSprites; // Set the possible sprites in the Inspector
    public SpriteRenderer spriteRenderer;
    //

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        x = Random.Range(0, mcSprites.Length);
        spriteRenderer.sprite = mcSprites[x]; // 
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //AudioSource.Play();
            rb.velocity = Vector2.up * jumpForce;
            //audioSource.clip = audioClip[1];
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //AudioSource.Play();
            rb.velocity = Vector2.up * jumpForce;
            //audioSource.clip = audioClip[1];
            audioSource.Play();
        }
    }

    public void FixedUpdate()
    {
        Dive();
    }


    void Dive()
    {
        float angle = 20f;
        if (rb.velocity.y < 0)
        {
            angle = Mathf.Lerp(20, -90, -(rb.velocity.y) / 15);
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.CompareTag("Obstacle"))
        {
            GameObject deathGameObj;
            deathGameObj = Instantiate(deathGameObjectSpawn, transform.position, transform.rotation);
            Destroy(deathGameObj, 1.5f);
            FloppybirdripoffGameManager.PlayeDead();
            Destroy(this.gameObject);

        }




    }

    public void Dead()
    {
        GameObject deathGameObj;
        deathGameObj = Instantiate(deathGameObjectSpawn, transform.position, transform.rotation);
        Destroy(deathGameObj, 1.5f);
        FloppybirdripoffGameManager.PlayeDead();
        Destroy(this.gameObject);
    }

    public void ColorFunction()
    {
        x = Random.Range(0, mcSprites.Length);
        spriteRenderer.sprite = mcSprites[x];
    }
    
}
