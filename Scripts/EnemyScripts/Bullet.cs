using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private int dir;

    private Rigidbody2D body;
    private SpriteRenderer sr;
    public GameObject pause;
    private ClickFunctions pausedScript;
    public ParticleSystem BulletDestroy;
    public AudioSource audioSource;
    public AudioClip explodeClip;

    private void Awake()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        pause = GameObject.FindWithTag("Pause");
        pausedScript = pause.GetComponent<ClickFunctions>();
    }


    private void OnBecameInvisible()
    {
        audioSource.volume = 0;
    }

    private void OnBecameVisible()
    {
        audioSource.volume = 1;
    }

    private void Start()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            if (GameObject.FindWithTag("Player").transform.position.x < transform.position.x)
            {
                dir = 0;
            }
            else if (GameObject.FindWithTag("Player").transform.position.x > transform.position.x)
            {
                dir = 1;
            }
            else
            {
                dir = Random.Range(0, 2);
            }


            if (dir == 1)
            {
                body.velocity = new Vector2(1f, 0f);
            }
            else if (dir == 0)
            {
                body.velocity = new Vector2(-1f, 0f);
            }
        }
        


    }


    private void Update()
    {
        if (pausedScript.paused == true)
        {
            body.velocity = new Vector2(0f, 0f);
        }
        else
        {
            if (dir == 1)
            {
                body.velocity = new Vector2(1f, 0f);
            }
            else if (dir == 0)
            {
                body.velocity = new Vector2(-1f, 0f);
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Spike"))
        {
            StartCoroutine(DestroyBullet());
        }
    }


    IEnumerator DestroyBullet()
    {
        transform.localScale = new Vector3(0f, 0f, 0f);
        audioSource.PlayOneShot(explodeClip);
        BulletDestroy.Play();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
