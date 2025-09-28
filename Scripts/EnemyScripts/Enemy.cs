using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Player;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D body;
    private SpriteRenderer sr;

    public ParticleSystem EnemyTrail;
    public ParticleSystem EnemyTrail2;
    public GameObject trail;

    public AudioSource audioSource;
    public AudioClip jumpClip;

    private int killed;

    public bool antiGravEnemy;
    public bool jumpingEnemy;
    public bool poisonEnemy;
    public bool jumpingEnemyPlus;
    private bool jumpShoot;
    public bool shootingEnemy;

    public float shootingRate;
    private float secondsTillNext;

    private bool isGrounded;

    public GameObject pause;
    public KillPoint myKillPoint;

    private ClickFunctions pausedScript;

    public GameObject explodePre;
    public GameObject bulletPre;

    public float moveForceEnemy = 1.2f;

    private Transform target;
    private Vector3 moveDir;

    private Vector3 TempPos;


    void OnBecameInvisible()
    {
        if (!jumpingEnemy)
        {
            body.velocity = new Vector2(0f, 0f);

            enabled = false;
        }
        jumpShoot = false;
        audioSource.volume = 0.0f;
        
    }

    void OnBecameVisible()
    {
        if (!jumpingEnemy)
        {
            enabled = true;
        }

        jumpShoot = true;

        if (poisonEnemy && isGrounded == true)
        {

            if (antiGravEnemy)
            {


                body.AddForce(new Vector2(body.velocity.x, -3f), ForceMode2D.Impulse);
                isGrounded = false;
                if (PlayerPrefs.GetInt("SFX", 1) == 1)
                {
                    audioSource.PlayOneShot(jumpClip);
                }
                Trail();


            }
            else
            {
                body.AddForce(new Vector2(body.velocity.x, 3f), ForceMode2D.Impulse);
                isGrounded = false;
                if (PlayerPrefs.GetInt("SFX", 1) == 1)
                {
                    audioSource.PlayOneShot(jumpClip);
                }
                Trail();


            }
        }
        if (shootingEnemy)
        {
            secondsTillNext = 0;
        }

        audioSource.volume = 1.0f;

    }

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        OnBecameInvisible();
        target = GameObject.FindWithTag("Player").transform;
        pause = GameObject.FindWithTag("Pause");
        pausedScript = pause.GetComponent<ClickFunctions>();

        if (antiGravEnemy)
        {
            body.gravityScale = -1;
        }
        else
        {
            body.gravityScale = 1;
        }

    }


    private void Update()
    {

        if (poisonEnemy)
        {
            moveForceEnemy = 1.2f;

        } else
        {
            moveForceEnemy = 0.9f;
        }

        if (pausedScript.paused == false)
        {
            if (enabled && pausedScript.paused == false && jumpingEnemy == false && shootingEnemy == false)
            {
                if (target)
                {
                    Vector3 direction = (target.position - transform.position).normalized;
                    moveDir = direction;
                    if (transform.position.x < target.position.x)
                    {
                        sr.flipX = false;

                    }
                    else if (transform.position.x > target.position.x)
                    {
                        sr.flipX = true;
                    }

                    Trail();
                    body.velocity = new Vector2(moveDir.x * moveForceEnemy, body.velocity.y);
                    


                }
            }

            if (shootingEnemy)
            {
                body.velocity = new Vector3(0f, 0f, 0f);

                if (secondsTillNext <= 0.0f)
                {
                    Instantiate(bulletPre, transform.position, Quaternion.identity);
                    audioSource.PlayOneShot(jumpClip);
                    Trail();
                    secondsTillNext = shootingRate;
                }
                else
                {
                    secondsTillNext -= Time.deltaTime;
                }
                
            }

            if (jumpingEnemy)
            {
                if (myKillPoint != null)
                {
                    myKillPoint.transform.position = transform.position;
                }
                body.velocity = new Vector2(0f, body.velocity.y);

            }

            if (poisonEnemy)
            {
                Trail();
                if (myKillPoint != null)
                {
                    myKillPoint.transform.position = transform.position;
                }
                body.velocity = new Vector2(body.velocity.x, body.velocity.y);

            }


            TempPos = transform.position;
            if (antiGravEnemy)
            {
                TempPos.y += 0.07f;
                transform.eulerAngles = new Vector3(0f, 0f, 180f);

            }
            else
            {
                TempPos.y -= 0.07f;
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }

            trail.transform.position = TempPos;
        }
        else
        {
            StartCoroutine(Wait());
        }


    }


    IEnumerator Wait()
    {

        body.velocity = new Vector2(0f, 0f);
        body.gravityScale = 0;

        yield return new WaitUntil(() => pausedScript.paused == false);

        if (jumpingEnemy)
        {
            if (antiGravEnemy)
            {


                body.gravityScale = -1;


            }
            else
            {
                body.gravityScale = 1;


            }
        }

        if (poisonEnemy)
        {
            if (antiGravEnemy)
            {


                body.gravityScale = -1;


            }
            else
            {
                body.gravityScale = 1;


            }
        }

        if (poisonEnemy || jumpingEnemy)
        {

            if (jumpingEnemyPlus && jumpShoot)
            {
                Instantiate(bulletPre, transform.position, Quaternion.identity);
                Trail2();
            }


            if (antiGravEnemy)
            {

                body.AddForce(new Vector2(0f, -3f), ForceMode2D.Impulse);
                isGrounded = false;
                if (PlayerPrefs.GetInt("SFX", 1) == 1)
                {
                    audioSource.PlayOneShot(jumpClip);
                }
                Trail();


            }
            else
            {
                body.AddForce(new Vector2(0f, 3f), ForceMode2D.Impulse);
                isGrounded = false;
                if (PlayerPrefs.GetInt("SFX", 1) == 1)
                {
                    audioSource.PlayOneShot(jumpClip);
                }
                Trail();


            }
        }
            
        
    }


    private void OnEnable()
    {
        KillPoint.onEnemyDeath += Die;
    }

    private void OnDisable()
    {
        KillPoint.onEnemyDeath -= Die;
    }

    private void Die()
    {
        if (myKillPoint != null)
        {
            if (myKillPoint.dead == true)
            {


                killed = PlayerPrefs.GetInt("EnemiesKilled");

                killed++;

                PlayerPrefs.SetInt("EnemiesKilled", killed);



                GameObject TempDeath = Instantiate(explodePre, transform.position, Quaternion.identity);

                if (antiGravEnemy)
                {
                    TempDeath.GetComponent<ExplodeEnemy>().reversed = true;

                }
                else
                {
                    TempDeath.GetComponent<ExplodeEnemy>().reversed = false;
                }


                if (jumpingEnemy && !jumpingEnemyPlus)
                {
                    TempDeath.GetComponent<ExplodeEnemy>().jump = true;

                }
                else
                {
                    TempDeath.GetComponent<ExplodeEnemy>().jump = false;
                }

                if (poisonEnemy)
                {
                    TempDeath.GetComponent<ExplodeEnemy>().poison = true;

                }
                else
                {
                    TempDeath.GetComponent<ExplodeEnemy>().poison = false;
                }

                if (shootingEnemy)
                {
                    TempDeath.GetComponent<ExplodeEnemy>().shoot = true;

                }
                else
                {
                    TempDeath.GetComponent<ExplodeEnemy>().shoot = false;
                }

                if (jumpingEnemyPlus)
                {
                    TempDeath.GetComponent<ExplodeEnemy>().jumpingPlus = true;

                }
                else
                {
                    TempDeath.GetComponent<ExplodeEnemy>().jumpingPlus = false;
                }


                Destroy(gameObject);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Spike") || collision.gameObject.CompareTag("Enemy"))
        {
            isGrounded = true;

            if (jumpingEnemy && enabled && pausedScript.paused == false)
            {

                if (jumpingEnemyPlus && jumpShoot)
                {
                    Instantiate(bulletPre, transform.position, Quaternion.identity);
                    Trail2();
                }


                if (antiGravEnemy)
                {


                    body.AddForce(new Vector2(0f, -3.5f), ForceMode2D.Impulse);
                    isGrounded = false;
                    if (PlayerPrefs.GetInt("SFX", 1) == 1)
                    {
                        audioSource.PlayOneShot(jumpClip);
                    }
                    Trail();


                }
                else
                {
                    body.AddForce(new Vector2(0f, 3.5f), ForceMode2D.Impulse);
                    isGrounded = false;
                    if (PlayerPrefs.GetInt("SFX", 1) == 1)
                    {
                        audioSource.PlayOneShot(jumpClip);
                    }
                    Trail();


                }
            }

            if (poisonEnemy && enabled && pausedScript.paused == false)
            {

                if (antiGravEnemy)
                {


                    body.AddForce(new Vector2(body.velocity.x, -3f), ForceMode2D.Impulse);
                    isGrounded = false;
                    if (PlayerPrefs.GetInt("SFX", 1) == 1)
                    {
                        audioSource.PlayOneShot(jumpClip);
                    }
                    Trail();


                }
                else
                {
                    body.AddForce(new Vector2(body.velocity.x, 3f), ForceMode2D.Impulse);
                    isGrounded = false;
                    if (PlayerPrefs.GetInt("SFX", 1) == 1)
                    {
                        audioSource.PlayOneShot(jumpClip);
                    }
                    Trail();


                }
            }


        }
    }


    private void Trail()
    {
        EnemyTrail.Play();
    }


    private void Trail2()
    {
        EnemyTrail2.Play();
    }

}//Class
