using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class MultiplayerPlayer : MonoBehaviour
{
    public delegate void PlayerDeath();
    public static event PlayerDeath onPlayerDeath;
    public static event PlayerDeath playerRespawn;

    public delegate void AntiGrav();
    public static event AntiGrav antiGravSwitch;

    public delegate void CollectKey();
    public static event CollectKey onKeyCollect;

    private int deaths;
    private int jumps;
    private int gravitySwitches;


    public float timer;
    public float timerTemp;

    public bool greenKey = false;
    public bool blueKey = false;
    public bool redKey = false;
    public bool yellowKey = false;

    private bool antiGrav;
    private Vector3 TempPos;

    public AudioSource audioSource;
    public AudioClip jumpClip;
    public AudioClip enemyKillClip;

    public static Player instance;


    private Rigidbody2D body;
    private SpriteRenderer sr;

    public Sprite skinOne, skinTwo, skinThree, skinFour, skinFive, skinSix, skinSeven, skinEight, skinNine;

    public GameObject pause;

    private ClickFunctions pausedScript;

    [SerializeField]
    private float playerMinX, playerMaxX;

    [SerializeField]
    private float moveForce;

    [SerializeField]
    private float moveSmooth = 0.5f;

    [SerializeField]
    private float jumpForce;

    private float movex;

    private bool isGrounded;

    private Vector3 velocity = Vector3.zero;

    public ParticleSystem PlayerTrail1;
    public ParticleSystem PlayerTrail2;
    public ParticleSystem PlayerTrail3;
    public ParticleSystem PlayerTrail4;
    public ParticleSystem PlayerTrail5;
    public ParticleSystem PlayerTrail6;
    public ParticleSystem PlayerTrail7;
    public ParticleSystem PlayerTrail8;
    public ParticleSystem PlayerTrail9;
    public GameObject trail1;
    public GameObject trail2;
    public GameObject trail3;
    public GameObject trail4;
    public GameObject trail5;
    public GameObject trail6;
    public GameObject trail7;
    public GameObject trail8;
    public GameObject trail9;

    private Scene scene;

    public int levelStarCount = 0;

    [SerializeField]
    private GameObject baseCollider;

    PhotonView view;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        scene = SceneManager.GetActiveScene();
        view = GetComponent<PhotonView>();

        if (PlayerPrefs.GetInt("Skin", 1) == 1)
        {
            sr.sprite = skinOne;

        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 2)
        {
            sr.sprite = skinTwo;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 3)
        {
            sr.sprite = skinThree;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 4)
        {
            sr.sprite = skinFour;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 5)
        {
            sr.sprite = skinFive;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 6)
        {
            sr.sprite = skinSix;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 7)
        {
            sr.sprite = skinSeven;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 8)
        {
            sr.sprite = skinEight;
        }
        else if (PlayerPrefs.GetInt("Skin", 1) == 9)
        {
            sr.sprite = skinNine;
        }

    }

    private void Start()
    {


        if (view.IsMine)
        {
            pause = GameObject.FindWithTag("Pause");
            pausedScript = pause.GetComponent<ClickFunctions>();

        }


    }

    private void Update()
    {

        if (view.IsMine)
        {



            movex = Input.GetAxisRaw("Horizontal") * moveForce;

            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                sr.flipX = false;

            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                sr.flipX = true;

            }

            if (pausedScript.paused == false)
            {
                PlayerJump();
                Move(movex);

            }
            else
            {
                StartCoroutine(Wait());
            }

            TempPos = transform.position;
            if (antiGrav)
            {
                TempPos.y += 0.077f;

            }
            else
            {
                TempPos.y -= 0.077f;
            }

            trail1.transform.position = TempPos;
            trail2.transform.position = TempPos;
            trail3.transform.position = TempPos;
            trail4.transform.position = TempPos;
            trail5.transform.position = TempPos;
            trail6.transform.position = TempPos;
            trail7.transform.position = TempPos;
            trail8.transform.position = TempPos;
            trail9.transform.position = TempPos;
        }
        




    }

    IEnumerator Wait()
    {
        body.velocity = new Vector2(0f, 0f);
        body.gravityScale = 0;

        yield return new WaitUntil(() => pausedScript.paused == false);

        if (antiGrav)
        {


            body.gravityScale = -1;


        }
        else
        {
            body.gravityScale = 1;


        }
    }



    private void Move(float move)
    {

        if (Input.GetButton("Horizontal"))
        {

            Trail();

        }

        Vector3 targetVelocity = new Vector2(move * 10f, body.velocity.y);

        body.velocity = Vector3.SmoothDamp(body.velocity, targetVelocity, ref velocity, moveSmooth);




    }

    void PlayerJump()
    {

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            if (body.gravityScale == 1)
            {

                jumps = PlayerPrefs.GetInt("Jumps");

                jumps++;

                PlayerPrefs.SetInt("Jumps", jumps);


                body.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

                if (PlayerPrefs.GetInt("SFX", 1) == 1)
                {
                    audioSource.PlayOneShot(jumpClip);
                }


            }
            else if (body.gravityScale == -1)
            {

                jumps = PlayerPrefs.GetInt("Jumps");

                jumps++;

                PlayerPrefs.SetInt("Jumps", jumps);


                body.AddForce(new Vector2(0f, -jumpForce), ForceMode2D.Impulse);

                if (PlayerPrefs.GetInt("SFX", 1) == 1)
                {
                    audioSource.PlayOneShot(jumpClip);
                }

            }

            Trail();

        }


    }

    private void OnEnable()
    {
        PlayerBase.onGroundTouch += groundIsTouching;
        StarManager.onStarCollect += addStar;
    }

    private void OnDisable()
    {
        PlayerBase.onGroundTouch -= groundIsTouching;
        StarManager.onStarCollect -= addStar;
    }

    private void groundIsTouching()
    {
        isGrounded = true;
    }

    private void addStar()
    {
        levelStarCount++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Spike"))
        {


            Die();


        }


        if (collision.gameObject.CompareTag("Kill_Point"))
        {

            if (body.gravityScale == 1)
            {
                body.AddForce(new Vector2(0f, 5), ForceMode2D.Impulse);
                isGrounded = false;

            }
            else if (body.gravityScale == -1)
            {
                body.AddForce(new Vector2(0f, -5), ForceMode2D.Impulse);
                isGrounded = false;
            }

            if (PlayerPrefs.GetInt("SFX", 1) == 1)
            {
                audioSource.PlayOneShot(enemyKillClip);
            }

            Trail();

        }


        if (collision.gameObject.CompareTag("Enemy"))
        {


            Die();



        }





    }


    private void Trail()
    {
        if (PlayerPrefs.GetInt("Skin", 1) == 1)
        {
            PlayerTrail1.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 2)
        {
            PlayerTrail2.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 3)
        {
            PlayerTrail3.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 4)
        {
            PlayerTrail4.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 5)
        {
            PlayerTrail5.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 6)
        {
            PlayerTrail6.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 7)
        {
            PlayerTrail7.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 8)
        {
            PlayerTrail8.Play();
        }
        else if (PlayerPrefs.GetInt("Skin") == 9)
        {
            PlayerTrail9.Play();
        }


    }


    private void Die()
    {
        if (PlayerPrefs.GetInt("Speedrun", 0) == 1)
        {
            PlayerPrefs.SetFloat("SavedTime", timer);


            if (onPlayerDeath != null)
                onPlayerDeath();


            if (playerRespawn != null)
                playerRespawn();

            gameObject.SetActive(false);
        }
        else
        {
            deaths = PlayerPrefs.GetInt("Deaths");

            deaths++;

            PlayerPrefs.SetInt("Deaths", deaths);

            if (onPlayerDeath != null)
                onPlayerDeath();


            if (playerRespawn != null)
                playerRespawn();

            gameObject.SetActive(false);
        }



    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("Bullet"))
        {


            Die();



        }

        if (collision.gameObject.CompareTag("greenKey"))
        {
            if (greenKey == false)
            {
                greenKey = true;


                if (onKeyCollect != null)
                    onKeyCollect();
            }

        }
        if (collision.gameObject.CompareTag("redKey"))
        {

            if (redKey == false)
            {
                redKey = true;

                if (onKeyCollect != null)
                    onKeyCollect();

            }

        }
        if (collision.gameObject.CompareTag("yellowKey"))
        {

            if (yellowKey == false)
            {
                yellowKey = true;

                if (onKeyCollect != null)
                    onKeyCollect();
            }

        }
        if (collision.gameObject.CompareTag("blueKey"))
        {

            if (blueKey == false)
            {
                blueKey = true;

                if (onKeyCollect != null)
                    onKeyCollect();
            }

        }


        if (collision.gameObject.CompareTag("Anti-Grav"))
        {

            gravitySwitches = PlayerPrefs.GetInt("GravitySwitches");

            gravitySwitches++;

            PlayerPrefs.SetInt("GravitySwitches", gravitySwitches);


            if (body.gravityScale == 1)
            {
                body.AddForce(new Vector2(0f, 1), ForceMode2D.Impulse);
                antiGrav = true;
                sr.flipY = true;

            }
            else if (body.gravityScale == -1)
            {
                body.AddForce(new Vector2(0f, -1), ForceMode2D.Impulse);
                antiGrav = false;
                sr.flipY = false;
            }

            if (antiGravSwitch != null)
                antiGravSwitch();

            body.gravityScale *= -1;

            Trail();
        }


        if (collision.gameObject.CompareTag("Portal"))
        {
            if (PlayerPrefs.GetInt("Speedrun", 0) == 1)
            {
                PlayerPrefs.SetFloat("FinalTime", timer);

                if (PlayerPrefs.GetInt("SingleLevel", 0) == 1)
                {
                    if (PlayerPrefs.GetInt("AllStars", 0) == 1)
                    {
                        if (levelStarCount == 3)
                        {
                            PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                            SceneManager.LoadScene("SpeedrunFinished");
                        }
                    }
                    if (PlayerPrefs.GetInt("NoStars", 0) == 1)
                    {
                        PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                        SceneManager.LoadScene("SpeedrunFinished");
                    }
                }


                if (PlayerPrefs.GetInt("AllLevels", 0) == 1 && scene.name != "Level20")
                {
                    if (PlayerPrefs.GetInt("AllStars", 0) == 1)
                    {
                        if (levelStarCount == 3)
                        {
                            if (scene.name == "Level1")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level2");
                            }
                            if (scene.name == "Level2")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level3");
                            }
                            if (scene.name == "Level3")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level4");
                            }
                            if (scene.name == "Level4")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level5");
                            }
                            if (scene.name == "Level5")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level6");
                            }
                            if (scene.name == "Level6")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level7");
                            }
                            if (scene.name == "Level7")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level8");
                            }
                            if (scene.name == "Level8")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level9");
                            }
                            if (scene.name == "Level9")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level10");
                            }
                            if (scene.name == "Level10")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level11");
                            }
                            if (scene.name == "Level11")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level12");
                            }
                            if (scene.name == "Level12")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level13");
                            }
                            if (scene.name == "Level13")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level14");
                            }
                            if (scene.name == "Level14")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level15");
                            }
                            if (scene.name == "Level15")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level16");
                            }
                            if (scene.name == "Level16")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level17");
                            }
                            if (scene.name == "Level17")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level18");
                            }
                            if (scene.name == "Level18")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level19");
                            }
                            if (scene.name == "Level19")
                            {
                                PlayerPrefs.SetFloat("SavedTime", timer);
                                SceneManager.LoadScene("Level20");
                            }
                        }
                    }
                    else if (PlayerPrefs.GetInt("NoStars", 0) == 1)
                    {
                        if (scene.name == "Level1")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level2");
                        }
                        if (scene.name == "Level2")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level3");
                        }
                        if (scene.name == "Level3")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level4");
                        }
                        if (scene.name == "Level4")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level5");
                        }
                        if (scene.name == "Level5")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level6");
                        }
                        if (scene.name == "Level6")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level7");
                        }
                        if (scene.name == "Level7")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level8");
                        }
                        if (scene.name == "Level8")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level9");
                        }
                        if (scene.name == "Level9")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level10");
                        }
                        if (scene.name == "Level10")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level11");
                        }
                        if (scene.name == "Level11")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level12");
                        }
                        if (scene.name == "Level12")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level13");
                        }
                        if (scene.name == "Level13")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level14");
                        }
                        if (scene.name == "Level14")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level15");
                        }
                        if (scene.name == "Level15")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level16");
                        }
                        if (scene.name == "Level16")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level17");
                        }
                        if (scene.name == "Level17")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level18");
                        }
                        if (scene.name == "Level18")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level19");
                        }
                        if (scene.name == "Level19")
                        {
                            PlayerPrefs.SetFloat("SavedTime", timer);
                            SceneManager.LoadScene("Level20");
                        }
                    }
                }
                else if (PlayerPrefs.GetInt("AllLevels", 0) == 1 && scene.name == "Level20")
                {
                    SceneManager.LoadScene("SpeedrunFinished");
                }

            }
            else
            {
                if (scene.name == "Level1")
                {
                    if (PlayerPrefs.GetInt("Level1Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level1Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");

                }
                else if (scene.name == "Level2")
                {
                    if (PlayerPrefs.GetInt("Level2Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level2Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level3")
                {
                    if (PlayerPrefs.GetInt("Level3Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level3Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level4")
                {
                    if (PlayerPrefs.GetInt("Level4Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level4Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level5")
                {
                    if (PlayerPrefs.GetInt("Level5Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level5Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level6")
                {
                    if (PlayerPrefs.GetInt("Level6Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level6Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level7")
                {
                    if (PlayerPrefs.GetInt("Level7Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level7Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level8")
                {
                    if (PlayerPrefs.GetInt("Level8Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level8Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level9")
                {
                    if (PlayerPrefs.GetInt("Level9Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level9Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level10")
                {
                    if (PlayerPrefs.GetInt("Level10Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level10Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level11")
                {
                    if (PlayerPrefs.GetInt("Level11Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level11Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level12")
                {
                    if (PlayerPrefs.GetInt("Level12Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level12Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level13")
                {
                    if (PlayerPrefs.GetInt("Level13Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level13Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level14")
                {
                    if (PlayerPrefs.GetInt("Level14Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level14Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level15")
                {
                    if (PlayerPrefs.GetInt("Level15Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level15Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level16")
                {
                    if (PlayerPrefs.GetInt("Level16Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level16Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level17")
                {
                    if (PlayerPrefs.GetInt("Level17Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level17Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level18")
                {
                    if (PlayerPrefs.GetInt("Level18Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level18Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level19")
                {
                    if (PlayerPrefs.GetInt("Level19Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level19Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
                else if (scene.name == "Level20")
                {
                    if (PlayerPrefs.GetInt("Level20Stars", 0) < levelStarCount)
                    {
                        PlayerPrefs.SetInt("Level20Stars", levelStarCount);
                    }

                    PlayerPrefs.SetInt("lastStars", levelStarCount);
                    levelStarCount = 0;
                    PlayerPrefs.SetString("lastScene", scene.name);
                    PlayerPrefs.SetInt("lastSceneNum", scene.buildIndex);
                    SceneManager.LoadScene("NextLevel");
                }
            }



        }





    }
}
