using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;

public class LockManager : MonoBehaviour
{

    public GameObject explodeLockPre;

    public GameObject greenLock;
    public GameObject redLock;
    public GameObject yellowLock;
    public GameObject blueLock;

    public bool greenOpen = false;
    public bool redOpen = false;
    public bool yellowOpen = false;
    public bool blueOpen = false;



    public delegate void UseKey();
    public static event UseKey onKeyUse;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            if (GameObject.FindWithTag("Player").GetComponent<Player>().greenKey == true && gameObject == greenLock)
            {
                greenOpen = true;

                if (onKeyUse != null)
                    onKeyUse();

                Instantiate(explodeLockPre, transform.position, Quaternion.identity);


                Destroy(gameObject);
            }

            if (GameObject.FindWithTag("Player").GetComponent<Player>().redKey == true && gameObject == redLock)
            {

                redOpen = true;

                if (onKeyUse != null)
                    onKeyUse();

                Instantiate(explodeLockPre, transform.position, Quaternion.identity);


                Destroy(gameObject);
            }

            if (GameObject.FindWithTag("Player").GetComponent<Player>().yellowKey == true && gameObject == yellowLock)
            {

                yellowOpen = true;

                if (onKeyUse != null)
                    onKeyUse();

                Instantiate(explodeLockPre, transform.position, Quaternion.identity);


                Destroy(gameObject);
            }

            if (GameObject.FindWithTag("Player").GetComponent<Player>().blueKey == true && gameObject == blueLock)
            {

                blueOpen = true;

                if (onKeyUse != null)
                    onKeyUse();

                Instantiate(explodeLockPre, transform.position, Quaternion.identity);


                Destroy(gameObject);
            }



        }

    }
}