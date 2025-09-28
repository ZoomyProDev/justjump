using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeStar : MonoBehaviour
{
    public ParticleSystem StarExplode;

    private void Start()
    {
        StartCoroutine(Explode());
    }

    IEnumerator Explode()
    {
        StarExplode.Play();
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
