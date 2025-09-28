using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeEnemy : MonoBehaviour
{

    public bool reversed;

    public bool jump;

    public bool poison;

    public bool jumpingPlus;

    public bool shoot;

    public ParticleSystem EnemyExplode1;
    public ParticleSystem EnemyExplode2;
    public ParticleSystem EnemyExplode3;
    public ParticleSystem EnemyExplode4;
    public ParticleSystem EnemyExplode5;



    [System.Obsolete]
    private void Start()
    {
        StartCoroutine(Explode());
    }

    [System.Obsolete]
    IEnumerator Explode()
    {
        if (reversed)
        {
            EnemyExplode1.gravityModifier = -1;
            EnemyExplode2.gravityModifier = -1;
            EnemyExplode3.gravityModifier = -1;
            EnemyExplode4.gravityModifier = -1;
            EnemyExplode5.gravityModifier = -1;

        } else
        {
            EnemyExplode1.gravityModifier = 1;
            EnemyExplode2.gravityModifier = 1;
            EnemyExplode3.gravityModifier = 1;
            EnemyExplode4.gravityModifier = 1;
            EnemyExplode5.gravityModifier = 1;
        }


        if (poison)
        {
            EnemyExplode3.Play();
        }
        else if (jump) 
        {
            EnemyExplode2.Play();
        }
        else if (shoot) 
        {
            EnemyExplode4.Play();
        }
        else if (jumpingPlus)
        {
            EnemyExplode5.Play();
        }
        else
        {
            EnemyExplode1.Play();
        }


        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
