using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{

    public delegate void CollectStar();
    public static event CollectStar onStarCollect;


    public ParticleSystem StarTrail;

    public GameObject explodeStarPre;


    private void Update()
    {
        Trail();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explodeStarPre, transform.position, Quaternion.identity);

            if (onStarCollect != null)
                onStarCollect();

            Destroy(gameObject);

        }
        
    }


    private void Trail()
    {
        StarTrail.Play();
    }
}
