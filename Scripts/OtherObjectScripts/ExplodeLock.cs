using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeLock : MonoBehaviour
{

    public ParticleSystem LockExplodeGreen;
    public ParticleSystem LockExplodeRed;
    public ParticleSystem LockExplodeYellow;
    public ParticleSystem LockExplodeBlue;



    private void Start()
    {
        StartCoroutine(Explode());
    }

    IEnumerator Explode()
    {
        if (GameObject.FindWithTag("greenLock") != null)
        {
            if (GameObject.FindWithTag("greenLock").GetComponent<LockManager>().greenOpen == true)
            {
                LockExplodeGreen.Play();
                yield return new WaitForSeconds(2f);
                Destroy(gameObject);
            }
        }
        if (GameObject.FindWithTag("redLock") != null)
        {
            if (GameObject.FindWithTag("redLock").GetComponent<LockManager>().redOpen == true)
            {
                LockExplodeRed.Play();
                yield return new WaitForSeconds(2f);
                Destroy(gameObject);
            }
        }
        if (GameObject.FindWithTag("yellowLock") != null)
        {
            if (GameObject.FindWithTag("yellowLock").GetComponent<LockManager>().yellowOpen == true)
            {
                LockExplodeYellow.Play();
                yield return new WaitForSeconds(2f);
                Destroy(gameObject);
            }
        }
        if (GameObject.FindWithTag("blueLock") != null)
        {
            if (GameObject.FindWithTag("blueLock").GetComponent<LockManager>().blueOpen == true)
            {
                LockExplodeBlue.Play();
                yield return new WaitForSeconds(2f);
                Destroy(gameObject);
            }
        }

        
    }




    [System.Obsolete]
    private void OnEnable()
    {
        Player.antiGravSwitch += switchGrav;
    }

    [System.Obsolete]
    private void OnDisable()
    {
        Player.antiGravSwitch -= switchGrav;
    }


    [System.Obsolete]
    private void switchGrav()
    {
        LockExplodeGreen.gravityModifier *= -1;
        LockExplodeRed.gravityModifier *= -1;
        LockExplodeYellow.gravityModifier *= -1;
        LockExplodeBlue.gravityModifier *= -1;
    }
}
