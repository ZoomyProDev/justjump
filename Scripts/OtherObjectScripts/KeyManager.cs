using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyManager : MonoBehaviour
{

    public GameObject greenKey;
    public GameObject redKey;
    public GameObject yellowKey;
    public GameObject blueKey;

    private int uses;

    private SpriteRenderer sr;

    private bool antiGrav;

    private Vector3 TempPos;
    private bool found = false;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        Player.onKeyCollect += foundKey;
        Player.onPlayerDeath += destroy;
        LockManager.onKeyUse += usedKey;
        Player.antiGravSwitch += switchGrav;
    }

    private void OnDisable()
    {
        Player.onKeyCollect -= foundKey;
        Player.onPlayerDeath -= destroy;
        LockManager.onKeyUse -= usedKey;
        Player.antiGravSwitch -= switchGrav;
    }

    private void foundKey()
    {
        if (gameObject == greenKey && GameObject.FindWithTag("Player").GetComponent<Player>().greenKey == true)
        {
            found = true;
        }
        if (gameObject == redKey && GameObject.FindWithTag("Player").GetComponent<Player>().redKey == true)
        {
            found = true;
        }
        if (gameObject == yellowKey && GameObject.FindWithTag("Player").GetComponent<Player>().yellowKey == true)
        {
            found = true;
        }
        if (gameObject == blueKey && GameObject.FindWithTag("Player").GetComponent<Player>().blueKey == true)
        {
            found = true;

        }

    }

    private void usedKey()
    {
        if (gameObject == greenKey && GameObject.FindWithTag("greenLock").GetComponent<LockManager>().greenOpen == true)
        {
            transform.position = GameObject.FindWithTag("greenLock").GetComponent<Transform>().position;

            uses = PlayerPrefs.GetInt("DoorsUnlocked");

            uses++;

            PlayerPrefs.SetInt("DoorsUnlocked", uses);

            Destroy(gameObject);
        }

        if (gameObject == redKey && GameObject.FindWithTag("redLock").GetComponent<LockManager>().redOpen == true)
        {
            transform.position = GameObject.FindWithTag("redLock").GetComponent<Transform>().position;

            uses = PlayerPrefs.GetInt("DoorsUnlocked");

            uses++;

            PlayerPrefs.SetInt("DoorsUnlocked", uses);

            Destroy(gameObject);
        }

        if (gameObject == yellowKey && GameObject.FindWithTag("yellowLock").GetComponent<LockManager>().yellowOpen == true)
        {
            transform.position = GameObject.FindWithTag("yellowLock").GetComponent<Transform>().position;

            uses = PlayerPrefs.GetInt("DoorsUnlocked");

            uses++;

            PlayerPrefs.SetInt("DoorsUnlocked", uses);

            Destroy(gameObject);
        }

        if (gameObject == blueKey && GameObject.FindWithTag("blueLock").GetComponent<LockManager>().blueOpen == true)
        {
            transform.position = GameObject.FindWithTag("blueLock").GetComponent<Transform>().position;

            uses = PlayerPrefs.GetInt("DoorsUnlocked");

            uses++;

            PlayerPrefs.SetInt("DoorsUnlocked", uses);

            Destroy(gameObject);
        }



    }

    private void destroy()
    {
        Destroy(gameObject);
    }


    private void Update()
    {
        if (found)
        {
            TempPos = GameObject.FindWithTag("Player").transform.position;

            if (antiGrav)
            {
                sr.flipY = true;
                if (gameObject == greenKey)
                {
                    TempPos.y -= 0.05f;
                }
                else if (gameObject == redKey)
                {
                    TempPos.y -= 0.1f;
                }
                else if (gameObject == yellowKey)
                {
                    TempPos.y -= 0.15f;
                }
                else if (gameObject == blueKey)
                {
                    TempPos.y -= 0.2f;
                }

                transform.position = TempPos;

            } else
            {
                sr.flipY = false;

                if (gameObject == greenKey)
                {
                    TempPos.y += 0.05f;
                }
                else if (gameObject == redKey)
                {
                    TempPos.y += 0.1f;
                }
                else if (gameObject == yellowKey)
                {
                    TempPos.y += 0.15f;
                }
                else if (gameObject == blueKey)
                {
                    TempPos.y += 0.2f;
                }

                transform.position = TempPos;
            }
            
        }
        
    }
    
    private void switchGrav()
    {
        if (antiGrav)
        {
            antiGrav = false;

        } else
        {
            antiGrav = true;
        }
        
    }

}
